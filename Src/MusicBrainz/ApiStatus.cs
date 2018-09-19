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
using MusicBrainz.Events;

namespace MusicBrainz
{
    /// <summary>
    ///     Informations about the last Call
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2018.08.22" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    public class ApiStatus
    {
        /// <summary>
        ///     Collection of Informations about the last Call
        /// </summary>
        public ApiStatus()
        {
            ErrorMessage = Exceptions.Instance.Message;
            ErrorOccurred = Exceptions.Instance.ErrorOccurred;
            Response = Http.LastResponse;
            ResponseCode = Http.StatusCode;
            Url = Http.Url;

            Logging.Clear();
        }

        /// <summary>
        ///     Collection of Informations about the last Call
        /// </summary>
        public ApiStatus(string namespaceValue, string classValue, string functionValue)
        {
            Namespace = namespaceValue;
            Class = classValue;
            Function = functionValue;
            ErrorMessage = Exceptions.Instance.Message;
            ErrorOccurred = Exceptions.Instance.ErrorOccurred;
            Response = Http.LastResponse;
            ResponseCode = Http.StatusCode;
            Url = Http.Url;
            DateOfEntry = DateTime.Now;

            Logging.Clear();
        }

        /// <summary>
        ///     The Namespace of the Caller
        /// </summary>
        public string Namespace { get; }

        /// <summary>
        ///     The Class of the Caller
        /// </summary>
        public string Class { get; }

        /// <summary>
        ///     The Method of the Caller
        /// </summary>
        public string Function { get; }

        /// <summary>
        ///     Error Message
        /// </summary>
        public string ErrorMessage { get; }

        /// <summary>
        ///     Is an Error occurred
        /// </summary>
        public bool ErrorOccurred { get; }

        /// <summary>
        ///     Response
        /// </summary>
        public string Response { get; }

        /// <summary>
        ///     HttpStatusCode of the last Response
        /// </summary>
        public HttpStatusCode ResponseCode { get; }

        /// <summary>
        ///     Last called Url
        /// </summary>
        public string Url { get; }

        /// <summary>
        ///     Datum des Eintrags
        /// </summary>
        /// <returns>Datum und Zeit</returns>
        public DateTime DateOfEntry { get; }

        /// <summary>
        ///     Create a string from the Status
        /// </summary>
        /// <returns>LogEntry as string</returns>
        public override string ToString()
        {
            return DateOfEntry + "\t" + Namespace + "\t" + "[" + Class + "]" + "\t" + "(" + Function + ")" + "\t";
        }
    }
}