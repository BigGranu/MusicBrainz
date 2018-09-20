using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Puid
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("puid", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Puid
    {
        /// <summary>
        ///     Recording List
        /// </summary>
        [XmlElement("recording-list")]
        public Recordinglist Recordinglist { get; set; }

        /// <summary>
        ///     Id
        /// </summary>
        [XmlAttribute("id")]
        public string Id { get; set; }
    }
}