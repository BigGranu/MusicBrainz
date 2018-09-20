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
using System.Net;
using System.Threading;
using MusicBrainz.Events;

namespace MusicBrainz
{
    /// <summary>
    ///     Http Functions
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    internal class Http
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;
        private static string UserAgent = "MusicBrainz.Net/1.0.0 ( https://github.com/BigGranu/MusicBrainz )";

        /// <summary>
        ///     HttpStatusCode of the last Response
        /// </summary>
        public static HttpStatusCode StatusCode = HttpStatusCode.Unused;

        /// <summary>
        ///     Last Http Response
        /// </summary>
        public static string LastResponse { get; set; } = string.Empty;

        /// <summary>
        ///     Last called Url
        /// </summary>
        public static string Url { get; set; } = string.Empty;

        /// <summary>
        ///     Make a Webrequest
        /// </summary>
        /// <param name="url">Url</param>
        /// <returns>Response as String</returns>
        public static string Request(string url)
        {
            LastResponse = string.Empty;
            Url = url;
#if HTTP_ASYNC
            try
            {
                using (System.Net.Http.HttpClientHandler handler = new System.Net.Http.HttpClientHandler {AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate})
                {
                    using (var client = new System.Net.Http.HttpClient(handler))
                    {
                        CancellationTokenSource cts = new CancellationTokenSource(2000);
                        using (System.Net.Http.HttpRequestMessage httpRequest = new System.Net.Http.HttpRequestMessage(System.Net.Http.HttpMethod.Get, url))
                        {
                            httpRequest.Headers.UserAgent.ParseAdd(UserAgent);
                            httpRequest.Headers.Accept.ParseAdd("text/html, application/xhtml+xml, application/xml");

                            using (System.Net.Http.HttpResponseMessage httpResponse = client.SendAsync(httpRequest, cts.Token).Result)
                            {
                                LastResponse = httpResponse.Content.ReadAsStringAsync().Result;
                                StatusCode = httpResponse.StatusCode;
                            }
                        }
                    }
                }

                return LastResponse;
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex.HResult == -2146233088 ? new TimeoutException() : ex);
                return string.Empty;
            }
#else
            try
            {
                if (!(System.Net.WebRequest.Create(url) is System.Net.HttpWebRequest request)) return LastResponse;
                request.UserAgent = UserAgent;
                request.Accept = "text/html, application/xhtml+xml, application/xml";
                request.AutomaticDecompression = System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate;
                request.Timeout = 1000;

                using (System.Net.HttpWebResponse response = (System.Net.HttpWebResponse) request.GetResponse())
                {
                    using (System.IO.Stream dataStream = response.GetResponseStream())
                    {
                        using (System.IO.StreamReader reader = new System.IO.StreamReader(dataStream))
                        {
                            StatusCode = response.StatusCode;
                            LastResponse = reader.ReadToEnd();
                        }
                    }
                }

                return LastResponse;
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
                return string.Empty;
            }
#endif

        }
    }
}