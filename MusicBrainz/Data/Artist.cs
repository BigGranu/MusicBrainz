using System.Collections.Generic;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MusicBrainz.Data
{
  /// <remarks />
  [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
  [XmlRoot("artist-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
  public class Artist
  {
    /// <remarks />
    public Artist()
    {
      Data = new List<ArtistData>();
      Offset = 0;
      Count = 0;
    }

    /// <remarks />
    [XmlElement("artist")]
    public List<ArtistData> Data { get; set; }

    /// <remarks />
    [XmlAttribute("count")]
    public int Count { get; set; }

    /// <remarks />
    [XmlAttribute("offset")]
    public int Offset { get; set; }
  }

  /// <remarks />
  public class ArtistData
  {
    /// <remarks />
    public ArtistData()
    {
      Name = string.Empty;
      Sortname = string.Empty;
      Gender = string.Empty;
      Country = string.Empty;
      Area = new GArea();
      Beginarea = new GArea();
      Endarea = new GArea();
      Disambiguation = string.Empty;
      Lifespan = new Lifespan();
      Aliaslist = new List<Alias>();
      Taglist = new List<GTag>();
      Id = string.Empty;
      Type = string.Empty;
      Score = 0;
    }

    /// <remarks />
    [XmlElement("name")]
    public string Name { get; set; }

    /// <remarks />
    [XmlElement("sort-name")]
    public string Sortname { get; set; }

    /// <remarks />
    [XmlElement("gender")]
    public string Gender { get; set; }

    /// <remarks />
    [XmlElement("country")]
    public string Country { get; set; }

    /// <remarks />
    [XmlElement("area")]
    public GArea Area { get; set; }

    /// <remarks />
    [XmlElement("begin-area")]
    public GArea Beginarea { get; set; }

    /// <remarks />
    [XmlElement("end-area")]
    public GArea Endarea { get; set; }

    /// <remarks />
    [XmlElement("disambiguation")]
    public string Disambiguation { get; set; }

    /// <remarks />
    [XmlElement("life-span", IsNullable = false)]
    public Lifespan Lifespan { get; set; }

    /// <remarks />
    [XmlArray("alias-list"), XmlArrayItem("alias", IsNullable = false)]
    public List<Alias> Aliaslist { get; set; }

    /// <remarks />
    [XmlArray("tag-list"), XmlArrayItem("tag", IsNullable = false)]
    public List<GTag> Taglist { get; set; }

    /// <remarks />
    [XmlAttribute("id")]
    public string Id { get; set; }

    /// <remarks />
    [XmlAttribute("type")]
    public string Type { get; set; }

    /// <remarks />
    [XmlAttribute("score", Form = XmlSchemaForm.Qualified, Namespace = "http://musicbrainz.org/ns/ext#-2.0")]
    public int Score { get; set; }
  }
}
