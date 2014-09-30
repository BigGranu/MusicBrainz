using System.Collections.Generic;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MusicBrainz.Data
{
  /// <remarks />
  [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
  [XmlRoot("work-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
  public class Work
  {
    /// <remarks />
    public Work()
    {
      Data = new List<WorkData>();
      Offset = 0;
      Count = 0;
    }

    /// <remarks />
    [XmlElement("work")]
    public List<WorkData> Data { get; set; }

    /// <remarks />
    [XmlAttribute("count")]
    public int Count { get; set; }

    /// <remarks />
    [XmlAttribute("offset")]
    public int Offset { get; set; }
  }

  /// <remarks />
  public class WorkData
  {
    /// <remarks />
    public WorkData()
    {
      Title = string.Empty;
      Language = string.Empty;
      Iswclist = new WorkIswclist();
      Disambiguation = string.Empty;
      Aliaslist = new WorkAliaslist();
      Relationlist = new WorkRelationlist();
      Id = string.Empty;
      Score = 0;
      Type = string.Empty;
    }

    /// <remarks />
    [XmlElement("title")]
    public string Title { get; set; }

    /// <remarks />
    [XmlElement("language")]
    public string Language { get; set; }

    /// <remarks />
    [XmlElement("iswc-list")]
    public WorkIswclist Iswclist { get; set; }

    /// <remarks />
    [XmlElement("disambiguation")]
    public string Disambiguation { get; set; }

    /// <remarks />
    [XmlElement("alias-list")]
    public WorkAliaslist Aliaslist { get; set; }

    /// <remarks />
    [XmlElement("relation-list")]
    public WorkRelationlist Relationlist { get; set; }

    /// <remarks />
    [XmlAttribute("id")]
    public string Id { get; set; }

    /// <remarks />
    [XmlAttribute("Score", Form = XmlSchemaForm.Qualified, Namespace = "http://musicbrainz.org/ns/ext#-2.0")]
    public int Score { get; set; }

    /// <remarks />
    [XmlAttribute("type")]
    public string Type { get; set; }
  }

  /// <remarks />
  public class WorkIswclist
  {
    /// <remarks />
    public WorkIswclist()
    {
      Iswc = string.Empty;
    }

    /// <remarks />
    [XmlElement("iswc")]
    public string Iswc { get; set; }
  }

  /// <remarks />
  public class WorkAliaslist
  {
    /// <remarks />
    public WorkAliaslist()
    {
      Alias = new Alias();
    }

    /// <remarks />
    [XmlElement("alias")]
    public Alias Alias { get; set; }
  }

  /// <remarks />
  public class WorkRelationlist
  {
    /// <remarks />
    public WorkRelationlist()
    {
      Relation = new List<WorkRelation>();
      Targettype = string.Empty;
    }

    /// <remarks />
    [XmlElement("relation")]
    public List<WorkRelation> Relation { get; set; }

    /// <remarks />
    [XmlAttribute("target-type")]
    public string Targettype { get; set; }
  }

  /// <remarks />
  public class WorkRelation
  {
    /// <remarks />
    public WorkRelation()
    {
      Direction = string.Empty;
      Attributelist = new WorkAttributelist();
      Artist = new WorkRelationArtist();
      Type = string.Empty;
    }

    /// <remarks />
    [XmlElement("direction")]
    public string Direction { get; set; }

    /// <remarks />
    [XmlElement("attribute-list")]
    public WorkAttributelist Attributelist { get; set; }

    /// <remarks />
    [XmlElement("artist")]
    public WorkRelationArtist Artist { get; set; }

    /// <remarks />
    [XmlAttribute("type")]
    public string Type { get; set; }
  }

  /// <remarks />
  public class WorkAttributelist
  {
    /// <remarks />
    public WorkAttributelist()
    {
      Attribute = string.Empty;
    }

    /// <remarks />
    [XmlElement("attribute")]
    public string Attribute { get; set; }
  }

  /// <remarks />
  public class WorkRelationArtist
  {
    /// <remarks />
    public WorkRelationArtist()
    {
      Name = string.Empty;
      Sortname = string.Empty;
      Id = string.Empty;
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
  }
}
