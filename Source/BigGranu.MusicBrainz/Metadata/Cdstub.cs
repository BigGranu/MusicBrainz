using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Cdstub
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("cdstub", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Cdstub
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
        ///     Barcode
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        ///     Comment
        /// </summary>
        [XmlElement("comment")]
        public string Comment { get; set; }

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