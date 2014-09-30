using System.Collections.Generic;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace MusicBrainz.Data
{
  /// <remarks />
  [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
  [XmlRoot("recording-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
  public class Recording
  {
    /// <remarks />
    public Recording()
    {
      Data = new List<RecordingData>();
      Offset = 0;
      Count = 0;
    }

    /// <remarks />
    [XmlElement("recording")]
    public List<RecordingData> Data { get; set; }

    /// <remarks />
    [XmlAttribute("count")]
    public int Count { get; set; }

    /// <remarks />
    [XmlAttribute("offset")]
    public int Offset { get; set; }
  }

  /// <remarks />
  public class RecordingData
  {
    /// <remarks />
    public RecordingData()
    {
      Title = string.Empty;
      Length = 0;
      Artistcredit = new List<RecordingNamecredit>();
      Releaselist = new List<RecordingRelease>();
      Isrclist = new RecordingIsrclist();
      Id = string.Empty;
      Score = 0;
    }

    /// <remarks />
    [XmlElement("title")]
    public string Title { get; set; }

    /// <remarks />
    [XmlElement("length")]
    public int Length { get; set; }

    /// <remarks />
    [XmlArray("artist-credit"), XmlArrayItem("name-credit", IsNullable = false)]
    public List<RecordingNamecredit> Artistcredit { get; set; }

    /// <remarks />
    [XmlArray("release-list"), XmlArrayItem("release", IsNullable = false)]
    public List<RecordingRelease> Releaselist { get; set; }

    /// <remarks />
    [XmlElement("isrc-list")]
    public RecordingIsrclist Isrclist { get; set; }

    /// <remarks />
    [XmlAttribute("id")]
    public string Id { get; set; }

    /// <remarks />
    [XmlAttribute("score", Form = XmlSchemaForm.Qualified, Namespace = "http://musicbrainz.org/ns/ext#-2.0")]
    public int Score { get; set; }
  }

  /// <remarks />
  public class RecordingNamecredit
  {
    /// <remarks />
    public RecordingNamecredit()
    {
      Artist = new RecordingArtist();
      Joinphrase = string.Empty;
    }

    /// <remarks />
    [XmlElement("artist")]
    public RecordingArtist Artist { get; set; }

    /// <remarks />
    [XmlAttribute("joinphrase")]
    public string Joinphrase { get; set; }
  }

  /// <remarks />
  public class RecordingArtist
  {
    /// <remarks />
    public RecordingArtist()
    {
      Name = string.Empty;
      Sortname = string.Empty;
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
    [XmlArray("alias-list"), XmlArrayItem("alias", IsNullable = false)]
    public List<Alias> Aliaslist { get; set; }

    /// <remarks />
    [XmlAttribute("id")]
    public string Id { get; set; }
  }

  /// <remarks />
  public class RecordingRelease
  {
    /// <remarks />
    public RecordingRelease()
    {
      Title = string.Empty;
      Status = string.Empty;
      Artistcredit = new List<RecordingNamecredit>();
      Releasegroup = new RecordingReleasegroup();
      Date = string.Empty;
      Country = string.Empty;
      Releaseeventlist = new RecordingReleaseeventlist();
      Mediumlist = new RecordingMediumlist();
      Id = string.Empty;
    }

    /// <remarks />
    [XmlElement("title")]
    public string Title { get; set; }

    /// <remarks />
    [XmlElement("status")]
    public string Status { get; set; }

    /// <remarks />
    [XmlArray("artist-credit"), XmlArrayItem("name-credit", IsNullable = false)]
    public List<RecordingNamecredit> Artistcredit { get; set; }

    /// <remarks />
    [XmlElement("release-group")]
    public RecordingReleasegroup Releasegroup { get; set; }

    /// <remarks />
    [XmlElement("date")]
    public string Date { get; set; }

    /// <remarks />
    [XmlElement("country")]
    public string Country { get; set; }

    /// <remarks />
    [XmlElement("release-event-list")]
    public RecordingReleaseeventlist Releaseeventlist { get; set; }

    /// <remarks />
    [XmlElement("medium-list")]
    public RecordingMediumlist Mediumlist { get; set; }

    /// <remarks />
    [XmlAttribute("id")]
    public string Id { get; set; }
  }

  /// <remarks />
  public class RecordingReleasegroup
  {
    /// <remarks />
    public RecordingReleasegroup()
    {
      Primarytype = string.Empty;
      Secondarytypelist = new RecordingSecondarytypelist();
      Id = string.Empty;
      Type = string.Empty;
    }

    /// <remarks />
    [XmlElement("primary-type")]
    public string Primarytype { get; set; }

    /// <remarks />
    [XmlElement("secondary-type-list")]
    public RecordingSecondarytypelist Secondarytypelist { get; set; }

    /// <remarks />
    [XmlAttribute("id")]
    public string Id { get; set; }

    /// <remarks />
    [XmlAttribute("type")]
    public string Type { get; set; }
  }

  /// <remarks />
  public class RecordingSecondarytypelist
  {
    /// <remarks />
    public RecordingSecondarytypelist()
    {
      Secondarytype = string.Empty;
    }

    /// <remarks />
    [XmlElement("secondary-type")]
    public string Secondarytype { get; set; }
  }

  /// <remarks />
  public class RecordingReleaseeventlist
  {
    /// <remarks />
    public RecordingReleaseeventlist()
    {
      Releaseevent = new RecordingReleaseevent();
    }

    /// <remarks />
    [XmlElement("release-event")]
    public RecordingReleaseevent Releaseevent { get; set; }
  }

  /// <remarks />
  public class RecordingReleaseevent
  {
    /// <remarks />
    public RecordingReleaseevent()
    {
      Date = string.Empty;
      Area = new RecordingArea();
    }

    /// <remarks />
    [XmlElement("date")]
    public string Date { get; set; }

    /// <remarks />
    [XmlElement("area")]
    public RecordingArea Area { get; set; }
  }

  /// <remarks />
  public class RecordingArea
  {
    /// <remarks />
    public RecordingArea()
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
  public class RecordingMediumlist
  {
    /// <remarks />
    public RecordingMediumlist()
    {
      Trackcount = 0;
      Medium = new RecordingMedium();
    }

    /// <remarks />
    [XmlElement("track-count")]
    public int Trackcount { get; set; }

    /// <remarks />
    [XmlElement("medium")]
    public RecordingMedium Medium { get; set; }
  }

  /// <remarks />
  public class RecordingMedium
  {
    /// <remarks />
    public RecordingMedium()
    {
      Position = 0;
      Format = string.Empty;
      Tracklist = new RecordingTracklist();
    }

    /// <remarks />
    [XmlElement("position")]
    public int Position { get; set; }

    /// <remarks />
    [XmlElement("format")]
    public string Format { get; set; }

    /// <remarks />
    [XmlElement("track-list")]
    public RecordingTracklist Tracklist { get; set; }
  }

  /// <remarks />
  public class RecordingTracklist
  {
    /// <remarks />
    public RecordingTracklist()
    {
      Track = new RecordingTrack();
      Count = 0;
      Offset = 0;
    }

    /// <remarks />
    [XmlElement("track")]
    public RecordingTrack Track { get; set; }

    /// <remarks />
    [XmlAttribute("count")]
    public int Count { get; set; }

    /// <remarks />
    [XmlAttribute("offset")]
    public int Offset { get; set; }
  }

  /// <remarks />
  public class RecordingTrack
  {
    /// <remarks />
    public RecordingTrack()
    {
      Number = string.Empty;
      Title = string.Empty;
      Length = 0;
      Id = string.Empty;
    }

    /// <remarks />
    [XmlElement("number")]
    public string Number { get; set; }

    /// <remarks />
    [XmlElement("title")]
    public string Title { get; set; }

    /// <remarks />
    [XmlElement("length")]
    public int Length { get; set; }

    /// <remarks />
    [XmlAttribute("id")]
    public string Id { get; set; }
  }

  /// <remarks />
  public class RecordingIsrclist
  {
    /// <remarks />
    public RecordingIsrclist()
    {
      Isrc = new RecordingIsrc();
    }

    /// <remarks />
    [XmlElement("isrc")]
    public RecordingIsrc Isrc { get; set; }
  }

  /// <remarks />
  public class RecordingIsrc
  {
    /// <remarks />
    public RecordingIsrc()
    {
      Id = string.Empty;
    }

    /// <remarks />
    [XmlAttribute("id")]
    public string Id { get; set; }
  }
}