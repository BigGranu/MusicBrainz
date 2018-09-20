using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Lifespan
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("life-span", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Lifespan
    {
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
    }
}