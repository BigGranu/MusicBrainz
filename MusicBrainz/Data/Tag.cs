using System.Collections.Generic;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MusicBrainz.Data
{
  /// <remarks />
  [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
  [XmlRoot(Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
  public class Tag
  {
    /// <remarks />
    public Tag()
    {
      Taglist = new TagData();
      Created = string.Empty;
    }

    /// <remarks />
    [XmlElement("tag-list")]
    public TagData Taglist { get; set; }

    /// <remarks />
    [XmlAttribute("created")]
    public string Created { get; set; }
  }

  /// <remarks />
  public class TagData
  {
    /// <remarks />
    public TagData()
    {
      Tag = new List<TagTags>();
      Count = 0;
      Offset = 0;
    }

    /// <remarks />
    [XmlElement("tag")]
    public List<TagTags> Tag { get; set; }

    /// <remarks />
    [XmlAttribute("count")]
    public int Count { get; set; }

    /// <remarks />
    [XmlAttribute("offset")]
    public int Offset { get; set; }
  }

  /// <remarks />
  public class TagTags
  {
    /// <remarks />
    public TagTags()
    {
      Name = string.Empty;
      Score = 0;
    }

    /// <remarks />
    [XmlElement("name")]
    public string Name { get; set; }

    /// <remarks />
    [XmlAttribute("score", Form = XmlSchemaForm.Qualified, Namespace = "http://musicbrainz.org/ns/ext#-2.0")]
    public int Score { get; set; }
  }
}
