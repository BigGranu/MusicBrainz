using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Collection
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("collection", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Collection
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
        ///     Editor
        /// </summary>
        [XmlElement("editor")]
        public string Editor { get; set; }

        /// <summary>
        ///     Arealist
        /// </summary>
        [XmlElement("area-list")]
        public Arealist Arealist { get; set; }

        /// <summary>
        ///     Artistlist
        /// </summary>
        [XmlElement("artist-list")]
        public Artistlist Artistlist { get; set; }

        /// <summary>
        ///     Eventlist
        /// </summary>
        [XmlElement("event-list")]
        public Eventlist Eventlist { get; set; }

        /// <summary>
        ///     Instrumentlist
        /// </summary>
        [XmlElement("instrument-list")]
        public Instrumentlist Instrumentlist { get; set; }

        /// <summary>
        ///     Labellist
        /// </summary>
        [XmlElement("label-list")]
        public Labellist Labellist { get; set; }

        /// <summary>
        ///     Placelist
        /// </summary>
        [XmlElement("place-list")]
        public Placelist Placelist { get; set; }

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
        ///     Serieslist
        /// </summary>
        [XmlElement("series-list")]
        public Serieslist Serieslist { get; set; }

        /// <summary>
        ///     Worklist
        /// </summary>
        [XmlElement("work-list")]
        public Worklist Worklist { get; set; }

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

        /// <summary>
        ///     Entitytype
        /// </summary>
        [XmlAttribute("entity-type")]
        public string Entitytype { get; set; }
    }
}