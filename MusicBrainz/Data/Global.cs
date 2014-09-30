using System.Xml.Serialization;

namespace MusicBrainz.Data
{
  /// <remarks />
  public class Lifespan
  {
    /// <remarks />
    public Lifespan()
    {
      Begin = string.Empty;
      End = string.Empty;
    }

    /// <remarks />
    [XmlElement("begin")]
    public string Begin { get; set; }

    /// <remarks />
    [XmlElement("end")]
    public string End { get; set; }

    /// <remarks />
    [XmlElement("ended")]
    public bool Ended { get; set; }
  }

  /// <remarks />
  public class Alias
  {
    /// <remarks />
    public Alias()
    {
      Sortname = string.Empty;
      Type = string.Empty;
      Value = string.Empty;
    }

    /// <remarks />
    [XmlAttribute("sort-name")]
    public string Sortname { get; set; }

    /// <remarks />
    [XmlAttribute("type")]
    public string Type { get; set; }

    /// <remarks />
    [XmlText]
    public string Value { get; set; }
  }

  /// <remarks />
  public class Iso31661Codelist
  {
    /// <remarks />
    public Iso31661Codelist()
    {
      Iso31661Code = string.Empty;
    }

    /// <remarks />
    [XmlElement("iso-3166-1-code")]
    public string Iso31661Code { get; set; }
  }

  /// <remarks />
  public class Iso31663Codelist
  {
    /// <remarks />
    public Iso31663Codelist()
    {
      Iso31663Code = string.Empty;
    }

    /// <remarks />
    [XmlElement("iso-3166-3-code")]
    public string Iso31663Code { get; set; }
  }

  /// <remarks />
  public class GArea
  {
    /// <remarks />
    public GArea()
    {
      Name = string.Empty;
      Sortname = string.Empty;
      Id = string.Empty;
      Type = string.Empty;
    }

    /// <remarks />
    [XmlElement("name")]
    public string Name { get; set; }

    /// <remarks />
    [XmlElement("sort-name")]
    public string Sortname { get; set; }

    /// <remarks />
    [XmlAttribute("id")]
    public string Id { get; set; }

    /// <remarks />
    [XmlAttribute("type")]
    public string Type { get; set; }
  }

  /// <remarks />
  public class GTracklist
  {
    /// <remarks />
    public GTracklist()
    {
      Count = string.Empty;
    }

    /// <remarks />
    [XmlAttribute("count")]
    public string Count { get; set; }
  }

  /// <remarks />
  [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
  public class GTag
  {
    /// <remarks />
    public GTag()
    {
      Name = string.Empty;
      Count = 0;
    }

    /// <remarks />
    [XmlElement("name")]
    public string Name { get; set; }

    /// <remarks />
    [XmlAttribute("count")]
    public byte Count { get; set; }
  }

  /// <remarks />
  public class Coordinates
  {
    /// <remarks />
    public Coordinates()
    {
      Latitude = string.Empty;
      Longitude = string.Empty;
    }

    /// <remarks />
    [XmlElement("latitude")]
    public string Latitude { get; set; }

    /// <remarks />
    [XmlElement("longitude")]
    public string Longitude { get; set; }
  }
}
