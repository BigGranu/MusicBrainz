using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Series
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("series", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Series
    {
        /// <summary>
        ///     Collection of Informations about the last Call
        /// </summary>
        public ApiStatus ApiStatus { get; set; }

        /// <summary>
        ///     Name
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        ///     Disambiguation
        /// </summary>
        [XmlElement("disambiguation")]
        public string Disambiguation { get; set; }

        /// <summary>
        ///     Orderingattribute
        /// </summary>
        [XmlElement("ordering-attribute")]
        public string Orderingattribute { get; set; }

        /// <summary>
        ///     Annotation
        /// </summary>
        [XmlElement("annotation")]
        public Annotation Annotation { get; set; }

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