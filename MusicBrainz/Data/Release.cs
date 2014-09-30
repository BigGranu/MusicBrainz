using System.Collections.Generic;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MusicBrainz.Data
{
  /// <remarks />
  [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
  [XmlRoot("release-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
  public class Release
  {
    /// <remarks />
    public Release()
    {
      Data = new List<ReleaseData>();
      Offset = 0;
      Count = 0;
    }

    /// <remarks />
    [XmlElement("release")]
    public List<ReleaseData> Data { get; set; }

    /// <remarks />
    [XmlAttribute("count")]
    public int Count { get; set; }

    /// <remarks />
    [XmlAttribute("offset")]
    public int Offset { get; set; }
  }

  /// <remarks />
  public class ReleaseData
  {
    /// <remarks />
    public ReleaseData()
    {
      Title = string.Empty;
      Status = string.Empty;
      Packaging = string.Empty;
      Textrepresentation = new ReleaseTextrepresentation();
      Artistcredit = new List<ReleaseNamecredit>();
      Releasegroup = new ReleaseReleasegroup();
      Date = string.Empty;
      Country = string.Empty;
      Releaseeventlist = new ReleaseReleaseeventlist();
      Barcode = string.Empty;
      Asin = string.Empty;
      Labelinfolist = new List<ReleaseLabelinfo>();
      Mediumlist = new ReleaseMediumlist();
      Id = string.Empty;
      Score = 0;
    }

    /// <remarks />
    [XmlElement("title")]
    public string Title { get; set; }

    /// <remarks />
    [XmlElement("status")]
    public string Status { get; set; }

    /// <remarks />
    [XmlElement("packaging")]
    public string Packaging { get; set; }

    /// <remarks />
    [XmlElement("text-representation")]
    public ReleaseTextrepresentation Textrepresentation { get; set; }

    /// <remarks />
    [XmlArray("artist-credit"), XmlArrayItem("name-credit", IsNullable = false)]
    public List<ReleaseNamecredit> Artistcredit { get; set; }

    /// <remarks />
    [XmlElement("release-group")]
    public ReleaseReleasegroup Releasegroup { get; set; }

    /// <remarks />
    [XmlElement("date")]
    public string Date { get; set; }

    /// <remarks />
    [XmlElement("country")]
    public string Country { get; set; }

    /// <remarks />
    [XmlElement("release-event-list")]
    public ReleaseReleaseeventlist Releaseeventlist { get; set; }

    /// <remarks />
    [XmlElement("barcode")]
    public string Barcode { get; set; }

    /// <remarks />
    [XmlElement("asin")]
    public string Asin { get; set; }

    /// <remarks />
    [XmlArray("label-info-list"), XmlArrayItem("label-info", IsNullable = false)]
    public List<ReleaseLabelinfo> Labelinfolist { get; set; }

    /// <remarks />
    [XmlElement("medium-list")]
    public ReleaseMediumlist Mediumlist { get; set; }

    /// <remarks />
    [XmlAttribute("id")]
    public string Id { get; set; }

    /// <remarks />
    [XmlAttribute("score", Form = XmlSchemaForm.Qualified, Namespace = "http://musicbrainz.org/ns/ext#-2.0")]
    public int Score { get; set; }
  }

  /// <remarks />
  public class ReleaseTextrepresentation
  {
    /// <remarks />
    public ReleaseTextrepresentation()
    {
      Language = string.Empty;
      Script = string.Empty;
    }

    /// <remarks />
    [XmlElement("language")]
    public string Language { get; set; }

    /// <remarks />
    [XmlElement("script")]
    public string Script { get; set; }
  }

  /// <remarks />
  public class ReleaseNamecredit
  {
    /// <remarks />
    public ReleaseNamecredit()
    {
      Name = string.Empty;
      Artist = new ReleaseArtist();
      Joinphrase = string.Empty;
    }

    /// <remarks />
    [XmlElement("name")]
    public string Name { get; set; }

    /// <remarks />
    [XmlElement("artist")]
    public ReleaseArtist Artist { get; set; }

    /// <remarks />
    [XmlAttribute("joinphrase")]
    public string Joinphrase { get; set; }
  }

  /// <remarks />
  public class ReleaseArtist
  {
    /// <remarks />
    public ReleaseArtist()
    {
      Name = string.Empty;
      Sortname = string.Empty;
      Disambiguation = string.Empty;
      Aliaslist = new ReleaseAliaslist();
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
    [XmlElement("alias-list")]
    public ReleaseAliaslist Aliaslist { get; set; }

    /// <remarks />
    [XmlAttribute("id")]
    public string Id { get; set; }
  }

  /// <remarks />
  public class ReleaseAliaslist
  {
    /// <remarks />
    public ReleaseAliaslist()
    {
      Alias = new List<Alias>();
    }

    /// <remarks />
    [XmlElement("alias")]
    public List<Alias> Alias { get; set; }
  }

  /// <remarks />
  public class ReleaseReleasegroup
  {
    /// <remarks />
    public ReleaseReleasegroup()
    {
      Primarytype = string.Empty;
      Secondarytypelist = new ReleaseSecondarytypelist();
      Id = string.Empty;
      Type = string.Empty;
    }

    /// <remarks />
    [XmlElement("primary-type")]
    public string Primarytype { get; set; }

    /// <remarks />
    [XmlElement("secondary-type-list")]
    public ReleaseSecondarytypelist Secondarytypelist { get; set; }

    /// <remarks />
    [XmlAttribute("id")]
    public string Id { get; set; }

    /// <remarks />
    [XmlAttribute("type")]
    public string Type { get; set; }
  }

  /// <remarks />
  public class ReleaseSecondarytypelist
  {
    /// <remarks />
    public ReleaseSecondarytypelist()
    {
      Secondarytype = string.Empty;
    }

    /// <remarks />
    [XmlElement("secondary-type")]
    public string Secondarytype { get; set; }
  }

  /// <remarks />
  public class ReleaseReleaseeventlist
  {
    /// <remarks />
    public ReleaseReleaseeventlist()
    {
      Releaseevent = new ReleaseReleaseevent();
    }

    /// <remarks />
    [XmlElement("release-event")]
    public ReleaseReleaseevent Releaseevent { get; set; }
  }

  /// <remarks />
  public class ReleaseReleaseevent
  {
    /// <remarks />
    public ReleaseReleaseevent()
    {
      Date = string.Empty;
      Area = new ReleaseArea();
    }

    /// <remarks />
    [XmlElement("date")]
    public string Date { get; set; }

    /// <remarks />
    [XmlElement("area")]
    public ReleaseArea Area { get; set; }
  }

  /// <remarks />
  public class ReleaseArea
  {
    /// <remarks />
    public ReleaseArea()
    {
      Name = string.Empty;
      Sortname = string.Empty;
      Iso31661Codelist = new Iso31661Codelist();
      Id = string.Empty;
    }

    /// <remarks />
    [XmlElement("name")]
    public string Name { get; set; }

    /// <remarks />
    [XmlElement("sort-name")]
    public string Sortname { get; set; }

    /// <remarks />
    [XmlElement("iso-3166-1-code-list")]
    public Iso31661Codelist Iso31661Codelist { get; set; }

    /// <remarks />
    [XmlAttribute("id")]
    public string Id { get; set; }
  }

  /// <remarks />
  public class ReleaseLabelinfo
  {
    /// <remarks />
    public ReleaseLabelinfo()
    {
      Catalognumber = string.Empty;
      Label = new ReleaseLabelinfoLabel();
    }

    /// <remarks />
    [XmlElement("catalog-number")]
    public string Catalognumber { get; set; }

    /// <remarks />
    [XmlElement("label")]
    public ReleaseLabelinfoLabel Label { get; set; }
  }

  /// <remarks />
  public class ReleaseLabelinfoLabel
  {
    /// <remarks />
    public ReleaseLabelinfoLabel()
    {
      Name = string.Empty;
      Id = string.Empty;
    }

    /// <remarks />
    [XmlElement("name")]
    public string Name { get; set; }

    /// <remarks />
    [XmlAttribute("id")]
    public string Id { get; set; }
  }

  /// <remarks />
  public class ReleaseMediumlist
  {
    /// <remarks />
    public ReleaseMediumlist()
    {
      Trackcount = 0;
      Medium = new List<ReleaseMedium>();
      Count = 0;
    }

    /// <remarks />
    [XmlElement("track-count")]
    public int Trackcount { get; set; }

    /// <remarks />
    [XmlElement("medium")]
    public List<ReleaseMedium> Medium { get; set; }

    /// <remarks />
    [XmlAttribute("count")]
    public int Count { get; set; }
  }

  /// <remarks />
  public class ReleaseMedium
  {
    /// <remarks />
    public ReleaseMedium()
    {
      Format = string.Empty;
      Disclist = new GTracklist();
      Tracklist = new GTracklist();
    }

    /// <remarks />
    [XmlElement("format")]
    public string Format { get; set; }

    /// <remarks />
    [XmlElement("disc-list")]
    public GTracklist Disclist { get; set; }

    /// <remarks />
    [XmlElement("track-list")]
    public GTracklist Tracklist { get; set; }
  }
}