using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicBrainz;

namespace Tests
{
    [TestClass]
    public class MusicBrainz
    {

        [TestMethod]
        public void Query()
        {
            // 
            // https://musicbrainz.org/ws/2/instrument/?query=bass
            var ret = Search.Query("instrument", "?query=bass");
        }

        #region Browse

        [TestMethod]
        public void BrowseArea()
        {
            // Browse an Area from the Collection UNITED STATES OF AMERICA.
            // http://musicbrainz.org/ws/2/area?collection=696dbf04-9c8a-4fba-8019-e939be30ba3f
            var ret = Browse.Area("696dbf04-9c8a-4fba-8019-e939be30ba3f");
        }

        [TestMethod]
        public void BrowseArtist()
        {
            // http://musicbrainz.org/ws/2/artist?recording=026fa041-3917-4c73-9079-ed16e36f20f8
            var ret = Browse.Artist(recording: "026fa041-3917-4c73-9079-ed16e36f20f8");
        }

        [TestMethod]
        public void BrowseCollection()
        {
            // http://musicbrainz.org/ws/2/collection?artist=65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab
            var ret = Browse.Collection(artist: "65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab");
        }

        [TestMethod]
        public void BrowseEvent()
        {
            // http://musicbrainz.org/ws/2/event?artist=65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab
            var ret = Browse.Event(artist: "65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab");
        }

        [TestMethod]
        public void BrowseInstrument()
        {
            // 
            var ret = Browse.Instrument("");
        }

        [TestMethod]
        public void BrowseLabel()
        {
            // http://musicbrainz.org/ws/2/label?release=62d1c4ef-fc00-37af-8df7-485f6a31fcc4
            var ret = Browse.Label(release: "62d1c4ef-fc00-37af-8df7-485f6a31fcc4");
        }

        [TestMethod]
        public void BrowsePlace()
        {
            // List Places in United States
            // http://musicbrainz.org/ws/2/place?area=489ce91b-6658-3307-9877-795b68554c98
            var ret = Browse.Place(area: "489ce91b-6658-3307-9877-795b68554c98");
        }

        [TestMethod]
        public void BrowseRecording()
        {
            // List Records from Metallica
            // http://musicbrainz.org/ws/2/recording?artist=65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab
            var ret = Browse.Recording(artist: "65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab");
        }

        [TestMethod]
        public void BrowseRelease()
        {
            // List the Releases from Metallica with Status Bootleg and Type are Live or Interview
            // http://musicbrainz.org/ws/2/release?artist=65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab&type=live|interview&status=bootleg
            var ret = Browse.Release(artist: "65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab", types: new List<Browse.Type> { Browse.Type.Live, Browse.Type.Interview }, status: new List<Browse.Status> { Browse.Status.Bootleg });
        }

        [TestMethod]
        public void BrowseReleaseGroup()
        {
            // List the Releasesgroups from Metallica where are Live
            // http://musicbrainz.org/ws/2/release-group?artist=65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab&type=live
            var ret = Browse.ReleaseGroup(artist: "65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab", types: new List<Browse.Type> { Browse.Type.Live });
        }

        [TestMethod]
        public void BrowseSeries()
        {
            // 
            // 
            var ret = Browse.Series("");
        }

        [TestMethod]
        public void BrowseWork()
        {
            // Browse the Works of Metallica
            // http://musicbrainz.org/ws/2/work?artist=65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab
            var ret = Browse.Work(artist: "65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab");
        }

        [TestMethod]
        public void BrowseUrl()
        {
            // Browse the Metallica Hompage
            // http://musicbrainz.org/ws/2/url?resource=http://www.metallica.com/
            var ret = Browse.Url(new Uri("http://www.metallica.com/"));
        }

        #endregion

        #region Search

        [TestMethod]
        public void Annotation()
        {
            // http://musicbrainz.org/ws/2/annotation/?query=entity:bdb24cb5-404b-4f60-bba4-7b730325ae47
            var ret = Search.Annotation(entity: "bdb24cb5-404b-4f60-bba4-7b730325ae47");
        }

        [TestMethod]
        public void Artist()
        {
            // http://musicbrainz.org/ws/2/artist/?query=artist:fred%20AND%20country:US%20AND%20type:group
            var ret = Search.Artist(artist: "fred", type: "group", country: "US");

            var ret2 = Search.Artist(artist: "ac?dc");

            var ret3 = Search.Artist(artist: "mark+forster");
        }

        [TestMethod]
        public void CDStub()
        {
            // http://musicbrainz.org/ws/2/cdstub/?query=title:Doo
            var ret = Search.CdStub(title: "Doo");
        }

        [TestMethod]
        public void Label()
        {
            // http://musicbrainz.org/ws/2/label/?query="Devils%20Records"
            var ret = Search.Label("Devils*");
        }

        [TestMethod]
        public void ReleaseGroup()
        {
            // http://musicbrainz.org/ws/2/release-group/?query=release:Tenance
            var ret = Search.ReleaseGroup(release: "Tenance");
        }

        [TestMethod]
        public void Release()
        {
            // http://musicbrainz.org/ws/2/release/?query=release:Schneider%20AND%20Shake
            var ret = Search.Release(release: "Schneider AND Shake");
        }

        [TestMethod]
        public void Recording()
        {
            // http://musicbrainz.org/ws/2/recording/?query=isrc:GBAHT1600302
            var ret = Search.Recording(isrc: "GBAHT1600302");
        }

        [TestMethod]
        public void Tag()
        {
            // http://musicbrainz.org/ws/2/tag/?query=shoegaze
            var ret = Search.Taglist("shoegaze");
        }

        [TestMethod]
        public void Work()
        {
            // http://musicbrainz.org/ws/2/work/?query=arid:4c006444-ccbf-425e-b3e7-03a98bab5997%20AND%20work:Frozen
            var ret = Search.Work(work: "Frozen", arid: "4c006444-ccbf-425e-b3e7-03a98bab5997");
        }

        #endregion

        #region Lookup

        [TestMethod]
        public void LookupArea()
        {
            // http://musicbrainz.org/ws/2/area/489ce91b-6658-3307-9877-795b68554c98?inc=aliases+annotation+tags
            var ret = Lookup.Area("489ce91b-6658-3307-9877-795b68554c98");
        }

        [TestMethod]
        public void LookupArtist()
        {
            // http://musicbrainz.org/ws/2/artist/65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab?inc=aliases+annotation+tags+ratings+artist-credits+recordings+release-groups+isrcs
            var ret = Lookup.Artist("65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab");
        }

        [TestMethod]
        public void LookupCollection()
        {
            // http://musicbrainz.org/ws/2/collection/77fc94da-bfb8-402f-986e-f480fd7775c9
            var ret = Lookup.Collection("77fc94da-bfb8-402f-986e-f480fd7775c9");
        }

        [TestMethod]
        public void LookupEvent()
        {
            // http://musicbrainz.org/ws/2/event/bc17e5e7-7449-42f9-8fda-5eb801c82cb6?inc=aliases+annotation+tags+ratings
            var ret = Lookup.Event("bc17e5e7-7449-42f9-8fda-5eb801c82cb6");
        }

        [TestMethod]
        public void LookupInstrument()
        {
            // http://musicbrainz.org/ws/2/instrument/c3fddfb8-100a-4e25-897f-9129d5a6c39f?inc=aliases+annotation+tags
            var ret = Lookup.Instrument("c3fddfb8-100a-4e25-897f-9129d5a6c39f");
        }

        [TestMethod]
        public void LookupLabel()
        {
            Lookup.UseAllIncs = false;

            // http://musicbrainz.org/ws/2/label/aad8fdd7-c3a0-414a-a6ce-2d2e72f57533?inc=aliases+annotation+tags+ratings
            var ret = Lookup.Label("aad8fdd7-c3a0-414a-a6ce-2d2e72f57533");
        }

        [TestMethod]
        public void LookupPlace()
        {
            // http://musicbrainz.org/ws/2/place/d6cca412-ec3d-49ca-99c6-46a6337497fb?inc=aliases+annotation+tags
            var ret = Lookup.Place("d6cca412-ec3d-49ca-99c6-46a6337497fb");
        }

        [TestMethod]
        public void LookupRecording()
        {
            // http://musicbrainz.org/ws/2/recording/026fa041-3917-4c73-9079-ed16e36f20f8?inc=aliases+annotation+tags+ratings+artists+artist-credits+release-groups+isrcs
            var ret = Lookup.Recording("026fa041-3917-4c73-9079-ed16e36f20f8");
        }

        [TestMethod]
        public void LookupRelease()
        {
            // http://musicbrainz.org/ws/2/release/62d1c4ef-fc00-37af-8df7-485f6a31fcc4?inc=aliases+annotation+tags+ratings+discids+media+artists+collections+labels+artist-credits+recordings+release-groups+isrcs
            var ret = Lookup.Release("62d1c4ef-fc00-37af-8df7-485f6a31fcc4");
        }

        [TestMethod]
        public void LookupReleasegroup()
        {
            // http://musicbrainz.org/ws/2/release-group/70664047-2545-4e46-b75f-4556f2a7b83e?inc=aliases+annotation+tags+ratings+artists+artist-credits
            var ret = Lookup.ReleaseGroup("70664047-2545-4e46-b75f-4556f2a7b83e");
        }

        [TestMethod]
        public void LookupSeries()
        {
            // http://musicbrainz.org/ws/2/series/7b4bad67-c2fa-445d-b4ea-f415dc00e00c?inc=aliases+annotation+tags
            var ret = Lookup.Series("7b4bad67-c2fa-445d-b4ea-f415dc00e00c");
        }

        [TestMethod]
        public void LookupWork()
        {
            // http://musicbrainz.org/ws/2/work/10c1a66a-8166-32ec-a00f-540f111ce7a3?inc=aliases+annotation+tags+ratings
            var ret = Lookup.Work("10c1a66a-8166-32ec-a00f-540f111ce7a3");
        }

        [TestMethod]
        public void LookupUrl()
        {
            // http://musicbrainz.org/ws/2/url/b663423b-9b54-4067-9674-fffaecf68851
            var ret = Lookup.Url("b663423b-9b54-4067-9674-fffaecf68851");
        }

        #endregion
    }
}
