using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Alias
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("alias", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Alias
    {
        /// <summary>
        ///     Locale
        /// </summary>
        [XmlAttribute("locale")]
        public string Locale { get; set; }

        /// <summary>
        ///     Sortname
        /// </summary>
        [XmlAttribute("sort-name")]
        public string Sortname { get; set; }

        /// <summary>
        ///     Type
        /// </summary>
        [XmlAttribute("type")]
        public string Type { get; set; }

        /// <summary>
        ///     Typeid
        /// </summary>
        [XmlAttribute("type-id")]
        public string Typeid { get; set; }

        /// <summary>
        ///     Primary
        /// </summary>
        [XmlAttribute("primary")]
        public string Primary { get; set; }

        /// <summary>
        ///     Begindate
        /// </summary>
        [XmlAttribute("begin-date")]
        public string Begindate { get; set; }

        /// <summary>
        ///     Enddate
        /// </summary>
        [XmlAttribute("end-date")]
        public string Enddate { get; set; }

        /// <summary>
        ///     Text
        /// </summary>
        [XmlText]
        public List<string> Text { get; set; }
    }
}