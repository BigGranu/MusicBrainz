using System.Collections.Generic;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MusicBrainz.Data
{
  /// <remarks />
  [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
  [XmlRoot("release-group-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
  public class Releasegroup
  {
    /// <remarks />
    public Releasegroup()
    {
      Data = new List<ReleasegroupData>();
      Offset = 0;
      Count = 0;
    }

    /// <remarks />
    [XmlElement("release-group")]
    public List<ReleasegroupData> Data { get; set; }

    /// <remarks />
    [XmlAttribute("count")]
    public int Count { get; set; }

    /// <remarks />
    [XmlAttribute("offset")]
    public int Offset { get; set; }
  }

  /// <remarks />
  public class ReleasegroupData
  {
    /// <remarks />
    public ReleasegroupData()
    {
      Title = string.Empty;
      Primarytype = string.Empty;
      Artistcredit = new ReleasegroupArtistcredit();
      Releaselist = new ReleasegroupReleaselist();
      Id = string.Empty;
      Type = string.Empty;
      Score = 0;
    }

    /// <remarks />
    [XmlElement("title")]
    public string Title { get; set; }

    /// <remarks />
    [XmlElement("primary-type")]
    public string Primarytype { get; set; }

    /// <remarks />
    [XmlElement("artist-credit")]
    public ReleasegroupArtistcredit Artistcredit { get; set; }

    /// <remarks />
    [XmlElement("release-list")]
    public ReleasegroupReleaselist Releaselist { get; set; }

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
  public class ReleasegroupArtistcredit
  {
    /// <remarks />
    public ReleasegroupArtistcredit()
    {
      Namecredit = new ReleasegroupNamecredit();
    }

    /// <remarks />
    [XmlElement("name-credit")]
    public ReleasegroupNamecredit Namecredit { get; set; }
  }

  /// <remarks />
  public class ReleasegroupNamecredit
  {
    /// <remarks />
    public ReleasegroupNamecredit()
    {
      Artist = new ReleasegroupArtist();
    }

    /// <remarks />
    [XmlElement("artist")]
    public ReleasegroupArtist Artist { get; set; }
  }

  /// <remarks />
  public class ReleasegroupArtist
  {
    /// <remarks />
    public ReleasegroupArtist()
    {
      Name = string.Empty;
      Sortname = string.Empty;
      Disambiguation = string.Empty;
      Aliaslist = new List<Alias>();
      Id = string.Empty;
    }

    /// <remarks />
    [XmlElement("name")]
    public string Name { get; set; }

    /// <remarks />
    [XmlElement("sort-name")]
    public string Sortname { get; set; }

    /// <remarks />
    [XmlElement("disambiguation")]
    public string Disambiguation { get; set; }

    /// <remarks />
    [XmlArray("alias-list"), XmlArrayItem("alias", IsNullable = false)]
    public List<Alias> Aliaslist { get; set; }

    /// <remarks />
    [XmlAttribute("id")]
    public string Id { get; set; }
  }

  /// <remarks />
  public class ReleasegroupReleaselist
  {
    /// <remarks />
    public ReleasegroupReleaselist()
    {
      Release = new ReleasegroupRelease();
      Count = 0;
    }

    /// <remarks />
    [XmlElement("release")]
    public ReleasegroupRelease Release { get; set; }

    /// <remarks />
    [XmlAttribute("count")]
    public int Count { get; set; }
  }

  /// <remarks />
  public class ReleasegroupRelease
  {
    /// <remarks />
    public ReleasegroupRelease()
    {
      Title = string.Empty;
      Status = string.Empty;
      Id = string.Empty;
    }

    /// <remarks />
    [XmlElement("title")]
    public string Title { get; set; }

    /// <remarks />
    [XmlElement("status")]
    public string Status { get; set; }

    /// <remarks />
    [XmlAttribute("id")]
    public string Id { get; set; }
  }
}
