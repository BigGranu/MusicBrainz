using System.Collections.Generic;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MusicBrainz.Data
{
  /// <remarks />
  [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
  [XmlRoot("area-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
  public class Area
  {
    /// <remarks />
    public Area()
    {
      Data = new List<AreaData>();
      Offset = 0;
      Count = 0;
    }

    /// <remarks />
    [XmlElement("area")]
    public List<AreaData> Data { get; set; }

    /// <remarks />
    [XmlAttribute("count")]
    public int Count { get; set; }

    /// <remarks />
    [XmlAttribute("offset")]
    public int Offset { get; set; }
  }

  /// <remarks />
  public class AreaData
  {
    /// <remarks />
    public AreaData()
    {
      Name = string.Empty;
      Sortname = string.Empty;
      Iso31661 = new Iso31661Codelist();
      Iso31663 = new Iso31663Codelist();
      Lifespan = new Lifespan();
      Aliaslist = new List<AreaAlias>();
      Relationlist = new AreaRelationlist();
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
    [XmlElement("iso-3166-3-code-list")]
    public Iso31663Codelist Iso31663 { get; set; }

    /// <remarks />
    [XmlElement("iso-3166-1-code-list")]
    public Iso31661Codelist Iso31661 { get; set; }

    /// <remarks />
    [XmlElement("life-span")]
    public Lifespan Lifespan { get; set; }

    /// <remarks />
    [XmlArray("alias-list")]
    [XmlArrayItem("alias", IsNullable = false)]
    public List<AreaAlias> Aliaslist { get; set; }

    /// <remarks />
    [XmlElement("relation-list")]
    public AreaRelationlist Relationlist { get; set; }

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

  /// <remarks />
  public class AreaAlias
  {
    /// <remarks />
    public AreaAlias()
    {
      Sortname = string.Empty;
      Locale = string.Empty;
      Value = string.Empty;
    }

    /// <remarks />
    [XmlAttribute("locale")]
    public string Locale { get; set; }

    /// <remarks />
    [XmlAttribute("sort-name")]
    public string Sortname { get; set; }

    /// <remarks />
    [XmlText]
    public string Value { get; set; }
  }

  /// <remarks />
  public class AreaRelationlist
  {
    /// <remarks />
    public AreaRelationlist()
    {
      Relation = new AreaRelation();
      Targettype = string.Empty;
    }

    /// <remarks />
    [XmlElement("relation")]
    public AreaRelation Relation { get; set; }

    /// <remarks />
    [XmlAttribute("target-type")]
    public string Targettype { get; set; }
  }

  /// <remarks />
  public class AreaRelation
  {
    /// <remarks />
    public AreaRelation()
    {
      Target = string.Empty;
      Direction = string.Empty;
      Area = new GArea();
      Type = string.Empty;
      Typeid = string.Empty;
    }

    /// <remarks />
    [XmlElement("target")]
    public string Target { get; set; }

    /// <remarks />
    [XmlElement("direction")]
    public string Direction { get; set; }

    /// <remarks />
    [XmlElement("area")]
    public GArea Area { get; set; }

    /// <remarks />
    [XmlAttribute("type")]
    public string Type { get; set; }

    /// <remarks />
    [XmlAttribute("type-id")]
    public string Typeid { get; set; }
  }

  /// <remarks />
  public class AreaRelationAreaLifespan
  {
    /// <remarks />
    [XmlElement("ended")]
    public bool Ended { get; set; }
  }
}
