using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Editinformation
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("edit-information", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Editinformation
    {
        /// <summary>
        ///     Edits Accepted
        /// </summary>
        [XmlElement("edits-accepted")]
        public string Editsaccepted { get; set; }

        /// <summary>
        ///     Editsrejected
        /// </summary>
        [XmlElement("edits-rejected")]
        public string Editsrejected { get; set; }

        /// <summary>
        ///     Autoeditsaccepted
        /// </summary>
        [XmlElement("auto-edits-accepted")]
        public string Autoeditsaccepted { get; set; }

        /// <summary>
        ///     Editsfailed
        /// </summary>
        [XmlElement("edits-failed")]
        public string Editsfailed { get; set; }
    }
}