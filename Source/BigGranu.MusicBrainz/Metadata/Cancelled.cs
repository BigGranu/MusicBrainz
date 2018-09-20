using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Cancelled
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("cancelled", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public enum Cancelled
    {
        /// <summary>
        ///     True
        /// </summary>
        @true,

        /// <summary>
        ///     False
        /// </summary>
        @false
    }
}