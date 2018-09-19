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
using System.Collections.Generic;
using MusicBrainz.Events;
using MusicBrainz.Metadata;

namespace MusicBrainz
{
    /// <summary>
    ///     Browse on MusicBrainz
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    public class Browse
    {
        /// <summary>
        ///     Release Status
        /// </summary>
        public enum Status
        {
            /// <summary>
            ///     Official
            /// </summary>
            Official,

            /// <summary>
            ///     Promotion
            /// </summary>
            Promotion,

            /// <summary>
            ///     Bootleg
            /// </summary>
            Bootleg,

            /// <summary>
            ///     Pseudo Release
            /// </summary>
            Pseudorelease
        }

        /// <summary>
        ///     Release Type
        /// </summary>
        public enum Type
        {
            /// <summary>
            ///     Nat
            /// </summary>
            Nat,

            /// <summary>
            ///     Album
            /// </summary>
            Album,

            /// <summary>
            ///     Single
            /// </summary>
            Single,

            /// <summary>
            ///     Ep
            /// </summary>
            Ep,

            /// <summary>
            ///     Compilation
            /// </summary>
            Compilation,

            /// <summary>
            ///     Soundtrack
            /// </summary>
            Soundtrack,

            /// <summary>
            ///     Spokenword
            /// </summary>
            Spokenword,

            /// <summary>
            ///     Interview
            /// </summary>
            Interview,

            /// <summary>
            ///     Audiobook
            /// </summary>
            Audiobook,

            /// <summary>
            ///     Live
            /// </summary>
            Live,

            /// <summary>
            ///     Remix
            /// </summary>
            Remix,

            /// <summary>
            ///     Other
            /// </summary>
            Other
        }

        private static readonly Logging Logging = Logging.Instance;
        private static readonly Exceptions Exceptions = Exceptions.Instance;
        private static readonly string ns = "MusicBrainz";
        private static readonly string cl = "Browse";

        /// <summary>
        ///     Area
        /// </summary>
        /// <param name="collection">Collection</param>
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
        public static Arealist Area(string collection, int limit = 25, int offset = 0)
        {
            var ret = new Arealist();

            var le = new LoggingArgs(ns, cl, "Area");
            le.Parameters.Add(new Para("collection", collection));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Browse<Metadata.Metadata>(Help.BrowseToString(le.Parameters), limit, offset, "area");
                if (tmp != null)
                    ret = tmp.Arealist ?? new Arealist();
                else
                    ret = new Arealist();
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
        /// <param name="area">Area</param>
        /// <param name="collection">Collection</param>
        /// <param name="recording">Recording</param>
        /// <param name="release">Release</param>
        /// <param name="releasegroup">Release Group</param>
        /// <param name="work">Work</param>
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
        public static Artistlist Artist(string area = null, string collection = null, string recording = null, string release = null, string releasegroup = null, string work = null, int limit = 25, int offset = 0)
        {
            var ret = new Artistlist();

            var le = new LoggingArgs(ns, cl, "Artist");
            le.Parameters.Add(new Para("area", area));
            le.Parameters.Add(new Para("collection", collection));
            le.Parameters.Add(new Para("recording", recording));
            le.Parameters.Add(new Para("release", release));
            le.Parameters.Add(new Para("release-group", releasegroup));
            le.Parameters.Add(new Para("work", work));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Browse<Metadata.Metadata>(Help.BrowseToString(le.Parameters), limit, offset, "artist");
                if (tmp != null)
                    ret = tmp.Artistlist ?? new Artistlist();
                else
                    ret = new Artistlist();
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
        /// <param name="area">Area</param>
        /// <param name="artist">Artist</param>
        /// <param name="editor">Editor</param>
        /// <param name="event">Event</param>
        /// <param name="label">Label</param>
        /// <param name="place">Place</param>
        /// <param name="recording">Recording</param>
        /// <param name="release">Release</param>
        /// <param name="releasegroup">Release Group</param>
        /// <param name="work">Work</param>
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
        public static Collectionlist Collection(string area = null, string artist = null, string editor = null, string @event = null, string label = null, string place = null, string recording = null, string release = null, string releasegroup = null, string work = null, int limit = 25, int offset = 0)
        {
            var ret = new Collectionlist();

            var le = new LoggingArgs(ns, cl, "Collection");
            le.Parameters.Add(new Para("area", area));
            le.Parameters.Add(new Para("artist", artist));
            le.Parameters.Add(new Para("editor", editor));
            le.Parameters.Add(new Para("event", @event));
            le.Parameters.Add(new Para("label", label));
            le.Parameters.Add(new Para("place", place));
            le.Parameters.Add(new Para("recording", recording));
            le.Parameters.Add(new Para("release", release));
            le.Parameters.Add(new Para("release-group", releasegroup));
            le.Parameters.Add(new Para("work", work));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Browse<Metadata.Metadata>(Help.BrowseToString(le.Parameters), limit, offset, "collection");
                if (tmp != null)
                    ret = tmp.Collectionlist ?? new Collectionlist();
                else
                    ret = new Collectionlist();
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
        /// <param name="area">Area</param>
        /// <param name="artist">Artist</param>
        /// <param name="collection">Collection</param>
        /// <param name="place">Place</param>
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
        public static Eventlist Event(string area = null, string artist = null, string collection = null, string place = null, int limit = 25, int offset = 0)
        {
            var ret = new Eventlist();

            var le = new LoggingArgs(ns, cl, "Event");
            le.Parameters.Add(new Para("area", area));
            le.Parameters.Add(new Para("artist", artist));
            le.Parameters.Add(new Para("collection", collection));
            le.Parameters.Add(new Para("place", place));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Browse<Metadata.Metadata>(Help.BrowseToString(le.Parameters), limit, offset, "event");
                if (tmp != null)
                    ret = tmp.Eventlist ?? new Eventlist();
                else
                    ret = new Eventlist();
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
        /// <param name="collection">Collection</param>
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
        public static Instrumentlist Instrument(string collection, int limit = 25, int offset = 0)
        {
            var ret = new Instrumentlist();

            var le = new LoggingArgs(ns, cl, "Instrument");
            le.Parameters.Add(new Para("collection", collection));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Browse<Metadata.Metadata>(Help.BrowseToString(le.Parameters), limit, offset, "instrument");
                if (tmp != null)
                    ret = tmp.Instrumentlist ?? new Instrumentlist();
                else
                    ret = new Instrumentlist();
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
        /// <param name="area">Area</param>
        /// <param name="collection">Collection</param>
        /// <param name="release">Release</param>
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
        public static Labellist Label(string area = null, string collection = null, string release = null, int limit = 25, int offset = 0)
        {
            var ret = new Labellist();

            var le = new LoggingArgs(ns, cl, "Label");
            le.Parameters.Add(new Para("area", area));
            le.Parameters.Add(new Para("collection", collection));
            le.Parameters.Add(new Para("release", release));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Browse<Metadata.Metadata>(Help.BrowseToString(le.Parameters), limit, offset, "label");
                if (tmp != null)
                    ret = tmp.Labellist ?? new Labellist();
                else
                    ret = new Labellist();
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
        /// <param name="area">Area</param>
        /// <param name="collection">Collection</param>
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
        public static Placelist Place(string area = null, string collection = null, int limit = 25, int offset = 0)
        {
            var ret = new Placelist();

            var le = new LoggingArgs(ns, cl, "Place");
            le.Parameters.Add(new Para("area", area));
            le.Parameters.Add(new Para("collection", collection));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Browse<Metadata.Metadata>(Help.BrowseToString(le.Parameters), limit, offset, "place");
                if (tmp != null)
                    ret = tmp.Placelist ?? new Placelist();
                else
                    ret = new Placelist();
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
        /// <param name="artist">Artist</param>
        /// <param name="collection">Collection</param>
        /// <param name="release">Release</param>
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
        public static Recordinglist Recording(string artist = null, string collection = null, string release = null, int limit = 25, int offset = 0)
        {
            var ret = new Recordinglist();

            var le = new LoggingArgs(ns, cl, "Recording");
            le.Parameters.Add(new Para("artist", artist));
            le.Parameters.Add(new Para("collection", collection));
            le.Parameters.Add(new Para("release", release));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Browse<Metadata.Metadata>(Help.BrowseToString(le.Parameters), limit, offset, "recording");
                if (tmp != null)
                    ret = tmp.Recordinglist ?? new Recordinglist();
                else
                    ret = new Recordinglist();
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
        /// <param name="area">Area</param>
        /// <param name="artist">Artist</param>
        /// <param name="collection">Collection</param>
        /// <param name="label">Label</param>
        /// <param name="track">Track</param>
        /// <param name="trackartist">Trackartist</param>
        /// <param name="recording">Recording</param>
        /// <param name="releasegroup">Release Group</param>
        /// <param name="types">Release Types</param>
        /// <param name="status">Release Status</param>
        /// <param name="limit">
        ///     An integer value defining how many entries should be returned. <br />
        ///     Only values between 1 and 100 (both inclusive) are allowed. <br />
        ///     If not given, this defaults to 25.
        /// </param>
        /// <param name="offset">
        ///     Return search results starting at a given offset. <br />
        ///     Used for paging through more than one page of results.
        /// </param>
        /// <returns>Releaselist</returns>
        public static Releaselist Release(string area = null, string artist = null, string collection = null, string label = null, string track = null, string trackartist = null, string recording = null, string releasegroup = null, List<Type> types = null, List<Status> status = null, int limit = 25, int offset = 0)
        {
            var ret = new Releaselist();

            var le = new LoggingArgs(ns, cl, "Release");
            le.Parameters.Add(new Para("area", area));
            le.Parameters.Add(new Para("artist", artist));
            le.Parameters.Add(new Para("collection", collection));
            le.Parameters.Add(new Para("label", label));
            le.Parameters.Add(new Para("track", track));
            le.Parameters.Add(new Para("track_artist", trackartist));
            le.Parameters.Add(new Para("recording", recording));
            le.Parameters.Add(new Para("release-group", releasegroup));
            le.Parameters.Add(new Para("type", Help.TypesToString(types)));
            le.Parameters.Add(new Para("status", Help.StatusToString(status)));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Browse<Metadata.Metadata>(Help.BrowseToString(le.Parameters), limit, offset, "release");
                if (tmp != null)
                    ret = tmp.Releaselist ?? new Releaselist();
                else
                    ret = new Releaselist();
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
        ///     ReleaseGroup
        /// </summary>
        /// <param name="artist">Artist</param>
        /// <param name="collection">Collection</param>
        /// <param name="release">Release</param>
        /// <param name="types">Types</param>
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
        public static Releasegrouplist ReleaseGroup(string artist = null, string collection = null, string release = null, List<Type> types = null, int limit = 25, int offset = 0)
        {
            var ret = new Releasegrouplist();

            var le = new LoggingArgs(ns, cl, "ReleaseGroup");
            le.Parameters.Add(new Para("artist", artist));
            le.Parameters.Add(new Para("collection", collection));
            le.Parameters.Add(new Para("release", release));
            le.Parameters.Add(new Para("type", Help.TypesToString(types)));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Browse<Metadata.Metadata>(Help.BrowseToString(le.Parameters), limit, offset, "release-group");
                if (tmp != null)
                    ret = tmp.Releasegrouplist ?? new Releasegrouplist();
                else
                    ret = new Releasegrouplist();
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
        /// <param name="collection">Collection</param>
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
        public static Serieslist Series(string collection, int limit = 25, int offset = 0)
        {
            var ret = new Serieslist();

            var le = new LoggingArgs(ns, cl, "Series");
            le.Parameters.Add(new Para("collection", collection));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Browse<Metadata.Metadata>(Help.BrowseToString(le.Parameters), limit, offset, "series");
                if (tmp != null)
                    ret = tmp.Serieslist ?? new Serieslist();
                else
                    ret = new Serieslist();
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
        /// <param name="artist">Artist</param>
        /// <param name="collection">Collection</param>
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
        public static Worklist Work(string artist = null, string collection = null, int limit = 25, int offset = 0)
        {
            var ret = new Worklist();

            var le = new LoggingArgs(ns, cl, "Work");
            le.Parameters.Add(new Para("artist", artist));
            le.Parameters.Add(new Para("collection", collection));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Browse<Metadata.Metadata>(Help.BrowseToString(le.Parameters), limit, offset, "work");
                if (tmp != null)
                    ret = tmp.Worklist ?? new Worklist();
                else
                    ret = new Worklist();
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
        /// <param name="resource">Url</param>
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
        public static Urllist Url(Uri resource, int limit = 25, int offset = 0)
        {
            var ret = new Urllist();

            var le = new LoggingArgs(ns, cl, "Url");
            le.Parameters.Add(new Para("resource", resource.ToString()));
            Logging.NewLogEntry(le);

            try
            {
                var tmp = Help.Browse<Metadata.Metadata>("resource=" + resource, limit, offset, "url");
                if (tmp.Urllist == null && tmp.Url != null) ret.Url = new List<Url> {tmp.Url};
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