using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Release
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("release", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Release
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
        ///     Status
        /// </summary>
        [XmlElement("status")]
        public Status Status { get; set; }

        /// <summary>
        ///     Quality
        /// </summary>
        [XmlElement("quality")]
        public Quality Quality { get; set; }

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
        ///     Packaging
        /// </summary>
        [XmlElement("packaging")]
        public string Packaging { get; set; }

        /// <summary>
        ///     Textrepresentation
        /// </summary>
        [XmlElement("text-representation")]
        public Textrepresentation Textrepresentation { get; set; }

        /// <summary>
        ///     Artistcredit
        /// </summary>
        [XmlArray("artist-credit")]
        [XmlArrayItem("name-credit")]
        public List<Namecredit> Artistcredit { get; set; }

        /// <summary>
        ///     Aliaslist
        /// </summary>
        [XmlElement("alias-list")]
        public Aliaslist Aliaslist { get; set; }

        /// <summary>
        ///     Releasegroup
        /// </summary>
        [XmlElement("release-group")]
        public Releasegroup Releasegroup { get; set; }

        /// <summary>
        ///     Date
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        ///     Country
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        ///     Releaseeventlist
        /// </summary>
        [XmlElement("release-event-list")]
        public Releaseeventlist Releaseeventlist { get; set; }

        /// <summary>
        ///     Barcode
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        ///     Asin
        /// </summary>
        [XmlElement("asin")]
        public string Asin { get; set; }

        /// <summary>
        ///     Coverartarchive
        /// </summary>
        [XmlElement("cover-art-archive")]
        public Coverartarchive Coverartarchive { get; set; }

        /// <summary>
        ///     Labelinfolist
        /// </summary>
        [XmlElement("label-info-list")]
        public Labelinfolist Labelinfolist { get; set; }

        /// <summary>
        ///     Mediumlist
        /// </summary>
        [XmlElement("medium-list")]
        public Mediumlist Mediumlist { get; set; }

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
        ///     Collectionlist
        /// </summary>
        [XmlElement("collection-list")]
        public Collectionlist Collectionlist { get; set; }

        /// <summary>
        ///     Id
        /// </summary>
        [XmlAttribute("id", DataType = "anyURI")]
        public string Id { get; set; }
    }
}