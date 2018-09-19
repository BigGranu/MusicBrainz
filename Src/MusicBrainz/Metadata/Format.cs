using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Format
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("format", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Format
    {
        /// <summary>
        ///     Id
        /// </summary>
        [XmlAttribute("id")]
        public string Id { get; set; }

        /// <summary>
        ///     Text
        /// </summary>
        [XmlText]
        public List<string> Text { get; set; }
    }
}