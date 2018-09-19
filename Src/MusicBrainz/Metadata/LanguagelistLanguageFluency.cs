using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     LanguagelistLanguageFluency
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("languagelistLanguageFluency")]
    public enum LanguagelistLanguageFluency
    {
        /// <summary>
        ///     Basic
        /// </summary>
        basic,

        /// <summary>
        ///     Intermediate
        /// </summary>
        intermediate,

        /// <summary>
        ///     Advanced
        /// </summary>
        advanced,

        /// <summary>
        ///     Native
        /// </summary>
        native
    }
}