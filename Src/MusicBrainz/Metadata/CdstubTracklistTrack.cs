using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     CdstubTracklistTrack
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("cdstubTracklistTrack")]
    public class CdstubTracklistTrack
    {
        /// <summary>
        ///     Title
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        ///     Artist
        /// </summary>
        [XmlElement("artist")]
        public string Artist { get; set; }

        /// <summary>
        ///     Length
        /// </summary>
        [XmlElement("length", DataType = "nonNegativeInteger")]
        public string Length { get; set; }
    }
}