using System;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MusicBrainz
{
  internal class Help
  {
    public static string QueryToString(object o)
    {
      var result =
        o.GetType()
          .GetProperties()
          .Where(property => property.GetValue(o, null) != null)
          .Aggregate(string.Empty,
            (current, property) => current + (property.Name.ToLower() + ":" + property.GetValue(o, null) + "%20AND%20"));

      return result.LastIndexOf("%20AND%20", StringComparison.Ordinal) > 0
        ? result.Substring(0, result.LastIndexOf("%20AND%20", StringComparison.Ordinal))
        : result;
    }

    public static string SearchToString(MethodBase m, params object[] search)
    {
      var paras = m.GetParameters();
      var result = string.Empty;

      for (var i = 0; i < search.Length; i++)
      {
        if (search[i] != null)
        {
          if (i == 0)
          {
            result += search[i] + "%20AND%20";
          }
          else
          {
            result += paras[i].Name.ToLower() + ":" + search[i] + "%20AND%20";
          }         
        }      
      }

      return result.LastIndexOf("%20AND%20", StringComparison.Ordinal) > 0
        ? result.Substring(0, result.LastIndexOf("%20AND%20", StringComparison.Ordinal))
        : result;
    }

    public static string LimitOffsetToString(int limit, int offset)
    {
      var result = string.Empty;

      if (limit != 25)
        result += "&limit=" + limit;

      if (offset != 0)
        result += "&offset=" + offset;

      return result;
    }

    public static XElement Get(string url)
    {
      try
      {
        var request = WebRequest.Create(url) as HttpWebRequest;
        if (request == null)
          return new XElement("");

        request.UserAgent = "MusicBrainze.API/2.0";
        request.Proxy = WebRequest.DefaultWebProxy;
        request.Credentials = CredentialCache.DefaultCredentials;
        request.Proxy.Credentials = CredentialCache.DefaultCredentials;
        request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

        var response = request.GetResponse();

        using (var stream = response.GetResponseStream())
        {
          var xml = XDocument.Load(stream);
          var xsn = new XmlSerializerNamespaces();
          xsn.Add("ext", "http://musicbrainz.org/ns/ext#-2.0");
          return xml.Root != null ? xml.Root.Elements().FirstOrDefault() : new XElement("");
        }
      }
      catch (Exception)
      {
        return new XElement("");
      }
    }

    public static T Find<T>(string query, int limit, int offset, string part)
    {
      var serializer = new XmlSerializer(typeof(T));

      try
      {
        var o = Get("http://musicbrainz.org/ws/2/" + part + "/?query=" + query + LimitOffsetToString(limit, offset));
        {
          return (T)serializer.Deserialize(o.CreateReader());
        }
      }
      catch (Exception)
      {
        return default(T);
      }
    }
  }
}
