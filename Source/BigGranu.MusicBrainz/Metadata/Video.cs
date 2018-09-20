using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Video
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("video", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public enum Video
    {
        /// <remarks />
        @true,

        /// <remarks />
        @false
    }
}