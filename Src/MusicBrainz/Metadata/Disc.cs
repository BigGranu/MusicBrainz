using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Disc
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("disc", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Disc
    {
        /// <summary>
        ///     Sectors
        /// </summary>
        [XmlElement("sectors", DataType = "nonNegativeInteger")]
        public string Sectors { get; set; }

        /// <summary>
        ///     Offsetlist
        /// </summary>
        [XmlElement("offset-list")]
        public Offsetlist Offsetlist { get; set; }

        /// <summary>
        ///     Releaselist
        /// </summary>
        [XmlElement("release-list")]
        public Releaselist Releaselist { get; set; }

        /// <summary>
        ///     Id
        /// </summary>
        [XmlAttribute("id")]
        public string Id { get; set; }
    }
}