using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Isrc
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("isrc", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Isrc
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