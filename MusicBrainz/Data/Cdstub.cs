using System.Collections.Generic;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MusicBrainz.Data
{
  /// <remarks />
  [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
  [XmlRoot("cdstub-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
  public class Cdstub
  {
    /// <remarks />
    public Cdstub()
    {
      Data = new List<CdstubData>();
      Offset = 0;
      Count = 0;
    }

    /// <remarks />
    [XmlElement("cdstub")]
    public List<CdstubData> Data { get; set; }

    /// <remarks />
    [XmlAttribute("count")]
    public int Count { get; set; }

    /// <remarks />
    [XmlAttribute("offset")]
    public int Offset { get; set; }
  }

  /// <remarks />
  public class CdstubData
  {
    /// <remarks />
    public CdstubData()
    {
      Title = string.Empty;
      Artist = string.Empty;
      Barcode = string.Empty;
      Comment = string.Empty;
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
    [XmlElement("barcode")]
    public string Barcode { get; set; }

    /// <remarks />
    [XmlElement("comment")]
    public string Comment { get; set; }

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
