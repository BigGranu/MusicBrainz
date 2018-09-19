using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Releaseevent
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("release-event", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Releaseevent
    {
        /// <summary>
        ///     Date
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        ///     Area
        /// </summary>
        [XmlElement("area")]
        public Area Area { get; set; }
    }
}