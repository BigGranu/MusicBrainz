using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Secondarytypelist
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("secondary-type-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public class Secondarytypelist
    {
        /// <summary>
        ///     Secondarytype
        /// </summary>
        [XmlElement("secondary-type")]
        public List<Secondarytype> Secondarytype { get; set; }
    }
}