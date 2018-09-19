using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Target
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("target", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Target
    {
        /// <summary>
        ///     Id
        /// </summary>
        [XmlAttribute("id", DataType = "anyURI")]
        public string Id { get; set; }

        /// <summary>
        ///     Value
        /// </summary>
        [XmlText(DataType = "anyURI")]
        public string Value { get; set; }
    }
}