using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Labellist
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("label-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Labellist
    {
        /// <summary>
        ///     Collection of Informations about the last Call
        /// </summary>
        public ApiStatus ApiStatus { get; set; }

        /// <summary>
        ///     Label
        /// </summary>
        [XmlElement("label")]
        public List<Label> Label { get; set; }

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