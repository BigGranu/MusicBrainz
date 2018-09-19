using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Ipilist
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("ipi-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Ipilist
    {
        /// <summary>
        ///     Ipi
        /// </summary>
        [XmlElement("ipi")]
        public List<string> Ipi { get; set; }
    }
}