using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Coordinates
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("coordinates", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Coordinates
    {
        /// <summary>
        ///     Latitude
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        ///     Longitude
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }
    }
}