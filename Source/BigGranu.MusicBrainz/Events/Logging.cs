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
using System.Net.Sockets;

namespace MusicBrainz.Events
{
    /// <summary>
    ///     Handler for Logging
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    public class Logging
    {
        /// <summary>
        ///     Eventhandler
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">LogEntry</param>
        public delegate void CallArgs(object sender, LoggingArgs e);

        public delegate void CallStatus(object sender, ApiStatus e);

        private static Logging _instance;

        /// <summary>
        ///     Create new Logging
        /// </summary>
        public Logging()
        {
            _instance = this;
        }

        /// <summary>
        ///     Instance of Logging
        /// </summary>
        public static Logging Instance => _instance ?? (_instance = new Logging());

        /// <summary>
        ///     EventHandler for Logging
        /// </summary>
        public event CallArgs LogEntryTriggered;

        /// <summary>
        ///     Create a new LogEntry
        /// </summary>
        /// <param name="entry">The LogEntry</param>
        internal void NewLogEntry(LoggingArgs entry)
        {
            LogEntryTriggered?.Invoke(new object(), entry);
        }

        /// <summary>
        ///     Clear the Exception
        /// </summary>
        internal static void Clear()
        {
            Exceptions.Instance.Exception = null;
            Exceptions.Instance.Message = "";
            Exceptions.Instance.ErrorOccurred = false;
            Http.LastResponse = string.Empty;
        }

        public event CallStatus StatusTriggered;

        internal void NewStatus(ApiStatus status)
        {
            StatusTriggered?.Invoke(new object(), status);
        }
    }

    /// <summary>
    ///     Logentry
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    public class LoggingArgs : EventArgs
    {
        /// <summary>
        ///     Create a new LogEntry
        /// </summary>
        /// <param name="namespaceValue">Namespace</param>
        /// <param name="classValue">Class</param>
        /// <param name="functionValue">Function</param>
        /// <param name="parameters">Parameters</param>
        public LoggingArgs(string namespaceValue, string classValue, string functionValue, List<Para> parameters)
        {
            Namespace = namespaceValue;
            Class = classValue;
            Function = functionValue;
            Parameters = parameters;
            DateOfEntry = DateTime.Now;
        }

        /// <summary>
        ///     Create a new LogEntry
        /// </summary>
        /// <param name="namespaceValue">Namespace</param>
        /// <param name="classValue">Class</param>
        /// <param name="functionValue">Function</param>
        /// <param name="parameter">Parameter</param>
        public LoggingArgs(string namespaceValue, string classValue, string functionValue, Para parameter)
        {
            Namespace = namespaceValue;
            Class = classValue;
            Function = functionValue;
            Parameters = new List<Para> { parameter };
            DateOfEntry = DateTime.Now;
        }

        /// <summary>
        ///     Create a new LogEntry
        /// </summary>
        /// <param name="namespaceValue">Namespace</param>
        /// <param name="classValue">Class</param>
        /// <param name="functionValue">Function</param>
        public LoggingArgs(string namespaceValue, string classValue, string functionValue)
        {
            Namespace = namespaceValue;
            Class = classValue;
            Function = functionValue;
            Parameters = new List<Para> { new Para("", "") };
            DateOfEntry = DateTime.Now;
        }

        /// <summary>
        ///     The Namespace of the Caller
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        ///     The Class of the Caller
        /// </summary>
        public string Class { get; set; }

        /// <summary>
        ///     The Method of the Caller
        /// </summary>
        public string Function { get; set; }

        /// <summary>
        ///     The Parameters for the Function
        /// </summary>
        public List<Para> Parameters { get; set; }

        /// <summary>
        ///     Datum des Eintrags
        /// </summary>
        /// <returns>Datum und Zeit</returns>
        public DateTime DateOfEntry { get; }

        /// <summary>
        ///     Create a string from the LogEntry
        /// </summary>
        /// <returns>LogEntry as string</returns>
        public override string ToString()
        {
            var p = "";
            foreach (var para in Parameters)
                if (!string.IsNullOrEmpty(para.Value))
                    p += para.Name + ":\"" + para.Value + "\"" + " ,";

            if (p.EndsWith(",")) p = p.Substring(0, p.Length - 1).Trim();

            return DateOfEntry + "\t" + Namespace + "\t" + "[" + Class + "]" + "\t" + "(" + Function + ")" + "\t" + p;
        }
    }

    /// <summary>
    ///     The parameter for the Function
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    public class Para
    {
        /// <summary>
        ///     Create a new Parameter
        /// </summary>
        /// <param name="name">Parameter Name</param>
        /// <param name="value">Parameter Value</param>
        public Para(string name, string value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        ///     Parameter Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Parameter Value
        /// </summary>
        public string Value { get; set; }
    }
}