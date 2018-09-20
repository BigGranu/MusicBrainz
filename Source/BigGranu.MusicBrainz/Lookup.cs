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
    ///     Perform a lookup of an entity when you have the MBID for that entity
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    public class Lookup
    {
        private static readonly Logging Logging = Logging.Instance;
        private static readonly Exceptions Exceptions = Exceptions.Instance;
        private static readonly string ns = "MusicBrainz";
        private static readonly string cl = "Browse";

        /// <summary>
        ///     Deactivate all Inc in all Lookups
        /// </summary>
        public static bool UseAllIncs { get; set; } = true;

        /// <summary>
        ///     Area
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        /// <param name="aliases">
        ///     Artist, Label, Area or Work aliases. <br />
        ///     Treat these as a set, as they are not deliberately ordered
        /// </param>
        /// <param name="annotation">Annotation</param>
        /// <param name="tags">Tags</param>
        /// <example>
        ///     <code lang="c#">
        /// var _client = new Client(IPAddress.Parse("192.168.1.100"), 42 );
        /// var ret = _client.Send("CPU0_FAN");
        /// </code>
        ///     <code lang="vb">
        /// Dim _client = New Client(IPAddress.Parse("192.168.1.100"), 42 )
        /// Dim ret = _client.Send("CPU0_FAN")
        /// </code>
        /// </example>
        /// <returns>Details to the Area</returns>
        public static Area Area(string musicBrainzId, bool aliases = true, bool annotation = true, bool tags = true)
        {
            var ret = new Area();
            Logging.NewLogEntry(new LoggingArgs(ns, cl, "Area", new Para("musicBrainzId", musicBrainzId)));

            try
            {
                var inc = Help.Inc(aliases, annotation, tags);
                var tmp = Http.Request("http://musicbrainz.org/ws/2/area/" + musicBrainzId + inc);
                if (tmp != "")
                {
                    var tt = Xml.Deserialize<Metadata.Metadata>(tmp);
                    ret = tt.Area ?? new Area();
                }
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
        ///     Artist
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        /// <param name="aliases">
        ///     Artist, Label, Area or Work aliases. <br />
        ///     Treat these as a set, as they are not deliberately ordered
        /// </param>
        /// <param name="annotation">Annotation</param>
        /// <param name="tags">Tags</param>
        /// <param name="ratings">Ratings</param>
        /// <param name="variousartists">
        ///     Include only those releases where the artist appears on one of the tracks.<br />
        ///     But not in the artist credit for the release itself
        /// </param>
        /// <param name="recordings">Recordings</param>
        /// <param name="releasegroups">Release Groups</param>
        /// <param name="isrcs">Isrcs</param>
        /// <param name="artistcredits">Artist Credits</param>
        /// <returns>Details to the Artist</returns>
        public static Artist Artist(string musicBrainzId, bool aliases = true, bool annotation = true,
            bool tags = true, bool ratings = true, bool variousartists = true, bool recordings = true,
            bool releasegroups = true, bool isrcs = true, bool artistcredits = true)
        {
            var ret = new Artist();
            Logging.NewLogEntry(new LoggingArgs(ns, cl, "Artist", new Para("musicBrainzId", musicBrainzId)));

            try
            {
                var inc = Help.Inc(aliases, annotation, tags, ratings, recordings: recordings, releasegroups: releasegroups, isrcs: isrcs, artistcredits: artistcredits);
                var tmp = Http.Request("http://musicbrainz.org/ws/2/artist/" + musicBrainzId + inc);
                if (tmp != "")
                {
                    var tt = Xml.Deserialize<Metadata.Metadata>(tmp);
                    ret = tt.Artist ?? new Artist();
                }
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
        ///     Collection
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        /// <returns>Details to the Url</returns>
        public static Collection Collection(string musicBrainzId)
        {
            var ret = new Collection();
            Logging.NewLogEntry(new LoggingArgs(ns, cl, "Collection", new Para("musicBrainzId", musicBrainzId)));

            try
            {
                var tmp = Http.Request("http://musicbrainz.org/ws/2/collection/" + musicBrainzId);
                if (tmp != "")
                {
                    var tt = Xml.Deserialize<Metadata.Metadata>(tmp);
                    ret = tt.Collection ?? new Collection();
                }
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            ret.ApiStatus = new ApiStatus(ns, cl, "Collection");
            Logging.NewStatus(ret.ApiStatus);
            return ret;
        }

        /// <summary>
        ///     Event
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        /// <param name="aliases">
        ///     Artist, Label, Area or Work aliases. <br />
        ///     Treat these as a set, as they are not deliberately ordered
        /// </param>
        /// <param name="annotation">Annotation</param>
        /// <param name="tags">Tags</param>
        /// <param name="ratings">Ratings</param>
        /// <returns>Details to the Event</returns>
        public static Event Event(string musicBrainzId, bool aliases = true, bool annotation = true, bool tags = true, bool ratings = true)
        {
            var ret = new Event();
            Logging.NewLogEntry(new LoggingArgs(ns, cl, "Event", new Para("musicBrainzId", musicBrainzId)));

            try
            {
                var inc = Help.Inc(aliases, annotation, tags, ratings);
                var tmp = Http.Request("http://musicbrainz.org/ws/2/event/" + musicBrainzId + inc);
                if (tmp != "")
                {
                    var tt = Xml.Deserialize<Metadata.Metadata>(tmp);
                    ret = tt.Event ?? new Event();
                }
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            ret.ApiStatus = new ApiStatus(ns, cl, "Event");
            Logging.NewStatus(ret.ApiStatus);
            return ret;
        }

        /// <summary>
        ///     Instrument
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        /// <param name="aliases">
        ///     Artist, Label, Area or Work aliases. <br />
        ///     Treat these as a set, as they are not deliberately ordered
        /// </param>
        /// <param name="annotation">Annotation</param>
        /// <param name="tags">Tags</param>
        /// <returns>Details to the Instrument</returns>
        public static Instrument Instrument(string musicBrainzId, bool aliases = true, bool annotation = true, bool tags = true)
        {
            var ret = new Instrument();
            Logging.NewLogEntry(new LoggingArgs(ns, cl, "Instrument", new Para("musicBrainzId", musicBrainzId)));

            try
            {
                var inc = Help.Inc(aliases, annotation, tags);
                var tmp = Http.Request("http://musicbrainz.org/ws/2/instrument/" + musicBrainzId + inc);
                if (tmp != "")
                {
                    var tt = Xml.Deserialize<Metadata.Metadata>(tmp);
                    ret = tt.Instrument ?? new Instrument();
                }
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            ret.ApiStatus = new ApiStatus(ns, cl, "Instrument");
            Logging.NewStatus(ret.ApiStatus);
            return ret;
        }

        /// <summary>
        ///     Label
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        /// <param name="aliases">
        ///     Artist, Label, Area or Work aliases. <br />
        ///     Treat these as a set, as they are not deliberately ordered
        /// </param>
        /// <param name="annotation">Annotation</param>
        /// <param name="tags">Tags</param>
        /// <param name="ratings">Ratings</param>
        /// <returns>Details to the Label</returns>
        public static Label Label(string musicBrainzId, bool aliases = true, bool annotation = true, bool tags = true, bool ratings = true)
        {
            var ret = new Label();
            Logging.NewLogEntry(new LoggingArgs(ns, cl, "Label", new Para("musicBrainzId", musicBrainzId)));

            try
            {
                var inc = Help.Inc(aliases, annotation, tags, ratings);
                var tmp = Http.Request("http://musicbrainz.org/ws/2/label/" + musicBrainzId + inc);
                if (tmp != "")
                {
                    var tt = Xml.Deserialize<Metadata.Metadata>(tmp);
                    ret = tt.Label ?? new Label();
                }
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
        ///     Place
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        /// <param name="aliases">
        ///     Artist, Label, Area or Work aliases. <br />
        ///     Treat these as a set, as they are not deliberately ordered
        /// </param>
        /// <param name="annotation">Annotation</param>
        /// <param name="tags">Tags</param>
        /// <returns>Details to the Place</returns>
        public static Place Place(string musicBrainzId, bool aliases = true, bool annotation = true, bool tags = true)
        {
            var ret = new Place();
            Logging.NewLogEntry(new LoggingArgs(ns, cl, "Place", new Para("musicBrainzId", musicBrainzId)));

            try
            {
                var inc = Help.Inc(aliases, annotation, tags);
                var tmp = Http.Request("http://musicbrainz.org/ws/2/place/" + musicBrainzId + inc);
                if (tmp != "")
                {
                    var tt = Xml.Deserialize<Metadata.Metadata>(tmp);
                    ret = tt.Place ?? new Place();
                }
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            ret.ApiStatus = new ApiStatus(ns, cl, "Place");
            Logging.NewStatus(ret.ApiStatus);
            return ret;
        }

        /// <summary>
        ///     Recording
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        /// <param name="aliases">
        ///     Artist, Label, Area or Work aliases. <br />
        ///     Treat these as a set, as they are not deliberately ordered
        /// </param>
        /// <param name="annotation">Annotation</param>
        /// <param name="tags">Tags</param>
        /// <param name="ratings">Ratings</param>
        /// <param name="artists">Artist</param>
        /// <param name="releasegroups">Release Group</param>
        /// <param name="isrcs">Isrcs</param>
        /// <param name="artistcredits">Artist Credits</param>
        /// <returns>Details to the Recording</returns>
        public static Recording Recording(string musicBrainzId, bool aliases = true, bool annotation = true,
            bool tags = true, bool ratings = true, bool artists = true, bool releasegroups = true, bool isrcs = true, bool artistcredits = true)
        {
            var ret = new Recording();

            Logging.NewLogEntry(new LoggingArgs(ns, cl, "Recording", new Para("musicBrainzId", musicBrainzId)));

            try
            {
                var inc = Help.Inc(aliases, annotation, tags, ratings, artists: artists, releasegroups: releasegroups, isrcs: isrcs, artistcredits: artistcredits);
                var tmp = Http.Request("http://musicbrainz.org/ws/2/recording/" + musicBrainzId + inc);
                if (tmp != "")
                {
                    var tt = Xml.Deserialize<Metadata.Metadata>(tmp);
                    ret = tt.Recording ?? new Recording();
                }
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
        ///     Release
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        /// <param name="aliases">
        ///     Artist, Label, Area or Work aliases. <br />
        ///     Treat these as a set, as they are not deliberately ordered
        /// </param>
        /// <param name="annotation">Annotation</param>
        /// <param name="tags">Tags</param>
        /// <param name="ratings">Ratings</param>
        /// <param name="artists">Artist</param>
        /// <param name="collections">Collections</param>
        /// <param name="labels">Labels</param>
        /// <param name="recordings">Recordings</param>
        /// <param name="releasegroups">Release Group</param>
        /// <param name="discids">Disc Ids</param>
        /// <param name="media">Media</param>
        /// <param name="isrcs">Isrcs</param>
        /// <param name="artistcredits">Artist Credits</param>
        /// <returns>Details to the Release</returns>
        public static Release Release(string musicBrainzId, bool aliases = true, bool annotation = true,
            bool tags = true, bool ratings = true, bool artists = true, bool collections = true, bool labels = true, bool recordings = true,
            bool releasegroups = true, bool discids = true, bool media = true, bool isrcs = true, bool artistcredits = true)
        {
            var ret = new Release();
            Logging.NewLogEntry(new LoggingArgs(ns, cl, "Release", new Para("musicBrainzId", musicBrainzId)));

            try
            {
                var inc = Help.Inc(aliases, annotation, tags, ratings, artists: artists, collections: collections, labels: labels, recordings: recordings, releasegroups: releasegroups, discids: discids, media: media, isrcs: isrcs,
                    artistcredits: artistcredits);
                var tmp = Http.Request("http://musicbrainz.org/ws/2/release/" + musicBrainzId + inc);
                if (tmp != "")
                {
                    var tt = Xml.Deserialize<Metadata.Metadata>(tmp);
                    ret = tt.Release ?? new Release();
                }
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
        ///     Release Group
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        /// <param name="aliases">
        ///     Artist, Label, Area or Work aliases. <br />
        ///     Treat these as a set, as they are not deliberately ordered
        /// </param>
        /// <param name="annotation">Annotation</param>
        /// <param name="tags">Tags</param>
        /// <param name="ratings">Ratings</param>
        /// <param name="artists">Artist</param>
        /// <param name="artistcredits">Artist Credits</param>
        /// <returns>Details to the Release Group</returns>
        public static Releasegroup ReleaseGroup(string musicBrainzId, bool aliases = true, bool annotation = true, bool tags = true, bool ratings = true, bool artists = true, bool artistcredits = true)
        {
            var ret = new Releasegroup();
            Logging.NewLogEntry(new LoggingArgs(ns, cl, "ReleaseGroup", new Para("musicBrainzId", musicBrainzId)));

            try
            {
                var inc = Help.Inc(aliases, annotation, tags, ratings, artists: artists, artistcredits: artistcredits);
                var tmp = Http.Request("http://musicbrainz.org/ws/2/release-group/" + musicBrainzId + inc);
                if (tmp != "")
                {
                    var tt = Xml.Deserialize<Metadata.Metadata>(tmp);
                    ret = tt.Releasegroup ?? new Releasegroup();
                }
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
        ///     Series
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        /// <param name="aliases">
        ///     Artist, Label, Area or Work aliases. <br />
        ///     Treat these as a set, as they are not deliberately ordered
        /// </param>
        /// <param name="annotation">Annotation</param>
        /// <param name="tags">Tags</param>
        /// <returns>Details to the Series</returns>
        public static Series Series(string musicBrainzId, bool aliases = true, bool annotation = true, bool tags = true)
        {
            var ret = new Series();
            Logging.NewLogEntry(new LoggingArgs(ns, cl, "Series", new Para("musicBrainzId", musicBrainzId)));

            try
            {
                var inc = Help.Inc(aliases, annotation, tags);
                var tmp = Http.Request("http://musicbrainz.org/ws/2/series/" + musicBrainzId + inc);
                if (tmp != "")
                {
                    var tt = Xml.Deserialize<Metadata.Metadata>(tmp);
                    ret = tt.Series ?? new Series();
                }
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            ret.ApiStatus = new ApiStatus(ns, cl, "Series");
            Logging.NewStatus(ret.ApiStatus);
            return ret;
        }

        /// <summary>
        ///     Work
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        /// <param name="aliases">
        ///     Artist, Label, Area or Work aliases. <br />
        ///     Treat these as a set, as they are not deliberately ordered
        /// </param>
        /// <param name="annotation">Annotation</param>
        /// <param name="tags">Tags</param>
        /// <param name="ratings">Ratings</param>
        /// <returns>Details to the Work</returns>
        public static Work Work(string musicBrainzId, bool aliases = true, bool annotation = true, bool tags = true, bool ratings = true)
        {
            var ret = new Work();
            Logging.NewLogEntry(new LoggingArgs(ns, cl, "Work", new Para("musicBrainzId", musicBrainzId)));

            try
            {
                var inc = Help.Inc(aliases, annotation, tags, ratings);
                var tmp = Http.Request("http://musicbrainz.org/ws/2/work/" + musicBrainzId + inc);
                if (tmp != "")
                {
                    var tt = Xml.Deserialize<Metadata.Metadata>(tmp);
                    ret = tt.Work ?? new Work();
                }
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            ret.ApiStatus = new ApiStatus(ns, cl, "Work");
            Logging.NewStatus(ret.ApiStatus);
            return ret;
        }

        /// <summary>
        ///     Url
        /// </summary>
        /// <param name="musicBrainzId">MusicBrainzId</param>
        /// <returns>Details to the Url</returns>
        public static Url Url(string musicBrainzId)
        {
            var ret = new Url();
            Logging.NewLogEntry(new LoggingArgs(ns, cl, "Url", new Para("musicBrainzId", musicBrainzId)));

            try
            {
                var tmp = Http.Request("http://musicbrainz.org/ws/2/url/" + musicBrainzId);
                if (tmp != "")
                {
                    var tt = Xml.Deserialize<Metadata.Metadata>(tmp);
                    ret = tt.Url ?? new Url();
                }
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            ret.ApiStatus = new ApiStatus(ns, cl, "Url");
            Logging.NewStatus(ret.ApiStatus);
            return ret;
        }
    }
}