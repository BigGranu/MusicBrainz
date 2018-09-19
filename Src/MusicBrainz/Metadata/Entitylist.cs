using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Entitylist
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("entity-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Entitylist
    {
        /// <summary>
        ///     Artist
        /// </summary>
        [XmlElement("artist")]
        public List<Artist> Artist { get; set; }

        /// <summary>
        ///     Release
        /// </summary>
        [XmlElement("release")]
        public List<Release> Release { get; set; }

        /// <summary>
        ///     Releasegroup
        /// </summary>
        [XmlElement("release-group")]
        public List<Releasegroup> Releasegroup { get; set; }

        /// <summary>
        ///     Recording
        /// </summary>
        [XmlElement("recording")]
        public List<Recording> Recording { get; set; }

        /// <summary>
        ///     Label
        /// </summary>
        [XmlElement("label")]
        public List<Label> Label { get; set; }

        /// <summary>
        ///     Work
        /// </summary>
        [XmlElement("work")]
        public List<Work> Work { get; set; }

        /// <summary>
        ///     Area
        /// </summary>
        [XmlElement("area")]
        public List<Area> Area { get; set; }

        /// <summary>
        ///     Place
        /// </summary>
        [XmlElement("place")]
        public List<Place> Place { get; set; }

        /// <summary>
        ///     Instrument
        /// </summary>
        [XmlElement("instrument")]
        public List<Instrument> Instrument { get; set; }

        /// <summary>
        ///     Series
        /// </summary>
        [XmlElement("series")]
        public List<Series> Series { get; set; }

        /// <summary>
        ///     Event
        /// </summary>
        [XmlElement("event")]
        public List<Event> Event { get; set; }

        /// <summary>
        ///     Count
        /// </summary>
        [XmlAttribute("count", DataType = "nonNegativeInteger")]
        public string Count { get; set; }

        /// <summary>
        ///     Offset
        /// </summary>
        [XmlAttribute("offset", DataType = "nonNegativeInteger")]
        public string Offset { get; set; }
    }
}