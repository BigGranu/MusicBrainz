using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Darkened
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("darkened", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public enum Darkened
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