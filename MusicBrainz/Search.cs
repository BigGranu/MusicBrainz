using System.Reflection;
using MusicBrainz.Data;

namespace MusicBrainz
{
  /// <summary>
  /// 
  /// </summary>
  public class Search
  {
    /// <summary>
    /// Annotation
    /// </summary>
    /// <param name="query">The Searchstring</param>
    /// <param name="text">The content of the annotation</param>
    /// <param name="type">The entity type (artist, releasegroup, release, recording, work, label)</param>
    /// <param name="name">The name of the entity</param>
    /// <param name="entity">The entity's MBID</param>
    /// <param name="limit">An integer value defining how many entries should be returned. <br/>
    /// Only values between 1 and 100 (both inclusive) are allowed. <br/>
    /// If not given, this defaults to 25.</param>
    /// <param name="offset">Return search results starting at a given offset. <br/>
    /// Used for paging through more than one page of results.</param>
    /// <returns>List of Annotation</returns>
    public static Annotation Annotation(string query = null, string text = null, string type = null, string name = null, string entity = null, int limit = 25, int offset = 0)
    {
      var search = Help.SearchToString(MethodBase.GetCurrentMethod(), query, text, type, name, entity);
      return Help.Find<Annotation>(search, limit, offset, "annotation");
    }

    /// <summary>
    ///   Area
    /// </summary>
    /// <param name="query">The Searchstring</param>
    /// <param name="aid">the area ID</param>
    /// <param name="alias">the aliases/misspellings for this area</param>
    /// <param name="area">area name</param>
    /// <param name="begin">area begin date</param>
    /// <param name="comment">disambugation comment</param>
    /// <param name="end">area end date</param>
    /// <param name="ended">area ended</param>
    /// <param name="sortname">area sort name</param>
    /// <param name="iso">area iso1, iso2 or iso3 codes</param>
    /// <param name="iso1">area iso1 codes</param>
    /// <param name="iso2">area iso3 codes</param>
    /// <param name="iso3">area iso3 codes</param>
    /// <param name="type">the aliases/misspellings for this label</param>
    /// <param name="limit">
    ///   An integer value defining how many entries should be returned. <br />
    ///   Only values between 1 and 100 (both inclusive) are allowed. <br />
    ///   If not given, this defaults to 25.
    /// </param>
    /// <param name="offset">
    ///   Return search results starting at a given offset. <br />
    ///   Used for paging through more than one page of results.
    /// </param>
    /// <returns>List of Area</returns>
    public static Area Area(string query = null, string aid = null, string alias = null, string area = null, string begin = null,
      string comment = null, string end = null, string ended = null, string sortname = null, string iso = null,
      string iso1 = null, string iso2 = null, string iso3 = null, string type = null, int limit = 25, int offset = 0)
    {
      var search = Help.SearchToString(MethodBase.GetCurrentMethod(), query, aid, alias, area, begin, comment, end, ended, sortname, iso, iso1, iso2, iso3, type);
      return Help.Find<Area>(search, limit, offset, "area");
    }

    /// <summary>
    ///   Artist
    /// </summary>
    /// <param name="query">The Searchstring</param>
    /// <param name="area">artist area</param>
    /// <param name="beginarea">artist begin area</param>
    /// <param name="endarea">artist end area</param>
    /// <param name="arid">MBID of the artist</param>
    /// <param name="artist">name of the artist</param>
    /// <param name="artistaccent">name of the artist with any accent characters retained</param>
    /// <param name="alias">the aliases/misspellings for the artist</param>
    /// <param name="begin">artist birth date/band founding date</param>
    /// <param name="comment">artist comment to differentiate similar artists</param>
    /// <param name="country">the two letter country code for the artist country or 'unknown'</param>
    /// <param name="end">artist death date/band dissolution date</param>
    /// <param name="ended">true if know ended even if do not know end date</param>
    /// <param name="gender">gender of the artist (“male”, “female”, “other”)</param>
    /// <param name="ipi">IPI code for the artist</param>
    /// <param name="sortname">artist sortname</param>
    /// <param name="tag">a tag applied to the artist</param>
    /// <param name="type">artist type (“person”, “group”, "other" or “unknown”)</param>
    /// <param name="limit">
    ///   An integer value defining how many entries should be returned. <br />
    ///   Only values between 1 and 100 (both inclusive) are allowed. <br />
    ///   If not given, this defaults to 25.
    /// </param>
    /// <param name="offset">
    ///   Return search results starting at a given offset. <br />
    ///   Used for paging through more than one page of results.
    /// </param>
    /// <returns>List of Artist</returns>
    public static Artist Artist(string query = null, string area = null, string beginarea = null, string endarea = null,
      string arid = null, string artist = null, string artistaccent = null, string alias = null, string begin = null,
      string comment = null, string country = null, string end = null, string ended = null, string gender = null,
      string ipi = null, string sortname = null, string tag = null, string type = null, int limit = 25, int offset = 0)
    {
      var search = Help.SearchToString(MethodBase.GetCurrentMethod(), query, area, beginarea, endarea, arid, artist, artistaccent, alias, begin, comment, country, end, ended, gender, ipi, sortname, tag, type);
      return Help.Find<Artist>(search, limit, offset, "artist");
    }

    /// <summary>
    ///   CDStub
    /// </summary>
    /// <param name="query">The Searchstring</param>
    /// <param name="artist">artist name</param>
    /// <param name="title">release name</param>
    /// <param name="barcode">release barcode</param>
    /// <param name="comment">general comments about the release</param>
    /// <param name="tracks">number of tracks on the CD stub</param>
    /// <param name="discid">disc ID of the CD</param>
    /// <param name="limit">
    ///   An integer value defining how many entries should be returned. <br />
    ///   Only values between 1 and 100 (both inclusive) are allowed. <br />
    ///   If not given, this defaults to 25.
    /// </param>
    /// <param name="offset">
    ///   Return search results starting at a given offset. <br />
    ///   Used for paging through more than one page of results.
    /// </param>
    /// <returns>List of CDStub</returns>
    public static Cdstub CdStub(string query = null, string artist = null, string title = null, string barcode = null,
      string comment = null, string tracks = null, string discid = null, int limit = 25, int offset = 0)
    {
      var search = Help.SearchToString(MethodBase.GetCurrentMethod(), query, artist, title, barcode, comment, tracks, discid);
      return Help.Find<Cdstub>(search, limit, offset, "cdstub");
    }

    /// <summary>
    ///   Freedb
    /// </summary>
    /// <param name="query">The Searchstring</param>
    /// <param name="artist">artist name</param>
    /// <param name="title">release name</param>
    /// <param name="discid">FreeDB disc id</param>
    /// <param name="cat">FreeDB category</param>
    /// <param name="year">year</param>
    /// <param name="tracks">number of tracks in the release</param>
    /// <param name="limit">
    ///   An integer value defining how many entries should be returned. <br />
    ///   Only values between 1 and 100 (both inclusive) are allowed. <br />
    ///   If not given, this defaults to 25.
    /// </param>
    /// <param name="offset">
    ///   Return search results starting at a given offset. <br />
    ///   Used for paging through more than one page of results.
    /// </param>
    /// <returns>List of Freedb</returns>
    public static Freedb Freedb(string query = null, string artist = null, string title = null, string discid = null, string cat = null,
      string year = null, string tracks = null, int limit = 25, int offset = 0)
    {
      var search = Help.SearchToString(MethodBase.GetCurrentMethod(), query, artist, title, discid, cat, year, tracks);
      return Help.Find<Freedb>(search, limit, offset, "freedb");
    }

    /// <summary>
    ///   Label
    /// </summary>
    /// <param name="query">The Searchstring</param>
    /// <param name="alias">the aliases/misspellings for this label</param>
    /// <param name="area">label area</param>
    /// <param name="begin">label founding date</param>
    /// <param name="code">label code (only the figures part, i.e. without "LC")</param>
    /// <param name="comment">label comment to differentiate similar labels</param>
    /// <param name="country">The two letter country code of the label country</param>
    /// <param name="end">label dissolution date</param>
    /// <param name="ended">true if know ended even if do not know end date</param>
    /// <param name="ipi">ipi</param>
    /// <param name="label">label name</param>
    /// <param name="labelaccent">name of the label with any accent characters retained</param>
    /// <param name="laid">MBID of the label</param>
    /// <param name="sortname">label sortname</param>
    /// <param name="type">label type</param>
    /// <param name="tag">folksonomy tag</param>
    /// <param name="limit">
    ///   An integer value defining how many entries should be returned. <br />
    ///   Only values between 1 and 100 (both inclusive) are allowed. <br />
    ///   If not given, this defaults to 25.
    /// </param>
    /// <param name="offset">
    ///   Return search results starting at a given offset. <br />
    ///   Used for paging through more than one page of results.
    /// </param>
    /// <returns>List of Label</returns>
    public static Label Label(string query = null, string alias = null, string area = null, string begin = null, string code = null,
      string comment = null, string country = null, string end = null, string ended = null, string ipi = null,
      string label = null, string labelaccent = null, string laid = null, string sortname = null, string type = null,
      string tag = null, int limit = 25, int offset = 0)
    {
      var search = Help.SearchToString(MethodBase.GetCurrentMethod(), query, alias, area, begin, code, comment, country, end, ended, ipi, label, labelaccent, laid, sortname, type, tag);
      return Help.Find<Label>(search, limit, offset, "label");
    }

    /// <summary>
    ///   Place
    /// </summary>
    /// <param name="query">The Searchstring</param>
    /// <param name="pid">the place ID</param>
    /// <param name="address">the address of this place</param>
    /// <param name="alias">the aliases/misspellings for this area</param>
    /// <param name="area">area name</param>
    /// <param name="begin">place begin date</param>
    /// <param name="comment">disambiguation comment</param>
    /// <param name="end">place end date</param>
    /// <param name="ended">place ended</param>
    /// <param name="lat">place latitude</param>
    /// <param name="Long">place longitude</param>
    /// <param name="sortname">place sort name</param>
    /// <param name="type">the aliases/misspellings for this place</param>
    /// <param name="limit">
    ///   An integer value defining how many entries should be returned. <br />
    ///   Only values between 1 and 100 (both inclusive) are allowed. <br />
    ///   If not given, this defaults to 25.
    /// </param>
    /// <param name="offset">
    ///   Return search results starting at a given offset. <br />
    ///   Used for paging through more than one page of results.
    /// </param>
    /// <returns>List of Place</returns>
    public static Place Place(string query = null, string pid = null, string address = null, string alias = null, string area = null,
      string begin = null, string comment = null, string end = null, string ended = null, string lat = null,
      string Long = null, string sortname = null, string type = null, int limit = 25, int offset = 0)
    {
      var search = Help.SearchToString(MethodBase.GetCurrentMethod(), query, pid, address, alias, area, begin, comment, end, ended, lat, Long, sortname, type);
      return Help.Find<Place>(search, limit, offset, "place");
    }

    /// <summary>
    ///   Recording
    /// </summary>
    /// <param name="query">The Searchstring</param>
    /// <param name="arid">artist id</param>
    /// <param name="artist">artist name is name(s) as it appears on the recording</param>
    /// <param name="artistname">an artist on the recording, each artist added as a separate field</param>
    /// <param name="creditname">name credit on the recording, each artist added as a separate field</param>
    /// <param name="comment">recording disambiguation comment</param>
    /// <param name="country">recording release country</param>
    /// <param name="date">recording release date</param>
    /// <param name="dur">duration of track in milliseconds</param>
    /// <param name="format">recording release format</param>
    /// <param name="isrc">ISRC of recording</param>
    /// <param name="number">free text track number</param>
    /// <param name="position">the medium that the recording should be found on, first medium is position 1</param>
    /// <param name="primarytype">primary type of the release group (album, single, ep, other)</param>
    /// <param name="puid">PUID of recording</param>
    /// <param name="qdur">quantized duration (duration / 2000)</param>
    /// <param name="recording">name of recording or a track associated with the recording</param>
    /// <param name="recordingaccent">name of the recording with any accent characters retained</param>
    /// <param name="reid">release id</param>
    /// <param name="release">release name</param>
    /// <param name="rgid">release group id</param>
    /// <param name="rid">recording id</param>
    /// <param name="secondarytype">
    ///   secondary type of the release group (audiobook, compilation, interview, live, remix
    ///   soundtrack, spokenword)
    /// </param>
    /// <param name="status">Release status (official, promotion, Bootleg, Pseudo-Release)</param>
    /// <param name="tid">track id</param>
    /// <param name="tnum">track number on medium</param>
    /// <param name="tracks">number of tracks in the medium on release</param>
    /// <param name="tracksrelease">number of tracks on release as a whole</param>
    /// <param name="tag">folksonomy tag</param>
    /// <param name="type">
    ///   type of the release group, old type mapping for when we did not have separate primary and secondary
    ///   types or use standalone for standalone recordings
    /// </param>
    /// <param name="video">true to only show video tracks</param>
    /// <param name="limit">
    ///   An integer value defining how many entries should be returned. <br />
    ///   Only values between 1 and 100 (both inclusive) are allowed. <br />
    ///   If not given, this defaults to 25.
    /// </param>
    /// <param name="offset">
    ///   Return search results starting at a given offset. <br />
    ///   Used for paging through more than one page of results.
    /// </param>
    /// <returns>List of Recording</returns>
    public static Recording Recording(string query = null, string arid = null, string artist = null, string artistname = null,
      string creditname = null, string comment = null, string country = null, string date = null, string dur = null,
      string format = null, string isrc = null, string number = null, string position = null, string primarytype = null,
      string puid = null, string qdur = null, string recording = null, string recordingaccent = null, string reid = null,
      string release = null, string rgid = null, string rid = null, string secondarytype = null, string status = null,
      string tid = null, string tnum = null, string tracks = null, string tracksrelease = null, string tag = null,
      string type = null, string video = null, int limit = 25, int offset = 0)
    {
      var search = Help.SearchToString(MethodBase.GetCurrentMethod(), query, arid, artist, artistname, creditname, comment,
        country, date, dur, format, isrc, number, position, primarytype, puid, qdur, recording, recordingaccent, reid,
        release, rgid, rid, secondarytype, status, tid, tnum, tracks, tracksrelease, tag, type, video);
      return Help.Find<Recording>(search, limit, offset, "recording");
    }

    /// <summary>
    ///   Release
    /// </summary>
    /// <param name="query">The Searchstring</param>
    /// <param name="field">Description</param>
    /// <param name="arid">artist id</param>
    /// <param name="artist">complete artist name(s) as it appears on the release</param>
    /// <param name="artistname">an artist on the release, each artist added as a separate field</param>
    /// <param name="asin">the Amazon ASIN for this release</param>
    /// <param name="barcode">The barcode of this release</param>
    /// <param name="catno">The catalog number for this release, can have multiples when major using an imprint</param>
    /// <param name="comment">Disambiguation comment</param>
    /// <param name="country">The two letter country code for the release country</param>
    /// <param name="creditname">name credit on the release, each artist added as a separate field</param>
    /// <param name="date">The release date (format: YYYY-MM-DD)</param>
    /// <param name="discids">total number of cd ids over all mediums for the release</param>
    /// <param name="discidsmedium">number of cd ids for the release on a medium in the release</param>
    /// <param name="format">release format</param>
    /// <param name="laid">The label id for this release, a release can have multiples when major using an imprint</param>
    /// <param name="label">The name of the label for this release, can have multiples when major using an imprint</param>
    /// <param name="lang">
    ///   The language for this release. Use the three character ISO 639 codes to search for a specific
    ///   language. (e.g. lang:eng)
    /// </param>
    /// <param name="mediums">number of mediums in the release</param>
    /// <param name="primarytype">primary type of the release group (album, single, ep, other)</param>
    /// <param name="puid">The release contains recordings with these puids</param>
    /// <param name="quality">The quality of the release (low, normal, high)</param>
    /// <param name="reid">release id</param>
    /// <param name="release">release name</param>
    /// <param name="releaseaccent">name of the release with any accent characters retained</param>
    /// <param name="rgid">release group id</param>
    /// <param name="script">The 4 character script code (e.g. latn) used for this release</param>
    /// <param name="secondarytype">
    ///   secondary type of the release group (audiobook, compilation, interview, live, remix,
    ///   soundtrack, spokenword)
    /// </param>
    /// <param name="status">release status (e.g official)</param>
    /// <param name="tag">a tag that appears on the release</param>
    /// <param name="tracks">total number of tracks over all mediums on the release</param>
    /// <param name="tracksmedium">number of tracks on a medium in the release</param>
    /// <param name="type">
    ///   type of the release group, old type mapping for when we did not have separate primary and secondary
    ///   types
    /// </param>
    /// <param name="limit">
    ///   An integer value defining how many entries should be returned. <br />
    ///   Only values between 1 and 100 (both inclusive) are allowed. <br />
    ///   If not given, this defaults to 25.
    /// </param>
    /// <param name="offset">
    ///   Return search results starting at a given offset. <br />
    ///   Used for paging through more than one page of results.
    /// </param>
    /// <returns>List of Release</returns>
    public static Release Release(string query = null, string field = null, string arid = null, string artist = null,
      string artistname = null, string asin = null, string barcode = null, string catno = null, string comment = null,
      string country = null, string creditname = null, string date = null, string discids = null,
      string discidsmedium = null, string format = null, string laid = null, string label = null, string lang = null,
      string mediums = null, string primarytype = null, string puid = null, string quality = null, string reid = null,
      string release = null, string releaseaccent = null, string rgid = null, string script = null,
      string secondarytype = null, string status = null, string tag = null, string tracks = null,
      string tracksmedium = null, string type = null, int limit = 25, int offset = 0)
    {
      var search = Help.SearchToString(MethodBase.GetCurrentMethod(), query, field, arid, artist, artistname, asin, barcode,
        catno, comment, country, creditname, date, discids, discidsmedium, format, laid, label, lang, mediums,
        primarytype, puid, quality, reid, release, releaseaccent, rgid, script, secondarytype, status, tag, tracks,
        tracksmedium, type);
      return Help.Find<Release>(search, limit, offset, "release");
    }

    /// <summary>
    ///   ReleaseGroup
    /// </summary>
    /// <param name="query">The Searchstring</param>
    /// <param name="arid">MBID of the release group’s artist</param>
    /// <param name="artist">release group artist as it appears on the cover (Artist Credit)</param>
    /// <param name="artistname">“real name” of any artist that is included in the release group’s artist credit</param>
    /// <param name="comment">release group comment to differentiate similar release groups</param>
    /// <param name="creditname">name of any artist in multi-artist credits, as it appears on the cover.</param>
    /// <param name="primarytype">primary type of the release group (album, single, ep, other)</param>
    /// <param name="rgid">MBID of the release group</param>
    /// <param name="releasegroup">name of the release group</param>
    /// <param name="releasegroupaccent">name of the releasegroup with any accent characters retained</param>
    /// <param name="releases">number of releases in this release group</param>
    /// <param name="release">name of a release that appears in the release group</param>
    /// <param name="reid">MBID of a release that appears in the release group</param>
    /// <param name="secondarytype">
    ///   secondary type of the release group (audiobook, compilation, interview, live, remix
    ///   soundtrack, spokenword)
    /// </param>
    /// <param name="status">status of a release that appears within the release group</param>
    /// <param name="tag">a tag that appears on the release group</param>
    /// <param name="type">
    ///   type of the release group, old type mapping for when we did not have separate primary and secondary
    ///   types
    /// </param>
    /// <param name="limit">
    ///   An integer value defining how many entries should be returned. <br />
    ///   Only values between 1 and 100 (both inclusive) are allowed. <br />
    ///   If not given, this defaults to 25.
    /// </param>
    /// <param name="offset">
    ///   Return search results starting at a given offset. <br />
    ///   Used for paging through more than one page of results.
    /// </param>
    /// <returns>List of ReleaseGroup</returns>
    public static Releasegroup ReleaseGroup(string query = null, string arid = null, string artist = null, string artistname = null,
      string comment = null, string creditname = null, string primarytype = null, string rgid = null,
      string releasegroup = null, string releasegroupaccent = null, string releases = null, string release = null,
      string reid = null, string secondarytype = null, string status = null, string tag = null, string type = null,
      int limit = 25, int offset = 0)
    {
      var search = Help.SearchToString(MethodBase.GetCurrentMethod(), query, arid, artist, artistname, comment, creditname,
        primarytype, rgid, releasegroup, releasegroupaccent, releases, release, reid, secondarytype, status, tag, type);
      return Help.Find<Releasegroup>(search, limit, offset, "release-group");
    }

    /// <summary>
    ///   Tag
    /// </summary>
    /// <param name="query">The Searchstring</param>
    /// ///
    /// <param name="limit">
    ///   An integer value defining how many entries should be returned. <br />
    ///   Only values between 1 and 100 (both inclusive) are allowed. <br />
    ///   If not given, this defaults to 25.
    /// </param>
    /// <param name="offset">
    ///   Return search results starting at a given offset. <br />
    ///   Used for paging through more than one page of results.
    /// </param>
    /// <returns>List of Tag</returns>
    public static Tag Tag(string query, int limit = 25, int offset = 0)
    {
      return Help.Find<Tag>(query, limit, offset, "tag");
    }

    /// <summary>
    ///   Work
    /// </summary>
    /// <param name="query">The Searchstring</param>
    /// <param name="alias">the aliases/misspellings for this work</param>
    /// <param name="arid">artist id</param>
    /// <param name="artist">
    ///   artist name, an artist in the context of a work is an artist-work relation such as composer or
    ///   performer
    /// </param>
    /// <param name="comment">disambiguation comment</param>
    /// <param name="iswc">ISWC of work</param>
    /// <param name="lang">Lyrics language of work</param>
    /// <param name="tag">folksonomy tag</param>
    /// <param name="type">work type</param>
    /// <param name="wid">work id</param>
    /// <param name="work">name of work</param>
    /// <param name="workaccent">name of the work with any accent characters retained</param>
    /// <param name="limit">
    ///   An integer value defining how many entries should be returned. <br />
    ///   Only values between 1 and 100 (both inclusive) are allowed. <br />
    ///   If not given, this defaults to 25.
    /// </param>
    /// <param name="offset">
    ///   Return search results starting at a given offset. <br />
    ///   Used for paging through more than one page of results.
    /// </param>
    /// <returns>List of Work</returns>
    public static Work Work(string query = null, string alias = null, string arid = null, string artist = null, string comment = null,
      string iswc = null, string lang = null, string tag = null, string type = null, string wid = null,
      string work = null, string workaccent = null, int limit = 25, int offset = 0)
    {
      var search = Help.SearchToString(MethodBase.GetCurrentMethod(), query, alias, arid, artist, comment, iswc, lang, tag, type, wid, work, workaccent);
      return Help.Find<Work>(search, limit, offset, "work");
    }
  }
}
