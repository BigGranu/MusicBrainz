using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Isrclist
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("isrc-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Isrclist
    {
        /// <summary>
        ///     Isrc
        /// </summary>
        [XmlElement("isrc")]
        public List<Isrc> Isrc { get; set; }

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