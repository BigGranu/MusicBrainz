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

namespace MusicBrainz
{
    internal class Help
    {
        public static string SearchToString(List<Para> args)
        {
            var result = string.Empty;

            foreach (var t in args)
                if ((t.Value != "") & (t.Value != null))
                {
                    if (t.Name == "query")
                    {
                        result += CheckValue(t.Value) + "%20AND%20";
                    }
                    else
                    {
                        result += t.Name.ToLower() + ":" + CheckValue(t.Value) + "%20AND%20";
                    }
                }

            return result.LastIndexOf("%20AND%20", StringComparison.Ordinal) > 0 ? result.Substring(0, result.LastIndexOf("%20AND%20", StringComparison.Ordinal)) : result;
        }

        public static string BrowseToString(List<Para> args)
        {
            var result = string.Empty;

            foreach (var t in args)
                if ((t.Value != "") & (t.Value != null))
                    result += t.Name.ToLower() + "=" + CheckValue(t.Value) + "&";

            result = result.Replace("\"", "");
            return result.LastIndexOf("&", StringComparison.Ordinal) > 0 ? result.Substring(0, result.LastIndexOf("&", StringComparison.Ordinal)) : result;
        }

        public static string LimitOffsetToString(int limit, int offset)
        {
            var result = string.Empty;

            if (limit != 25)
                result += "&limit=" + limit;

            if (offset != 0)
                result += "&offset=" + offset;

            return result;
        }

        public static string TypesToString(List<Browse.Type> types)
        {
            var t = "";
            foreach (var ty in types) t += ty.ToString().ToLower() + "|";

            return t.EndsWith("|") ? t.Substring(0, t.Length - 1) : t;
        }

        public static string StatusToString(List<Browse.Status> status)
        {
            var t = "";
            foreach (var ty in status) t += ty.ToString().ToLower() + "|";

            t = t.Replace("pseudorelease", "pseudo-release");

            return t.EndsWith("|") ? t.Substring(0, t.Length - 1) : t;
        }

        public static T Find<T>(string query, int limit, int offset, string part)
        {
            try
            {
                var o = Http.Request("http://musicbrainz.org/ws/2/" + part + "/?query=" + query + LimitOffsetToString(limit, offset));
                return o != "" ? Xml.Deserialize<T>(o) : default(T);
            }
            catch (Exception ex)
            {
                Exceptions.Instance.NewException(ex);
                return default(T);
            }
        }

        public static T Browse<T>(string query, int limit, int offset, string part)
        {
            try
            {
                var o = Http.Request("http://musicbrainz.org/ws/2/" + part + "?" + query + LimitOffsetToString(limit, offset));
                return o != "" ? Xml.Deserialize<T>(o) : default(T);
            }
            catch (Exception ex)
            {
                Exceptions.Instance.NewException(ex);
                return default(T);
            }
        }

        private static string CheckValue(string value)
        {
            List<string> SpecialCharacters = new List<string> {"\\", "&", "|", "!", "(", ")" ,"{" ,"}" ,"[" ,"]" ,"^" ,"~", "*", "?", ":", "/"};

            foreach (var c in SpecialCharacters)
                value = value.Replace(c, "\\" + c);

            if (value.Contains("\\") || value.Contains(" AND ") || value.Contains(" OR ") || value.Contains(" NOT "))
                return value.Replace(" ", "%20");

            return "\"" + value.Replace(" ", "%20") + "\"";
        }

        public static string Inc(
            bool aliases = false,
            bool annotation = false,
            bool tags = false,
            bool ratings = false,
            bool discids = false,
            bool media = false,
            bool artists = false,
            bool collections = false,
            bool labels = false,
            bool artistcredits = false,
            bool variousartists = false,
            bool recordings = false,
            bool releasegroups = false,
            bool isrcs = false)
        {
            if (Lookup.UseAllIncs == false)
                return "";

            var inc = "";
            if (aliases)
                inc += "aliases+";
            if (annotation)
                inc += "annotation+";
            if (tags)
                inc += "tags+";
            if (ratings)
                inc += "ratings+";
            if (discids)
                inc += "discids+";
            if (media)
                inc += "media+";
            if (artists)
                inc += "artists+";
            if (collections)
                inc += "collections+";
            if (labels)
                inc += "labels+";
            if (artistcredits)
                inc += "artist-credits+";
            if (variousartists)
                inc += "various-artists+";
            if (recordings)
                inc += "recordings+";
            if (releasegroups)
                inc += "release-groups+";
            if (isrcs)
                inc += "isrcs+";

            if (inc.EndsWith("+"))
                inc = inc.Substring(0, inc.Length - 1);

            if (inc != "")
                inc = "?inc=" + inc;

            return inc;
        }
    }
}