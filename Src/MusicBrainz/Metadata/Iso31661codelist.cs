using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Iso31661codelist
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("iso-3166-1-code-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Iso31661codelist
    {
        /// <summary>
        ///     Iso 3166 1 Code
        /// </summary>
        [XmlElement("iso-3166-1-code")]
        public List<string> Iso31661code { get; set; }
    }
}