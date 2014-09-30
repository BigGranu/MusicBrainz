using System.Collections.Generic;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MusicBrainz.Data
{
  /// <remarks />
  [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
  [XmlRoot("label-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
  public class Label
  {
    /// <remarks />
    public Label()
    {
      Data = new List<LabelData>();
      Offset = 0;
      Count = 0;
    }

    /// <remarks />
    [XmlElement("label")]
    public List<LabelData> Data { get; set; }

    /// <remarks />
    [XmlAttribute("count")]
    public int Count { get; set; }

    /// <remarks />
    [XmlAttribute("offset")]
    public int Offset { get; set; }
  }

  /// <remarks />
  public class LabelData
  {
    /// <remarks />
    public LabelData()
    {
      Name = string.Empty;
      Sortname = string.Empty;
      Country = string.Empty;
      Area = new GArea();
      Lifespan = new Lifespan();
      Aliaslist = new List<Alias>();
      Id = string.Empty;
      Score = 0;
      Type = string.Empty;
    }

    /// <remarks />
    [XmlElement("name")]
    public string Name { get; set; }

    /// <remarks />
    [XmlElement("sort-name")]
    public string Sortname { get; set; }

    /// <remarks />
    [XmlElement("country")]
    public string Country { get; set; }

    /// <remarks />
    [XmlElement("area")]
    public GArea Area { get; set; }

    /// <remarks />
    [XmlElement("life-span")]
    public Lifespan Lifespan { get; set; }

    /// <remarks />
    [XmlArray("alias-list"), XmlArrayItem("alias", IsNullable = false)]
    public List<Alias> Aliaslist { get; set; }

    /// <remarks />
    [XmlAttribute("id")]
    public string Id { get; set; }

    /// <remarks />
    [XmlAttribute("score", Form = XmlSchemaForm.Qualified, Namespace = "http://musicbrainz.org/ns/ext#-2.0")]
    public int Score { get; set; }

    /// <remarks />
    [XmlAttribute("type")]
    public string Type { get; set; }
  }
}