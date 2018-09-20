using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Offset
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("offset", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Offset
    {
        /// <summary>
        ///     Position
        /// </summary>
        [XmlAttribute("position", DataType = "nonNegativeInteger")]
        public string Position { get; set; }

        /// <summary>
        ///     Value
        /// </summary>
        [XmlText(DataType = "nonNegativeInteger")]
        public string Value { get; set; }
    }
}