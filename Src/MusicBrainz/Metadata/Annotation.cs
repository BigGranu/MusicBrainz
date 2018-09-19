using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Annotation
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("annotation", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Annotation
    {
        /// <summary>
        ///     Collection of Informations about the last Call
        /// </summary>
        public ApiStatus ApiStatus { get; set; }

        /// <summary>
        ///     Entity
        /// </summary>
        [XmlElement("entity", DataType = "anyURI")]
        public string Entity { get; set; }

        /// <summary>
        ///     Name
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Text
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        ///     Type
        /// </summary>
        [XmlAttribute("type")]
        public string Type { get; set; }
    }
}