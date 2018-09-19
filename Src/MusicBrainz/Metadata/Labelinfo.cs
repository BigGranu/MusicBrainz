using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Labelinfo
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("label-info", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Labelinfo
    {
        /// <summary>
        ///     Catalog Number
        /// </summary>
        [XmlElement("catalog-number")]
        public string Catalognumber { get; set; }

        /// <summary>
        ///     Label
        /// </summary>
        [XmlElement("label")]
        public Label Label { get; set; }
    }
}