#region Copyright (C) 2015-2018 BigGranu

/*
    Copyright (C) 2015-2018 BigGranu

    This file is part of mInfo <https://github.com/BigGranu/MusicApiCollection>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using MusicBrainz.Events;
using MusicBrainz.Metadata;

namespace MusicBrainz
{
    /// <summary>
    ///     Search on MusicBrainz
    /// </summary>
    public class Search
    {
        private static readonly Logging Logging = Logging.Instance;
        private static readonly Exceptions Exceptions = Exceptions.Instance;
        private static readonly string ns = "MusicBrainz";
        private static readonly string cl = "Search";

        #region Undocumented Search
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public static Metadata.Metadata Query(string entity, string search)
        {
            var ret = new Metadata.Metadata();
            var le = new LoggingArgs(ns, cl, "Query");
            le.Parameters.Add(new Para("entity", entity));
            le.Parameters.Add(new Para("search", search));
            Logging.NewLogEntry(le);

            var tmp = Http.Request("https://musicbrainz.org/ws/2/" + entity + "/" + search);
            if (tmp != "")
            {
                var meta = Xml.Deserialize<Metadata.Metadata>(tmp);
                if (meta != null)
                {
                    ret = meta;
                }
            }
  
            ret.ApiStatus = new ApiStatus(ns, cl, "Query");
            return ret;
        }

        /// <summary>
        ///     <a href="https://musicbrainz.org/doc/Area" target="_blank">Area</a> <br />
        ///     Areas are geographic regions or settlements. Areas are usually kept in sync with their Wikidata entries.
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
        ///     An integer value defining how many entries should be returned. <br />
        ///     Only values between 1 and 100 (both inclusive) are allowed. <br />
        ///     If not given, this defaults to 25.
        /// </param>
        /// <param name="offset">
        ///     Return search results starting at a given offset. <br />
        ///     Used for paging through more than one page of results.
        /// </param>
        /// <returns>List of Area</returns>
        public static Arealist Area(string query = null, string aid = null, string alias = null, string area = null,
            string begin = null,
            string comment = null, string end = null, string ended = null, string sortname = null, string iso = null,
            string iso1 = null, string iso2 = null, string iso3 = null, string type = null, int limit = 25,
            int offset = 0)
        {
            var ret = new Arealist();

            var le = new LoggingArgs(ns, cl, "Area");
            le.Parameters.Add(new Para("query", query));
            le.Parameters.Add(new Para("aid", aid));
            le.Parameters.Add(new Para("alias", alias));
            le.Parameters.Add(new Para("area", area));
            le.Parameters.Add(new Para("begin", begin));
            le.Parameters.Add(new Para("comment", comment));
            le.Parameters.Add(new Para("end", end));
            le.Parameters.Add(new Para("ended", ended));
            le.Parameters.Add(new Para("sortname", sortname));
            le.Parameters.Add(new Para("iso", iso));
            le.Parameters.Add(new Para("iso1", iso1));
            le.Parameters.Add(new Para("iso2", iso2));
            le.Parameters.Add(new Para("iso3", iso3));
            le.Parameters.Add(new Para("type", type));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Find<Metadata.Metadata>(Help.SearchToString(le.Parameters), limit, offset, "area");
                ret = tmp.Arealist ?? new Arealist();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            ret.ApiStatus = new ApiStatus(ns, cl, "Area");
            Logging.NewStatus(ret.ApiStatus);
            return ret;
        }

        /// <summary>
        ///     <a href="https://musicbrainz.org/doc/Place" target="_blank">Place</a> <br />
        ///     A place is a building or outdoor area used for performing or producing music.<br />
        ///     Examples:<br />
        ///     Royal Albert Hall<br />
        ///     Wembley Arena<br />
        ///     Abbey Road Studios
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
        ///     An integer value defining how many entries should be returned. <br />
        ///     Only values between 1 and 100 (both inclusive) are allowed. <br />
        ///     If not given, this defaults to 25.
        /// </param>
        /// <param name="offset">
        ///     Return search results starting at a given offset. <br />
        ///     Used for paging through more than one page of results.
        /// </param>
        /// <returns>List of Place</returns>
        public static Placelist Place(string query = null, string pid = null, string address = null, string alias = null,
            string area = null,
            string begin = null, string comment = null, string end = null, string ended = null, string lat = null,
            string Long = null, string sortname = null, string type = null, int limit = 25, int offset = 0)
        {
            var ret = new Placelist();

            var le = new LoggingArgs(ns, cl, "Place");
            le.Parameters.Add(new Para("query", query));
            le.Parameters.Add(new Para("pid", pid));
            le.Parameters.Add(new Para("address", address));
            le.Parameters.Add(new Para("alias", alias));
            le.Parameters.Add(new Para("area", area));
            le.Parameters.Add(new Para("begin", begin));
            le.Parameters.Add(new Para("comment", comment));
            le.Parameters.Add(new Para("end", end));
            le.Parameters.Add(new Para("ended", ended));
            le.Parameters.Add(new Para("lat", lat));
            le.Parameters.Add(new Para("Long", Long));
            le.Parameters.Add(new Para("sortname", sortname));
            le.Parameters.Add(new Para("type", type));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Find<Metadata.Metadata>(Help.SearchToString(le.Parameters), limit, offset, "place");
                ret = tmp.Placelist ?? new Placelist();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            ret.ApiStatus = new ApiStatus(ns, cl, "Place");
            Logging.NewStatus(ret.ApiStatus);
            return ret;
        }

        #endregion

        #region Documented Search

        /// <summary>
        ///     <a href="https://musicbrainz.org/doc/Annotation" target="_blank">Annotation</a> <br />
        ///     Annotations are text fields, functioning like a miniature wiki, <br />
        ///     that can be added to any existing artists, labels, recordings, releases, release groups and works.
        /// </summary>
        /// <param name="query">The Searchstring</param>
        /// <param name="text">The content of the annotation</param>
        /// <param name="type">The entity type (artist, releasegroup, Release, recording, work, label)</param>
        /// <param name="name">The name of the entity</param>
        /// <param name="entity">The entity's MBID</param>
        /// <param name="limit">
        ///     An integer value defining how many entries should be returned. <br />
        ///     Only values between 1 and 100 (both inclusive) are allowed. <br />
        ///     If not given, this defaults to 25.
        /// </param>
        /// <param name="offset">
        ///     Return search results starting at a given offset. <br />
        ///     Used for paging through more than one page of results.
        /// </param>
        /// <returns>List of Annotation</returns>
        public static Annotationlist Annotation(string query = null, string text = null, string type = null,
            string name = null, string entity = null, int limit = 25, int offset = 0)
        {
            var ret = new Annotationlist();

            var le = new LoggingArgs(ns, cl, "Annotation");
            le.Parameters.Add(new Para("query", query));
            le.Parameters.Add(new Para("Text", text));
            le.Parameters.Add(new Para("type", type));
            le.Parameters.Add(new Para("name", name));
            le.Parameters.Add(new Para("entity", entity));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Find<Metadata.Metadata>(Help.SearchToString(le.Parameters), limit, offset, "annotation");
                ret = tmp.Annotationlist ?? new Annotationlist();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            ret.ApiStatus = new ApiStatus(ns, cl, "Annotation");
            Logging.NewStatus(ret.ApiStatus);
            return ret;
        }

        /// <summary>
        ///     <a href="https://musicbrainz.org/doc/Artist" target="_blank">Artist</a> <br />
        ///     An artist is generally a musician (or musician persona), group of musicians, or other music professional (like a producer or engineer). <br />
        ///     Occasionally, it can also be a non-musical person (like a photographer, an illustrator, or a poet whose writings are set to music), or even a fictional character.
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
        ///     An integer value defining how many entries should be returned. <br />
        ///     Only values between 1 and 100 (both inclusive) are allowed. <br />
        ///     If not given, this defaults to 25.
        /// </param>
        /// <param name="offset">
        ///     Return search results starting at a given offset. <br />
        ///     Used for paging through more than one page of results.
        /// </param>
        /// <returns>List of Artist</returns>
        public static Artistlist Artist(string query = null, string area = null, string beginarea = null,
            string endarea = null,
            string arid = null, string artist = null, string artistaccent = null, string alias = null,
            string begin = null,
            string comment = null, string country = null, string end = null, string ended = null, string gender = null,
            string ipi = null, string sortname = null, string tag = null, string type = null, int limit = 25,
            int offset = 0)
        {
            var ret = new Artistlist();

            var le = new LoggingArgs(ns, cl, "Artist");
            le.Parameters.Add(new Para("query", query));
            le.Parameters.Add(new Para("area", area));
            le.Parameters.Add(new Para("beginarea", beginarea));
            le.Parameters.Add(new Para("endarea", endarea));
            le.Parameters.Add(new Para("arid", arid));
            le.Parameters.Add(new Para("artist", artist));
            le.Parameters.Add(new Para("artistaccent", artistaccent));
            le.Parameters.Add(new Para("alias", alias));
            le.Parameters.Add(new Para("begin", begin));
            le.Parameters.Add(new Para("comment", comment));
            le.Parameters.Add(new Para("country", country));
            le.Parameters.Add(new Para("end", end));
            le.Parameters.Add(new Para("ended", ended));
            le.Parameters.Add(new Para("gender", gender));
            le.Parameters.Add(new Para("ipi", ipi));
            le.Parameters.Add(new Para("sortname", sortname));
            le.Parameters.Add(new Para("tag", tag));
            le.Parameters.Add(new Para("type", type));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Find<Metadata.Metadata>(Help.SearchToString(le.Parameters), limit, offset, "artist");
                ret = tmp.Artistlist ?? new Artistlist();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            ret.ApiStatus = new ApiStatus(ns, cl, "Artist");
            Logging.NewStatus(ret.ApiStatus);
            return ret;
        }

        /// <summary>
        ///     <a href="https://musicbrainz.org/doc/CD_Stub" target="_blank">CDStub</a> <br />
        ///     A CD stub is an anonymously submitted track list that contains a disc ID, barcode, comment field, and basic metadata like a release title and track names.
        /// </summary>
        /// <param name="query">The Searchstring</param>
        /// <param name="artist">artist name</param>
        /// <param name="title">Release name</param>
        /// <param name="barcode">Release barcode</param>
        /// <param name="comment">general comments about the Release</param>
        /// <param name="tracks">number of tracks on the CD stub</param>
        /// <param name="discid">disc ID of the CD</param>
        /// <param name="limit">
        ///     An integer value defining how many entries should be returned. <br />
        ///     Only values between 1 and 100 (both inclusive) are allowed. <br />
        ///     If not given, this defaults to 25.
        /// </param>
        /// <param name="offset">
        ///     Return search results starting at a given offset. <br />
        ///     Used for paging through more than one page of results.
        /// </param>
        /// <returns>List of CDStub</returns>
        public static Cdstublist CdStub(string query = null, string artist = null, string title = null,
            string barcode = null,
            string comment = null, string tracks = null, string discid = null, int limit = 25, int offset = 0)
        {
            var ret = new Cdstublist();

            var le = new LoggingArgs(ns, cl, "CdStub");
            le.Parameters.Add(new Para("query", query));
            le.Parameters.Add(new Para("artist", artist));
            le.Parameters.Add(new Para("Title", title));
            le.Parameters.Add(new Para("barcode", barcode));
            le.Parameters.Add(new Para("comment", comment));
            le.Parameters.Add(new Para("tracks", tracks));
            le.Parameters.Add(new Para("discid", discid));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Find<Metadata.Metadata>(Help.SearchToString(le.Parameters), limit, offset, "cdstub");
                ret = tmp.Cdstublist ?? new Cdstublist();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            ret.ApiStatus = new ApiStatus(ns, cl, "CdStub");
            Logging.NewStatus(ret.ApiStatus);
            return ret;
        }

        /// <summary>
        ///     <a href="https://musicbrainz.org/doc/Search_Server#Freedb" target="_blank">Freedb</a>
        /// </summary>
        /// <param name="query">The Searchstring</param>
        /// <param name="artist">artist name</param>
        /// <param name="title">Release name</param>
        /// <param name="discid">FreeDb disc id</param>
        /// <param name="cat">FreeDb category</param>
        /// <param name="year">year</param>
        /// <param name="tracks">number of tracks in the Release</param>
        /// <param name="limit">
        ///     An integer value defining how many entries should be returned. <br />
        ///     Only values between 1 and 100 (both inclusive) are allowed. <br />
        ///     If not given, this defaults to 25.
        /// </param>
        /// <param name="offset">
        ///     Return search results starting at a given offset. <br />
        ///     Used for paging through more than one page of results.
        /// </param>
        /// <returns>List of Freedb</returns>
        public static Freedbdisclist Freedb(string query = null, string artist = null, string title = null, string discid = null,
            string cat = null,
            string year = null, string tracks = null, int limit = 25, int offset = 0)
        {
            var ret = new Freedbdisclist();

            var le = new LoggingArgs(ns, cl, "FreeDb");
            le.Parameters.Add(new Para("query", query));
            le.Parameters.Add(new Para("artist", artist));
            le.Parameters.Add(new Para("Title", title));
            le.Parameters.Add(new Para("discid", discid));
            le.Parameters.Add(new Para("cat", cat));
            le.Parameters.Add(new Para("year", year));
            le.Parameters.Add(new Para("tracks", tracks));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Find<Metadata.Metadata>(Help.SearchToString(le.Parameters), limit, offset, "freedb");
                ret = tmp.Freedbdisclist ?? new Freedbdisclist();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            ret.ApiStatus = new ApiStatus(ns, cl, "FreeDb");
            Logging.NewStatus(ret.ApiStatus);
            return ret;
        }

        /// <summary>
        ///     <a href="https://musicbrainz.org/doc/Label" target="_blank">Label</a> <br />
        ///     Labels are one of the most complicated and controversial parts of the music industry. <br />
        ///     The main reason for that being that the term itself is not clearly defined and refers to at least two overlapping concepts: <br />
        ///     imprints, and the companies that control them. <br />
        ///     Fortunately, in many cases the imprint and the company controlling it have the same name.
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
        ///     An integer value defining how many entries should be returned. <br />
        ///     Only values between 1 and 100 (both inclusive) are allowed. <br />
        ///     If not given, this defaults to 25.
        /// </param>
        /// <param name="offset">
        ///     Return search results starting at a given offset. <br />
        ///     Used for paging through more than one page of results.
        /// </param>
        /// <returns>List of Label</returns>
        public static Labellist Label(string query = null, string alias = null, string area = null, string begin = null,
            string code = null,
            string comment = null, string country = null, string end = null, string ended = null, string ipi = null,
            string label = null, string labelaccent = null, string laid = null, string sortname = null,
            string type = null,
            string tag = null, int limit = 25, int offset = 0)
        {
            var ret = new Labellist();

            var le = new LoggingArgs(ns, cl, "Label");
            le.Parameters.Add(new Para("query", query));
            le.Parameters.Add(new Para("alias", alias));
            le.Parameters.Add(new Para("area", area));
            le.Parameters.Add(new Para("begin", begin));
            le.Parameters.Add(new Para("code", code));
            le.Parameters.Add(new Para("comment", comment));
            le.Parameters.Add(new Para("country", country));
            le.Parameters.Add(new Para("end", end));
            le.Parameters.Add(new Para("ended", ended));
            le.Parameters.Add(new Para("ipi", ipi));
            le.Parameters.Add(new Para("label", label));
            le.Parameters.Add(new Para("labelaccent", labelaccent));
            le.Parameters.Add(new Para("laid", laid));
            le.Parameters.Add(new Para("sortname", sortname));
            le.Parameters.Add(new Para("type", type));
            le.Parameters.Add(new Para("tag", tag));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Find<Metadata.Metadata>(Help.SearchToString(le.Parameters), limit, offset, "label");
                ret = tmp.Labellist ?? new Labellist();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            ret.ApiStatus = new ApiStatus(ns, cl, "Label");
            Logging.NewStatus(ret.ApiStatus);
            return ret;
        }

        /// <summary>
        ///     <a href="https://musicbrainz.org/doc/Release_Group" target="_blank">Release Group</a> <br />
        ///     A release group, just as the name suggests, is used to group several different releases into a single logical entity. <br />
        ///     Every release belongs to one, and only one release group.
        /// </summary>
        /// <param name="query">The Searchstring</param>
        /// <param name="arid">MBID of the Release group’s artist</param>
        /// <param name="artist">Release group artist as it appears on the cover (Artist Credit)</param>
        /// <param name="artistname">“real name” of any artist that is included in the Release group’s artist credit</param>
        /// <param name="comment">Release group comment to differentiate similar Release groups</param>
        /// <param name="creditname">name of any artist in multi-artist credits, as it appears on the cover.</param>
        /// <param name="primarytype">primary type of the Release group (album, single, ep, other)</param>
        /// <param name="rgid">MBID of the Release group</param>
        /// <param name="releasegroup">name of the Release group</param>
        /// <param name="releasegroupaccent">name of the releasegroup with any accent characters retained</param>
        /// <param name="releases">number of releases in this Release group</param>
        /// <param name="release">name of a Release that appears in the Release group</param>
        /// <param name="reid">MBID of a Release that appears in the Release group</param>
        /// <param name="secondarytype">
        ///     secondary type of the Release group (audiobook, compilation, interview, live, remix
        ///     soundtrack, spokenword)
        /// </param>
        /// <param name="status">status of a Release that appears within the Release group</param>
        /// <param name="tag">a tag that appears on the Release group</param>
        /// <param name="type">
        ///     type of the Release group, old type mapping for when we did not have separate primary and secondary
        ///     types
        /// </param>
        /// <param name="limit">
        ///     An integer value defining how many entries should be returned. <br />
        ///     Only values between 1 and 100 (both inclusive) are allowed. <br />
        ///     If not given, this defaults to 25.
        /// </param>
        /// <param name="offset">
        ///     Return search results starting at a given offset. <br />
        ///     Used for paging through more than one page of results.
        /// </param>
        /// <returns>List of ReleaseGroup</returns>
        public static Releasegrouplist ReleaseGroup(string query = null, string arid = null, string artist = null,
            string artistname = null,
            string comment = null, string creditname = null, string primarytype = null, string rgid = null,
            string releasegroup = null, string releasegroupaccent = null, string releases = null, string release = null,
            string reid = null, string secondarytype = null, string status = null, string tag = null, string type = null,
            int limit = 25, int offset = 0)
        {
            var ret = new Releasegrouplist();

            var le = new LoggingArgs(ns, cl, "ReleaseGroup");
            le.Parameters.Add(new Para("query", query));
            le.Parameters.Add(new Para("arid", arid));
            le.Parameters.Add(new Para("artist", artist));
            le.Parameters.Add(new Para("artistname", artistname));
            le.Parameters.Add(new Para("comment", comment));
            le.Parameters.Add(new Para("creditname", creditname));
            le.Parameters.Add(new Para("primarytype", primarytype));
            le.Parameters.Add(new Para("rgid", rgid));
            le.Parameters.Add(new Para("releasegroup", releasegroup));
            le.Parameters.Add(new Para("releasegroupaccent", releasegroupaccent));
            le.Parameters.Add(new Para("releases", releases));
            le.Parameters.Add(new Para("Release", release));
            le.Parameters.Add(new Para("reid", reid));
            le.Parameters.Add(new Para("secondarytype", secondarytype));
            le.Parameters.Add(new Para("status", status));
            le.Parameters.Add(new Para("tag", tag));
            le.Parameters.Add(new Para("type", type));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Find<Metadata.Metadata>(Help.SearchToString(le.Parameters), limit, offset, "release-group");
                ret = tmp.Releasegrouplist ?? new Releasegrouplist();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            ret.ApiStatus = new ApiStatus(ns, cl, "ReleaseGroup");
            Logging.NewStatus(ret.ApiStatus);
            return ret;
        }

        /// <summary>
        ///     <a href="https://musicbrainz.org/doc/Release" target="_blank">Release</a> <br />
        ///     A MusicBrainz release represents the unique release (i.e. issuing) of a product on a specific date <br />
        ///     with specific release information such as the country, label, barcode and packaging. <br />
        ///     If you walk into a store and purchase an album or single, they are each represented in MusicBrainz as one release.<br />
        ///     Each release belongs to a release group and contains at least one medium(commonly referred to as a disc when talking about a CD release). <br />
        ///     Each medium has a tracklist.
        /// </summary>
        /// <param name="query">The Searchstring</param>
        /// <param name="field">Description</param>
        /// <param name="arid">artist id</param>
        /// <param name="artist">complete artist name(s) as it appears on the Release</param>
        /// <param name="artistname">an artist on the Release, each artist added as a separate field</param>
        /// <param name="asin">the Amazon ASIN for this Release</param>
        /// <param name="barcode">The barcode of this Release</param>
        /// <param name="catno">The catalog number for this Release, can have multiples when major using an imprint</param>
        /// <param name="comment">Disambiguation comment</param>
        /// <param name="country">The two letter country code for the Release country</param>
        /// <param name="creditname">name credit on the Release, each artist added as a separate field</param>
        /// <param name="date">The Release date (format: YYYY-MM-DD)</param>
        /// <param name="discids">total number of cd ids over all mediums for the Release</param>
        /// <param name="discidsmedium">number of cd ids for the Release on a medium in the Release</param>
        /// <param name="format">Release format</param>
        /// <param name="laid">The label id for this Release, a Release can have multiples when major using an imprint</param>
        /// <param name="label">The name of the label for this Release, can have multiples when major using an imprint</param>
        /// <param name="lang">
        ///     The language for this Release. Use the three character ISO 639 codes to search for a specific
        ///     language. (e.g. lang:eng)
        /// </param>
        /// <param name="mediums">number of mediums in the Release</param>
        /// <param name="primarytype">primary type of the Release group (album, single, ep, other)</param>
        /// <param name="puid">The Release contains recordings with these puids</param>
        /// <param name="quality">The Quality of the Release (low, normal, high)</param>
        /// <param name="reid">Release id</param>
        /// <param name="release">Release name</param>
        /// <param name="releaseaccent">name of the Release with any accent characters retained</param>
        /// <param name="rgid">Release group id</param>
        /// <param name="script">The 4 character script code (e.g. latn) used for this Release</param>
        /// <param name="secondarytype">
        ///     secondary type of the Release group (audiobook, compilation, interview, live, remix,
        ///     soundtrack, spokenword)
        /// </param>
        /// <param name="status">Release status (e.g official)</param>
        /// <param name="tag">a tag that appears on the Release</param>
        /// <param name="tracks">total number of tracks over all mediums on the Release</param>
        /// <param name="tracksmedium">number of tracks on a medium in the Release</param>
        /// <param name="type">
        ///     type of the Release group, old type mapping for when we did not have separate primary and secondary
        ///     types
        /// </param>
        /// <param name="limit">
        ///     An integer value defining how many entries should be returned. <br />
        ///     Only values between 1 and 100 (both inclusive) are allowed. <br />
        ///     If not given, this defaults to 25.
        /// </param>
        /// <param name="offset">
        ///     Return search results starting at a given offset. <br />
        ///     Used for paging through more than one page of results.
        /// </param>
        /// <returns>List of Release</returns>
        public static Releaselist Release(string query = null, string field = null, string arid = null, string artist = null,
            string artistname = null, string asin = null, string barcode = null, string catno = null,
            string comment = null,
            string country = null, string creditname = null, string date = null, string discids = null,
            string discidsmedium = null, string format = null, string laid = null, string label = null,
            string lang = null,
            string mediums = null, string primarytype = null, string puid = null, string quality = null,
            string reid = null,
            string release = null, string releaseaccent = null, string rgid = null, string script = null,
            string secondarytype = null, string status = null, string tag = null, string tracks = null,
            string tracksmedium = null, string type = null, int limit = 25, int offset = 0)
        {
            var ret = new Releaselist();

            var le = new LoggingArgs(ns, cl, "Release");
            le.Parameters.Add(new Para("query", query));
            le.Parameters.Add(new Para("field", field));
            le.Parameters.Add(new Para("arid", arid));
            le.Parameters.Add(new Para("artist", artist));
            le.Parameters.Add(new Para("artistname", artistname));
            le.Parameters.Add(new Para("asin", asin));
            le.Parameters.Add(new Para("barcode", barcode));
            le.Parameters.Add(new Para("catno", catno));
            le.Parameters.Add(new Para("comment", comment));
            le.Parameters.Add(new Para("country", country));
            le.Parameters.Add(new Para("creditname", creditname));
            le.Parameters.Add(new Para("date", date));
            le.Parameters.Add(new Para("discids", discids));
            le.Parameters.Add(new Para("discidsmedium", discidsmedium));
            le.Parameters.Add(new Para("format", format));
            le.Parameters.Add(new Para("laid", laid));
            le.Parameters.Add(new Para("label", label));
            le.Parameters.Add(new Para("lang", lang));
            le.Parameters.Add(new Para("mediums", mediums));
            le.Parameters.Add(new Para("primarytype", primarytype));
            le.Parameters.Add(new Para("puid", puid));
            le.Parameters.Add(new Para("Quality", quality));
            le.Parameters.Add(new Para("reid", reid));
            le.Parameters.Add(new Para("Release", release));
            le.Parameters.Add(new Para("releaseaccent", releaseaccent));
            le.Parameters.Add(new Para("rgid", rgid));
            le.Parameters.Add(new Para("script", script));
            le.Parameters.Add(new Para("secondarytype", secondarytype));
            le.Parameters.Add(new Para("status", status));
            le.Parameters.Add(new Para("tag", tag));
            le.Parameters.Add(new Para("tracks", tracks));
            le.Parameters.Add(new Para("tracksmedium", tracksmedium));
            le.Parameters.Add(new Para("type", type));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Find<Metadata.Metadata>(Help.SearchToString(le.Parameters), limit, offset, "release");
                ret = tmp.Releaselist ?? new Releaselist();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            ret.ApiStatus = new ApiStatus(ns, cl, "Release");
            Logging.NewStatus(ret.ApiStatus);
            return ret;
        }

        /// <summary>
        ///     <a href="https://musicbrainz.org/doc/Recording" target="_blank">Recording</a> <br />
        ///     A recording is an entity in MusicBrainz which can be linked to tracks on releases. <br />
        ///     Each track must always be associated with a single recording, but a recording can be linked to any number of tracks.
        /// </summary>
        /// <param name="query">The Searchstring</param>
        /// <param name="arid">artist id</param>
        /// <param name="artist">artist name is name(s) as it appears on the recording</param>
        /// <param name="artistname">an artist on the recording, each artist added as a separate field</param>
        /// <param name="creditname">name credit on the recording, each artist added as a separate field</param>
        /// <param name="comment">recording disambiguation comment</param>
        /// <param name="country">recording Release country</param>
        /// <param name="date">recording Release date</param>
        /// <param name="dur">Duration of track in milliseconds</param>
        /// <param name="format">recording Release format</param>
        /// <param name="isrc">ISRC of recording</param>
        /// <param name="number">free Text track number</param>
        /// <param name="position">the medium that the recording should be found on, first medium is position 1</param>
        /// <param name="primarytype">primary type of the Release group (album, single, ep, other)</param>
        /// <param name="puid">PUID of recording</param>
        /// <param name="qdur">quantized Duration (Duration / 2000)</param>
        /// <param name="recording">name of recording or a track associated with the recording</param>
        /// <param name="recordingaccent">name of the recording with any accent characters retained</param>
        /// <param name="reid">Release id</param>
        /// <param name="release">Release name</param>
        /// <param name="rgid">Release group id</param>
        /// <param name="rid">recording id</param>
        /// <param name="secondarytype">
        ///     secondary type of the Release group (audiobook, compilation, interview, live, remix
        ///     soundtrack, spokenword)
        /// </param>
        /// <param name="status">Release status (official, promotion, Bootleg, Pseudo-Release)</param>
        /// <param name="tid">track id</param>
        /// <param name="tnum">track number on medium</param>
        /// <param name="tracks">number of tracks in the medium on Release</param>
        /// <param name="tracksrelease">number of tracks on Release as a whole</param>
        /// <param name="tag">folksonomy tag</param>
        /// <param name="type">
        ///     type of the Release group, old type mapping for when we did not have separate primary and secondary
        ///     types or use standalone for standalone recordings
        /// </param>
        /// <param name="video">true to only show video tracks</param>
        /// <param name="limit">
        ///     An integer value defining how many entries should be returned. <br />
        ///     Only values between 1 and 100 (both inclusive) are allowed. <br />
        ///     If not given, this defaults to 25.
        /// </param>
        /// <param name="offset">
        ///     Return search results starting at a given offset. <br />
        ///     Used for paging through more than one page of results.
        /// </param>
        /// <returns>List of Recording</returns>
        public static Recordinglist Recording(string query = null, string arid = null, string artist = null,
            string artistname = null,
            string creditname = null, string comment = null, string country = null, string date = null,
            string dur = null,
            string format = null, string isrc = null, string number = null, string position = null,
            string primarytype = null,
            string puid = null, string qdur = null, string recording = null, string recordingaccent = null,
            string reid = null,
            string release = null, string rgid = null, string rid = null, string secondarytype = null,
            string status = null,
            string tid = null, string tnum = null, string tracks = null, string tracksrelease = null, string tag = null,
            string type = null, string video = null, int limit = 25, int offset = 0)
        {
            var ret = new Recordinglist();
            
            var le = new LoggingArgs(ns, cl, "Recording");
            le.Parameters.Add(new Para("query", query));
            le.Parameters.Add(new Para("arid", arid));
            le.Parameters.Add(new Para("artist", artist));
            le.Parameters.Add(new Para("artistname", artistname));
            le.Parameters.Add(new Para("creditname", creditname));
            le.Parameters.Add(new Para("comment", comment));
            le.Parameters.Add(new Para("country", country));
            le.Parameters.Add(new Para("date", date));
            le.Parameters.Add(new Para("dur", dur));
            le.Parameters.Add(new Para("format", format));
            le.Parameters.Add(new Para("isrc", isrc));
            le.Parameters.Add(new Para("number", number));
            le.Parameters.Add(new Para("position", position));
            le.Parameters.Add(new Para("primarytype", primarytype));
            le.Parameters.Add(new Para("puid", puid));
            le.Parameters.Add(new Para("qdur", qdur));
            le.Parameters.Add(new Para("recording", recording));
            le.Parameters.Add(new Para("recordingaccent", recordingaccent));
            le.Parameters.Add(new Para("reid", reid));
            le.Parameters.Add(new Para("Release", release));
            le.Parameters.Add(new Para("rgid", rgid));
            le.Parameters.Add(new Para("rid", rid));
            le.Parameters.Add(new Para("secondarytype", secondarytype));
            le.Parameters.Add(new Para("status", status));
            le.Parameters.Add(new Para("tid", tid));
            le.Parameters.Add(new Para("tnum", tnum));
            le.Parameters.Add(new Para("tracks", tracks));
            le.Parameters.Add(new Para("tracksrelease", tracksrelease));
            le.Parameters.Add(new Para("tag", tag));
            le.Parameters.Add(new Para("type", type));
            le.Parameters.Add(new Para("video", video));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Find<Metadata.Metadata>(Help.SearchToString(le.Parameters), limit, offset, "recording");
                ret = tmp.Recordinglist ?? new Recordinglist();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            ret.ApiStatus = new ApiStatus(ns, cl, "Recording");
            Logging.NewStatus(ret.ApiStatus);
            return ret;
        }

        /// <summary>
        ///     <a href="https://musicbrainz.org/doc/Folksonomy_Tagging" target="_blank">Tag</a> <br />
        ///     Folksonomy tags in any entity in MusicBrainz except URLs. They are comma-separated, so they may consist of several words.
        /// </summary>
        /// <param name="query">The Searchstring</param>
        /// ///
        /// <param name="limit">
        ///     An integer value defining how many entries should be returned. <br />
        ///     Only values between 1 and 100 (both inclusive) are allowed. <br />
        ///     If not given, this defaults to 25.
        /// </param>
        /// <param name="offset">
        ///     Return search results starting at a given offset. <br />
        ///     Used for paging through more than one page of results.
        /// </param>
        /// <returns>List of Tag</returns>
        public static Taglist Taglist(string query, int limit = 25, int offset = 0)
        {
            var ret = new Taglist();

            var le = new LoggingArgs(ns, cl, "Tag");
            le.Parameters.Add(new Para("query", query));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Find<Metadata.Metadata>(query, limit, offset, "tag");
                ret = tmp.Taglist ?? new Taglist();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            ret.ApiStatus = new ApiStatus(ns, cl, "Tag");
            Logging.NewStatus(ret.ApiStatus);
            return ret;
        }

        /// <summary>
        ///     <a href="https://musicbrainz.org/doc/Work" target="_blank">Work</a> <br />
        ///     In MusicBrainz terminology, a work is a distinct intellectual or artistic creation, <br />
        ///     which can be expressed in the form of one or more audio recordings. <br />
        ///     While a work in MusicBrainz is usually musical in nature, it is not necessarily so. <br />
        ///     For example, a work could be a novel, play, poem or essay, later recorded as an oratory or audiobook.
        /// </summary>
        /// <param name="query">The Searchstring</param>
        /// <param name="alias">the aliases/misspellings for this work</param>
        /// <param name="arid">artist id</param>
        /// <param name="artist">
        ///     artist name, an artist in the context of a work is an artist-work relation such as composer or
        ///     performer
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
        ///     An integer value defining how many entries should be returned. <br />
        ///     Only values between 1 and 100 (both inclusive) are allowed. <br />
        ///     If not given, this defaults to 25.
        /// </param>
        /// <param name="offset">
        ///     Return search results starting at a given offset. <br />
        ///     Used for paging through more than one page of results.
        /// </param>
        /// <returns>List of Work</returns>
        public static Worklist Work(string query = null, string alias = null, string arid = null, string artist = null,
            string comment = null,
            string iswc = null, string lang = null, string tag = null, string type = null, string wid = null,
            string work = null, string workaccent = null, int limit = 25, int offset = 0)
        {
            var ret = new Worklist();

            var le = new LoggingArgs(ns, cl, "Work");
            le.Parameters.Add(new Para("query", query));
            le.Parameters.Add(new Para("alias", alias));
            le.Parameters.Add(new Para("arid", arid));
            le.Parameters.Add(new Para("artist", artist));
            le.Parameters.Add(new Para("comment", comment));
            le.Parameters.Add(new Para("iswc", iswc));
            le.Parameters.Add(new Para("lang", lang));
            le.Parameters.Add(new Para("tag", tag));
            le.Parameters.Add(new Para("type", type));
            le.Parameters.Add(new Para("wid", wid));
            le.Parameters.Add(new Para("work", work));
            le.Parameters.Add(new Para("workaccent", workaccent));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Find<Metadata.Metadata>(Help.SearchToString(le.Parameters), limit, offset, "work");
                ret = tmp.Worklist ?? new Worklist();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            ret.ApiStatus = new ApiStatus(ns, cl, "Work");
            Logging.NewStatus(ret.ApiStatus);
            return ret;
        }

        #endregion
    }
}