using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Artist
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("artist", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Artist
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
        ///     Sortname
        /// </summary>
        [XmlElement("sort-name")]
        public string Sortname { get; set; }

        /// <summary>
        ///     Gender
        /// </summary>
        [XmlElement("gender")]
        public Gender Gender { get; set; }

        /// <summary>
        ///     Country
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        ///     Area
        /// </summary>
        [XmlElement("area")]
        public Area Area { get; set; }

        /// <summary>
        ///     Beginarea
        /// </summary>
        [XmlElement("begin-area")]
        public Area Beginarea { get; set; }

        /// <summary>
        ///     Endarea
        /// </summary>
        [XmlElement("end-area")]
        public Area Endarea { get; set; }

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
        ///     Ipi
        /// </summary>
        [XmlElement("ipi")]
        public string Ipi { get; set; }

        /// <summary>
        ///     Ipilist
        /// </summary>
        [XmlArray("ipi-list")]
        [XmlArrayItem("ipi")]
        public List<string> Ipilist { get; set; }

        /// <summary>
        ///     Isnilist
        /// </summary>
        [XmlArray("isni-list")]
        [XmlArrayItem("isni")]
        public List<string> Isnilist { get; set; }

        /// <summary>
        ///     Lifespan
        /// </summary>
        [XmlElement("life-span")]
        public Lifespan Lifespan { get; set; }

        /// <summary>
        ///     Aliaslist
        /// </summary>
        [XmlElement("alias-list")]
        public Aliaslist Aliaslist { get; set; }

        /// <summary>
        ///     Recordinglist
        /// </summary>
        [XmlElement("recording-list")]
        public Recordinglist Recordinglist { get; set; }

        /// <summary>
        ///     Releaselist
        /// </summary>
        [XmlElement("release-list")]
        public Releaselist Releaselist { get; set; }

        /// <summary>
        ///     Releasegrouplist
        /// </summary>
        [XmlElement("release-group-list")]
        public Releasegrouplist Releasegrouplist { get; set; }

        /// <summary>
        ///     Worklist
        /// </summary>
        [XmlElement("work-list")]
        public Worklist Worklist { get; set; }

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