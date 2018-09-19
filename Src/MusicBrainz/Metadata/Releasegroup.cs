using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Releasegroup
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("release-group", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Releasegroup
    {
        /// <summary>
        ///     Collection of Informations about the last Call
        /// </summary>
        public ApiStatus ApiStatus { get; set; }

        /// <summary>
        ///     Title
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        ///     Annotation
        /// </summary>
        [XmlElement("annotation")]
        public Annotation Annotation { get; set; }

        /// <summary>
        ///     Disambiguation
        /// </summary>
        [XmlElement("disambiguation")]
        public string Disambiguation { get; set; }

        /// <summary>
        ///     Firstreleasedate
        /// </summary>
        [XmlElement("first-release-date")]
        public string Firstreleasedate { get; set; }

        /// <summary>
        ///     Primarytype
        /// </summary>
        [XmlElement("primary-type")]
        public Primarytype Primarytype { get; set; }

        /// <summary>
        ///     Secondarytypelist
        /// </summary>
        [XmlArray("secondary-type-list")]
        [XmlArrayItem("secondary-type")]
        public List<Secondarytype> Secondarytypelist { get; set; }

        /// <summary>
        ///     Artistcredit
        /// </summary>
        [XmlArray("artist-credit")]
        [XmlArrayItem("name-credit")]
        public List<Namecredit> Artistcredit { get; set; }

        /// <summary>
        ///     Releaselist
        /// </summary>
        [XmlElement("release-list")]
        public Releaselist Releaselist { get; set; }

        /// <summary>
        ///     Aliaslist
        /// </summary>
        [XmlElement("alias-list")]
        public Aliaslist Aliaslist { get; set; }

        /// <summary>
        ///     Relationlist
        /// </summary>
        [XmlElement("relation-list")]
        public List<Relationlist> Relationlist { get; set; }

        /// <summary>
        ///     Taglist
        /// </summary>
        [XmlElement("tag-list")]
        public Taglist Taglist { get; set; }

        /// <summary>
        ///     Usertaglist
        /// </summary>
        [XmlElement("user-tag-list")]
        public Usertaglist Usertaglist { get; set; }

        /// <summary>
        ///     Genrelist
        /// </summary>
        [XmlElement("genre-list")]
        public Genrelist Genrelist { get; set; }

        /// <summary>
        ///     Usergenrelist
        /// </summary>
        [XmlElement("user-genre-list")]
        public Usergenrelist Usergenrelist { get; set; }

        /// <summary>
        ///     Rating
        /// </summary>
        [XmlElement("rating")]
        public Rating Rating { get; set; }

        /// <summary>
        ///     Userrating
        /// </summary>
        [XmlElement("user-rating")]
        public string Userrating { get; set; }

        /// <summary>
        ///     Id
        /// </summary>
        [XmlAttribute("id", DataType = "anyURI")]
        public string Id { get; set; }

        /// <summary>
        ///     Type
        /// </summary>
        [XmlAttribute("type", DataType = "anyURI")]
        public string Type { get; set; }

        /// <summary>
        ///     Typeid
        /// </summary>
        [XmlAttribute("type-id")]
        public string Typeid { get; set; }
    }
}