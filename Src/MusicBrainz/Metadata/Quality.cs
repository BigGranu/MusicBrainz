using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     Def_quality
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("quality", Namespace = "http://musicbrainz.org/ns/mmd-2.0#", IsNullable = false)]
    public enum Quality
    {
        /// <summary>
        ///     Low
        /// </summary>
        low,

        /// <summary>
        ///     Normal
        /// </summary>
        normal,

        /// <summary>
        ///     High
        /// </summary>
        high
    }
}