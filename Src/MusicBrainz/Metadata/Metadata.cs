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
using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Metadata based of the <a href="https://github.com/metabrainz/mmd-schema/blob/master/schema/musicbrainz_mmd-2.0.rng" target="_blank">musicbrainz_mmd-2.0.rng</a>
    /// </summary>
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         Full Rework
    ///     </revision>
    /// </revisionHistory>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("metadata", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Metadata
    {
        /// <summary>
        ///     Collection of Informations about the last Call
        /// </summary>
        public ApiStatus ApiStatus { get; set; }

        /// <summary>
        ///     Artist
        /// </summary>
        [XmlElement("artist")]
        public Artist Artist { get; set; }

        /// <summary>
        ///     Release
        /// </summary>
        [XmlElement("release")]
        public Release Release { get; set; }

        /// <summary>
        ///     Releasegroup
        /// </summary>
        [XmlElement("release-group")]
        public Releasegroup Releasegroup { get; set; }

        /// <summary>
        ///     Recording
        /// </summary>
        [XmlElement("recording")]
        public Recording Recording { get; set; }

        /// <summary>
        ///     Label
        /// </summary>
        [XmlElement("label")]
        public Label Label { get; set; }

        /// <summary>
        ///     Work
        /// </summary>
        [XmlElement("work")]
        public Work Work { get; set; }

        /// <summary>
        ///     Area
        /// </summary>
        [XmlElement("area")]
        public Area Area { get; set; }

        /// <summary>
        ///     Place
        /// </summary>
        [XmlElement("place")]
        public Place Place { get; set; }

        /// <summary>
        ///     Instrument
        /// </summary>
        [XmlElement("instrument")]
        public Instrument Instrument { get; set; }

        /// <summary>
        ///     Series
        /// </summary>
        [XmlElement("series")]
        public Series Series { get; set; }

        /// <summary>
        ///     Event
        /// </summary>
        [XmlElement("event")]
        public Event Event { get; set; }

        /// <summary>
        ///     Url
        /// </summary>
        [XmlElement("url")]
        public Url Url { get; set; }

        /// <summary>
        ///     Puid
        /// </summary>
        [XmlElement("puid")]
        public Puid Puid { get; set; }

        /// <summary>
        ///     Isrc
        /// </summary>
        [XmlElement("isrc")]
        public Isrc Isrc { get; set; }

        /// <summary>
        ///     Disc
        /// </summary>
        [XmlElement("disc")]
        public Disc Disc { get; set; }

        /// <summary>
        ///     Rating
        /// </summary>
        [XmlElement("rating")]
        public Rating Rating { get; set; }

        /// <summary>
        ///     Userrating
        /// </summary>
        [XmlElement("user-rating")]
        public string Userrating { get; set; }

        /// <summary>
        ///     Collection
        /// </summary>
        [XmlElement("collection")]
        public Collection Collection { get; set; }

        /// <summary>
        ///     Editor
        /// </summary>
        [XmlElement("editor")]
        public Editor Editor { get; set; }

        /// <summary>
        ///     Artistlist
        /// </summary>
        [XmlElement("artist-list")]
        public Artistlist Artistlist { get; set; }

        /// <summary>
        ///     Releaselist
        /// </summary>
        [XmlElement("release-list")]
        public Releaselist Releaselist { get; set; }

        /// <summary>
        ///     Releasegrouplist
        /// </summary>
        [XmlElement("release-group-list")]
        public Releasegrouplist Releasegrouplist { get; set; }

        /// <summary>
        ///     Recordinglist
        /// </summary>
        [XmlElement("recording-list")]
        public Recordinglist Recordinglist { get; set; }

        /// <summary>
        ///     Labellist
        /// </summary>
        [XmlElement("label-list")]
        public Labellist Labellist { get; set; }

        /// <summary>
        ///     Worklist
        /// </summary>
        [XmlElement("work-list")]
        public Worklist Worklist { get; set; }

        /// <summary>
        ///     Arealist
        /// </summary>
        [XmlElement("area-list")]
        public Arealist Arealist { get; set; }

        /// <summary>
        ///     Placelist
        /// </summary>
        [XmlElement("place-list")]
        public Placelist Placelist { get; set; }

        /// <summary>
        ///     Instrumentlist
        /// </summary>
        [XmlElement("instrument-list")]
        public Instrumentlist Instrumentlist { get; set; }

        /// <summary>
        ///     Serieslist
        /// </summary>
        [XmlElement("series-list")]
        public Serieslist Serieslist { get; set; }

        /// <summary>
        ///     Eventlist
        /// </summary>
        [XmlElement("event-list")]
        public Eventlist Eventlist { get; set; }

        /// <summary>
        ///     Urllist
        /// </summary>
        [XmlElement("url-list")]
        public Urllist Urllist { get; set; }

        /// <summary>
        ///     Isrclist
        /// </summary>
        [XmlElement("isrc-list")]
        public Isrclist Isrclist { get; set; }

        /// <summary>
        ///     Annotationlist
        /// </summary>
        [XmlElement("annotation-list")]
        public Annotationlist Annotationlist { get; set; }

        /// <summary>
        ///     Cdstublist
        /// </summary>
        [XmlElement("cdstub-list")]
        public Cdstublist Cdstublist { get; set; }

        /// <summary>
        ///     Freedbdisclist
        /// </summary>
        [XmlElement("freedb-disc-list")]
        public Freedbdisclist Freedbdisclist { get; set; }

        /// <summary>
        ///     Taglist
        /// </summary>
        [XmlElement("tag-list")]
        public Taglist Taglist { get; set; }

        /// <summary>
        ///     Usertaglist
        /// </summary>
        [XmlElement("user-tag-list")]
        public Usertaglist Usertaglist { get; set; }

        /// <summary>
        ///     Genrelist
        /// </summary>
        [XmlElement("genre-list")]
        public Genrelist Genrelist { get; set; }

        /// <summary>
        ///     Usergenrelist
        /// </summary>
        [XmlElement("user-genre-list")]
        public Usergenrelist Usergenrelist { get; set; }

        /// <summary>
        ///     Collectionlist
        /// </summary>
        [XmlElement("collection-list")]
        public Collectionlist Collectionlist { get; set; }

        /// <summary>
        ///     Editorlist
        /// </summary>
        [XmlElement("editor-list")]
        public Editorlist Editorlist { get; set; }

        /// <summary>
        ///     Entitylist
        /// </summary>
        [XmlElement("entity-list")]
        public Entitylist Entitylist { get; set; }

        /// <summary>
        ///     Generator
        /// </summary>
        [XmlAttribute("generator", DataType = "anyURI")]
        public string Generator { get; set; }

        /// <summary>
        ///     Created
        /// </summary>
        [XmlAttribute("created")]
        public DateTime Created { get; set; }
    }
}