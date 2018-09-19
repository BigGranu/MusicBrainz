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

namespace MusicBrainz.Events
{
    /// <summary>
    ///     Handler for Exceptions
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    public class Exceptions
    {
        /// <summary>
        ///     Eventhandler
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArg</param>
        public delegate void EventHandler(object sender, ExceptionsArgs e);

        private static Exceptions _instance;

        /// <summary>
        ///     Create new Exceptions
        /// </summary>
        public Exceptions()
        {
            _instance = this;
        }

        /// <summary>
        ///     Instance of the Exceptions
        /// </summary>
        public static Exceptions Instance => _instance ?? (_instance = new Exceptions());

        /// <summary>
        ///     EventHandler for Exceptions
        /// </summary>
        public event EventHandler ExceptionTriggered;

        /// <summary>
        ///     Is an Error occurred
        /// </summary>
        internal bool ErrorOccurred;

        /// <summary>
        ///     Current Exception
        /// </summary>
        internal string Message { get; set; } = string.Empty;

        /// <summary>
        ///     Current Exception
        /// </summary>
        internal Exception Exception { get; set; }

        /// <summary>
        ///     Rise a new Exception
        /// </summary>
        /// <param name="ex">The Exception</param>
        internal void NewException(Exception ex)
        {
            Exception = ex;
            Message = ex.Message;
            ErrorOccurred = true;
            var log = new ExceptionsArgs { Exception = ex, Message = ex.Message };
            ExceptionTriggered?.Invoke(new object(), log);
        }
    }

    /// <summary>
    ///     Exception Eventargument
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    public class ExceptionsArgs : EventArgs
    {
        /// <summary>
        ///     The Full Exception
        /// </summary>
        public Exception Exception { get; set; } = new Exception();        
        
        /// <summary>
        ///     The Exceptionmessage
        /// </summary>
        public string Message { get; set; } = string.Empty;
    }
}