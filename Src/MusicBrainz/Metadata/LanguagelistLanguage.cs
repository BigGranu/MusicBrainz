using System.Xml.Serialization;

namespace MusicBrainz.Metadata
{
    /// <summary>
    ///     LanguagelistLanguage
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    [XmlRoot("languagelistLanguage")]
    public class LanguagelistLanguage
    {
        /// <summary>
        ///     Language Fluency
        /// </summary>
        [XmlAttribute("fluency")]
        public LanguagelistLanguageFluency Fluency { get; set; }


        /// <summary>
        ///     Value
        /// </summary>
        [XmlText]
        public string Value { get; set; }
    }
}