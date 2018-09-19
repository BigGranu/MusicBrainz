using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Artistcredit
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("artist-credit", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Artistcredit
    {
        /// <summary>
        ///     Namecredit
        /// </summary>
        [XmlElement("name-credit")]
        public List<Namecredit> Namecredit { get; set; }
    }
}