using System.Collections.Generic;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MusicBrainz.Data
{
  /// <remarks />
  [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
  [XmlRoot("annotation-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
  public class Annotation
  {
    /// <remarks />
    public Annotation()
    {
      Data = new List<AnnotationData>();
      Offset = 0;
      Count = 0;
    }

    /// <remarks />
    [XmlElement("annotation")]
    public List<AnnotationData> Data { get; set; }

    /// <remarks />
    [XmlAttribute("count")]
    public int Count { get; set; }

    /// <remarks />
    [XmlAttribute("offset")]
    public int Offset { get; set; }
  }

  /// <remarks />
  public class AnnotationData
  {
    /// <remarks />
    public AnnotationData()
    {
      Entity = string.Empty;
      Name = string.Empty;
      Text = string.Empty;
      Type = string.Empty;
      Score = 0;
    }

    /// <remarks />
    [XmlElement("entity")]
    public string Entity { get; set; }

    /// <remarks />
    [XmlElement("name")]
    public string Name { get; set; }

    /// <remarks />
    [XmlElement("text")]
    public string Text { get; set; }

    /// <remarks />
    [XmlAttribute("type")]
    public string Type { get; set; }

    /// <remarks />
    [XmlAttribute("score", Form = XmlSchemaForm.Qualified, Namespace = "http://musicbrainz.org/ns/ext#-2.0")]
    public int Score { get; set; }
  }
}
