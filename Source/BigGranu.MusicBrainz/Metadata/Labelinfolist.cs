using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Labelinfolist
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("label-info-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Labelinfolist
    {
        /// <summary>
        ///     Labelinfo
        /// </summary>
        [XmlElement("label-info")]
        public List<Labelinfo> Labelinfo { get; set; }

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