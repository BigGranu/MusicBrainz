using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Rating
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("rating", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Rating
    {
        /// <summary>
        ///     Votes Count
        /// </summary>
        [XmlAttribute("votes-count")]
        public string Votescount { get; set; }

        /// <summary>
        ///     Value
        /// </summary>
        [XmlText]
        public float Value { get; set; }
    }
}