using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Def_direction
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("direction", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public enum Direction
    {
        /// <summary>
        ///     Both
        /// </summary>
        both,

        /// <summary>
        ///     Forward
        /// </summary>
        forward,

        /// <summary>
        ///     Backward
        /// </summary>
        backward
    }
}