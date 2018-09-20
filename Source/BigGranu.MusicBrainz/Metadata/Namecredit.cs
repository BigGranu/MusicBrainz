using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Namecredit
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("name-credit", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Namecredit
    {
        /// <summary>
        ///     Name
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Artist
        /// </summary>
        [XmlElement("artist")]
        public Artist Artist { get; set; }

        /// <summary>
        ///     Joinphrase
        /// </summary>
        [XmlAttribute("joinphrase")]
        public string Joinphrase { get; set; }
    }
}