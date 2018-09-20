using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Iso31662codelist
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("iso-3166-2-code-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Iso31662codelist
    {
        /// <summary>
        ///     Iso 3166 2 Code
        /// </summary>
        [XmlElement("iso-3166-2-code")]
        public List<string> Iso31662code { get; set; }
    }
}