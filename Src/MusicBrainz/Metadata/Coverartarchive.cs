using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Coverartarchive
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("cover-art-archive", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Coverartarchive
    {
        /// <summary>
        ///     Artwork
        /// </summary>
        [XmlElement("artwork")]
        public Artwork Artwork { get; set; }

        /// <summary>
        ///     Count
        /// </summary>
        [XmlElement("count", DataType = "nonNegativeInteger")]
        public string Count { get; set; }

        /// <summary>
        ///     Front
        /// </summary>
        [XmlElement("front")]
        public Front Front { get; set; }

        /// <summary>
        ///     Back
        /// </summary>
        [XmlElement("back")]
        public Back Back { get; set; }

        /// <summary>
        ///     Darkened
        /// </summary>
        [XmlElement("darkened")]
        public Darkened Darkened { get; set; }
    }
}