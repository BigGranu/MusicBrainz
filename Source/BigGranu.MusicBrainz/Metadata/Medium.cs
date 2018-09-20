using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Medium
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("medium", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Medium
    {
        /// <summary>
        ///     Title
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        ///     Position
        /// </summary>
        [XmlElement("position", DataType = "nonNegativeInteger")]
        public string Position { get; set; }

        /// <summary>
        ///     Format
        /// </summary>
        [XmlElement("format")]
        public Format Format { get; set; }

        /// <summary>
        ///     Disclist
        /// </summary>
        [XmlElement("disc-list")]
        public Disclist Disclist { get; set; }

        /// <summary>
        ///     Pregap
        /// </summary>
        [XmlElement("pregap")]
        public TrackData Pregap { get; set; }

        /// <summary>
        ///     Tracklist
        /// </summary>
        [XmlElement("track-list")]
        public MediumTracklist Tracklist { get; set; }

        /// <summary>
        ///     Datatracklist
        /// </summary>
        [XmlElement("data-track-list")]
        public Datatracklist Datatracklist { get; set; }
    }
}