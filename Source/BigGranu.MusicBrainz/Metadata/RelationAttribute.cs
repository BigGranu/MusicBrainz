using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     RelationAttribute
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("relationAttribute")]
    public class RelationAttribute
    {
        /// <summary>
        ///     Value
        /// </summary>
        [XmlAttribute("value")]
        public string Value { get; set; }

        /// <summary>
        ///     Creditedas
        /// </summary>
        [XmlAttribute("credited-as")]
        public string Creditedas { get; set; }

        /// <summary>
        ///     Text
        /// </summary>
        [XmlText]
        public List<string> Text { get; set; }
    }
}