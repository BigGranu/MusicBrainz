using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Editor
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("editor", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Editor
    {
        /// <summary>
        ///     Name
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Membersince
        /// </summary>
        [XmlElement("member-since")]
        public string Membersince { get; set; }

        /// <summary>
        ///     Privs
        /// </summary>
        [XmlElement("privs", DataType = "nonNegativeInteger")]
        public string Privs { get; set; }

        /// <summary>
        ///     Gender
        /// </summary>
        [XmlElement("gender")]
        public Gender Gender { get; set; }

        /// <summary>
        ///     Age
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }

        /// <summary>
        ///     Homepage
        /// </summary>
        [XmlElement("homepage", DataType = "anyURI")]
        public string Homepage { get; set; }

        /// <summary>
        ///     Bio
        /// </summary>
        [XmlElement("bio")]
        public string Bio { get; set; }

        /// <summary>
        ///     Area
        /// </summary>
        [XmlElement("area")]
        public Area Area { get; set; }

        /// <summary>
        ///     Languagelist
        /// </summary>
        [XmlElement("language-list")]
        public Languagelist Languagelist { get; set; }

        /// <summary>
        ///     Editinformation
        /// </summary>
        [XmlElement("edit-information")]
        public Editinformation Editinformation { get; set; }

        /// <summary>
        ///     Id
        /// </summary>
        [XmlAttribute("id", DataType = "nonNegativeInteger")]
        public string Id { get; set; }
    }
}