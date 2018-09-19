using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Def_trackdata
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("pregap", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class TrackData
    {
        /// <summary>
        ///     Position
        /// </summary>
        [XmlElement("position", DataType = "nonNegativeInteger")]
        public string Position { get; set; }

        /// <summary>
        ///     Number
        /// </summary>
        [XmlElement("number")]
        public string Number { get; set; }

        /// <summary>
        ///     Title
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        ///     Length
        /// </summary>
        [XmlElement("length", DataType = "nonNegativeInteger")]
        public string Length { get; set; }

        /// <summary>
        ///     Artistcredit
        /// </summary>
        [XmlArray("artist-credit")]
        [XmlArrayItem("name-credit")]
        public List<Namecredit> Artistcredit { get; set; }

        /// <summary>
        ///     Recording
        /// </summary>
        [XmlElement("recording")]
        public Recording Recording { get; set; }

        /// <summary>
        ///     Id
        /// </summary>
        [XmlAttribute("id", DataType = "anyURI")]
        public string Id { get; set; }
    }
}