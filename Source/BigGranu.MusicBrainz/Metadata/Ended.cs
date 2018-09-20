using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Ended
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("ended", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public enum Ended
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