using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Arealist
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("area-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Arealist
    {
        /// <summary>
        ///     Collection of Informations about the last Call
        /// </summary>
        public ApiStatus ApiStatus { get; set; }

        /// <summary>
        ///     Area
        /// </summary>
        [XmlElement("area")]
        public List<Area> Area { get; set; }

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