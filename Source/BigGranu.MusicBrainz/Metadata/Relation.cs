using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Relation
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("relation", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Relation
    {
        /// <summary>
        ///     Target
        /// </summary>
        [XmlElement("target")]
        public Target Target { get; set; }

        /// <summary>
        ///     Orderingkey
        /// </summary>
        [XmlElement("ordering-key")]
        public string Orderingkey { get; set; }

        /// <summary>
        ///     Direction
        /// </summary>
        [XmlElement("direction")]
        public Direction Direction { get; set; }

        /// <summary>
        ///     Attributelist
        /// </summary>
        [XmlArray("attribute-list")]
        [XmlArrayItem("attribute")]
        public List<RelationAttribute> Attributelist { get; set; }

        /// <summary>
        ///     Begin
        /// </summary>
        [XmlElement("begin")]
        public string Begin { get; set; }

        /// <summary>
        ///     End
        /// </summary>
        [XmlElement("end")]
        public string End { get; set; }

        /// <summary>
        ///     Ended
        /// </summary>
        [XmlElement("ended")]
        public Ended Ended { get; set; }

        /// <summary>
        ///     Item
        /// </summary>
        [XmlAnyElement]
        [XmlElement("area", typeof(Area))]
        [XmlElement("artist", typeof(Artist))]
        [XmlElement("event", typeof(Event))]
        [XmlElement("instrument", typeof(Instrument))]
        [XmlElement("label", typeof(Label))]
        [XmlElement("place", typeof(Place))]
        [XmlElement("recording", typeof(Recording))]
        [XmlElement("release", typeof(Release))]
        [XmlElement("release-group", typeof(Releasegroup))]
        [XmlElement("series", typeof(Series))]
        [XmlElement("work", typeof(Work))]
        public object Item { get; set; }

        /// <summary>
        ///     Sourcecredit
        /// </summary>
        [XmlElement("source-credit")]
        public string Sourcecredit { get; set; }

        /// <summary>
        ///     Targetcredit
        /// </summary>
        [XmlElement("target-credit")]
        public string Targetcredit { get; set; }

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