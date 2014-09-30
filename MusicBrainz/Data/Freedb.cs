using System.Collections.Generic;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MusicBrainz.Data
{
  /// <remarks />
  [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
  [XmlRoot("freedb-disc-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
  public class Freedb
  {
    /// <remarks />
    public Freedb()
    {
      Data = new List<FreedbData>();
      Offset = 0;
      Count = 0;
    }

    /// <remarks />
    [XmlElement("freedb-disc")]
    public List<FreedbData> Data { get; set; }

    /// <remarks />
    [XmlAttribute("count")]
    public int Count { get; set; }

    /// <remarks />
    [XmlAttribute("offset")]
    public int Offset { get; set; }
  }

  /// <remarks />
  public class FreedbData
  {
    /// <remarks />
    public FreedbData()
    {
      Title = string.Empty;
      Artist = string.Empty;
      Category = string.Empty;
      Year = string.Empty;
      Tracklist = new GTracklist();
      Id = string.Empty;
      Score = 0;
    }

    /// <remarks />
    [XmlElement("title")]
    public string Title { get; set; }

    /// <remarks />
    [XmlElement("artist")]
    public string Artist { get; set; }

    /// <remarks />
    [XmlElement("category")]
    public string Category { get; set; }

    /// <remarks />
    [XmlElement("year")]
    public string Year { get; set; }

    /// <remarks />
    [XmlElement("track-list")]
    public GTracklist Tracklist { get; set; }

    /// <remarks />
    [XmlAttribute("id")]
    public string Id { get; set; }

    /// <remarks />
    [XmlAttribute("score", Form = XmlSchemaForm.Qualified, Namespace = "http://musicbrainz.org/ns/ext#-2.0")]
    public int Score { get; set; }
  }
}