using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test45
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Annotation()
        {
            // http://musicbrainz.org/ws/2/annotation/?query=entity:bdb24cb5-404b-4f60-bba4-7b730325ae47
            var ret = MusicBrainz.Search.Annotation(entity: "bdb24cb5-404b-4f60-bba4-7b730325ae47");
        }
    }
}
