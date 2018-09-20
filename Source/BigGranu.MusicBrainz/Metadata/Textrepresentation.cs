using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Textrepresentation
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("text-representation", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Textrepresentation
    {
        /// <summary>
        ///     Language
        /// </summary>
        [XmlElement("language")]
        public string Language { get; set; }

        /// <summary>
        ///     Script
        /// </summary>
        [XmlElement("script")]
        public string Script { get; set; }
    }
}