using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Freedbdisc
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("freedb-disc", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Freedbdisc
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
        ///     Category
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        ///     Year
        /// </summary>
        [XmlElement("year")]
        public string Year { get; set; }

        /// <summary>
        ///     Tracklist
        /// </summary>
        [XmlElement("track-list")]
        public CdstubTracklist Tracklist { get; set; }

        /// <summary>
        ///     Id
        /// </summary>
        [XmlAttribute("id")]
        public string Id { get; set; }
    }
}