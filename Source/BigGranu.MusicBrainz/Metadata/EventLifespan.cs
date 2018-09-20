using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     EventLifespan
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("eventLifespan")]
    public class EventLifespan
    {
        /// <summary>
        ///     Begin
        /// </summary>
        [XmlElement("begin")]
        public string Begin { get; set; }

        /// <summary>
        ///     End
        /// </summary>
        [XmlElement("end")]
        public string End { get; set; }
    }
}