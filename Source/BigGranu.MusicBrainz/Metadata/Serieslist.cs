using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Serieslist
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("series-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Serieslist
    {
        /// <summary>
        ///     Collection of Informations about the last Call
        /// </summary>
        public ApiStatus ApiStatus { get; set; }

        /// <summary>
        ///     Series
        /// </summary>
        [XmlElement("series")]
        public List<Series> Series { get; set; }

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