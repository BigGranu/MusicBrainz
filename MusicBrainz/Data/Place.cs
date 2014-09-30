using System.Collections.Generic;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MusicBrainz.Data
{
  /// <remarks />
  [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
  [XmlRoot("place-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
  public class Place
  {
    /// <remarks />
    public Place()
    {
      Data = new List<PlaceData>();
      Offset = 0;
      Count = 0;
    }

    /// <remarks />
    [XmlElement("place")]
    public List<PlaceData> Data { get; set; }

    /// <remarks />
    [XmlAttribute("count")]
    public int Count { get; set; }

    /// <remarks />
    [XmlAttribute("offset")]
    public int Offset { get; set; }
  }

  /// <remarks />
  public class PlaceData
  {
    /// <remarks />
    public PlaceData()
    {
      Name = string.Empty;
      Address = string.Empty;
      Coordinates = new Coordinates();
      Area = new GArea();
      Lifespan = new Lifespan();
      Aliaslist = new List<Alias>();
      Id = string.Empty;
      Type = string.Empty;
      Score = 0;
    }

    /// <remarks />
    [XmlElement("name")]
    public string Name { get; set; }

    /// <remarks />
    [XmlElement("address")]
    public string Address { get; set; }

    /// <remarks />
    [XmlElement("coordinates")]
    public Coordinates Coordinates { get; set; }

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
    [XmlAttribute("type")]
    public string Type { get; set; }

    /// <remarks />
    [XmlAttribute("score", Form = XmlSchemaForm.Qualified, Namespace = "http://musicbrainz.org/ns/ext#-2.0")]
    public int Score { get; set; }
  }
}