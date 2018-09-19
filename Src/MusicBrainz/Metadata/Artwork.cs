using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Artwork
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("artwork", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public enum Artwork
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