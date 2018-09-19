using System;
using System.Collections.Generic;
using MusicBrainz;
using MusicBrainz.Events;

namespace net20
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicBrainz.Events.Exceptions.Instance.ExceptionTriggered += ExceptionOnTriggered;
            MusicBrainz.Events.Logging.Instance.LogEntryTriggered += LoggingOnTriggered;
            MusicBrainz.Events.Logging.Instance.StatusTriggered += LoggingOnStatusTriggered;

            var ret = Browse.ReleaseGroup(artist: "65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab", types: new List<Browse.Type> {Browse.Type.Live});
            System.Threading.Thread.Sleep(500);
            var ret1 = Browse.Area("696dbf04-9c8a-4fba-8019-e939be30ba3f");
            System.Threading.Thread.Sleep(500);
            var ret2 = Browse.Artist(recording: "026fa041-3917-4c73-9079-ed16e36f20f8");
            System.Threading.Thread.Sleep(500);
            var ret3 = Browse.Collection(artist: "65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab");
            System.Threading.Thread.Sleep(500);
            var ret4 = Browse.Collection(artist: "65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab");
            System.Threading.Thread.Sleep(500);
            var ret5 = Browse.Event(artist: "65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab");
            System.Threading.Thread.Sleep(500);
            var ret6 = Browse.Instrument("bass");
            System.Threading.Thread.Sleep(500);
            var ret7 = Browse.Label(release: "62d1c4ef-fc00-37af-8df7-485f6a31fcc4");
            System.Threading.Thread.Sleep(500);
            var ret8 = Browse.Place(area: "489ce91b-6658-3307-9877-795b68554c98");
            System.Threading.Thread.Sleep(500);
            var ret9 = Browse.Recording(artist: "65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab");
            System.Threading.Thread.Sleep(500);
            var ret10 = Browse.Series("");
            System.Threading.Thread.Sleep(500);
            var ret11 = Browse.Work(artist: "65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab");
            System.Threading.Thread.Sleep(500);
            var ret12 = Browse.Url(new Uri("http://www.metallica.com/"));
            System.Threading.Thread.Sleep(500);
            var ret13 = Search.Annotation(entity: "bdb24cb5-404b-4f60-bba4-7b730325ae47");
            System.Threading.Thread.Sleep(500);
            var ret14 = Search.Artist(artist: "fred", type: "group", country: "US");
            System.Threading.Thread.Sleep(500);
            var ret15 = Search.CdStub(title: "Doo");
            System.Threading.Thread.Sleep(500);
            var ret16 = Search.Label("Devils Records");
            System.Threading.Thread.Sleep(500);
            var ret17 = Search.ReleaseGroup(release: "Tenance");
            System.Threading.Thread.Sleep(500);
            var ret18 = Search.Release(release: "Schneider AND Shake");
            System.Threading.Thread.Sleep(500);
            var ret19 = Search.Recording(isrc: "GBAHT1600302");
            System.Threading.Thread.Sleep(500);
            var ret20 = Search.Taglist("shoegaze");
            System.Threading.Thread.Sleep(500);
            var ret21 = Search.Work(work: "Frozen", arid: "4c006444-ccbf-425e-b3e7-03a98bab5997");
            System.Threading.Thread.Sleep(500);
            var ret22 = Lookup.Area("489ce91b-6658-3307-9877-795b68554c98");
            System.Threading.Thread.Sleep(500);
            var ret23 = Lookup.Artist("65f4f0c5-ef9e-490c-aee3-909e7ae6b2ab");
            System.Threading.Thread.Sleep(500);
            var ret24 = Lookup.Collection("77fc94da-bfb8-402f-986e-f480fd7775c9");
            System.Threading.Thread.Sleep(500);
            var ret25 = Lookup.Event("bc17e5e7-7449-42f9-8fda-5eb801c82cb6");
            System.Threading.Thread.Sleep(500);
            var ret26 = Lookup.Instrument("c3fddfb8-100a-4e25-897f-9129d5a6c39f");
            System.Threading.Thread.Sleep(500);
            var ret27 = Lookup.Label("aad8fdd7-c3a0-414a-a6ce-2d2e72f57533");
            System.Threading.Thread.Sleep(500);
            var ret28 = Lookup.Place("d6cca412-ec3d-49ca-99c6-46a6337497fb");
            System.Threading.Thread.Sleep(500);
            var ret29 = Lookup.Recording("026fa041-3917-4c73-9079-ed16e36f20f8");
            System.Threading.Thread.Sleep(500);
            var ret30 = Lookup.Release("62d1c4ef-fc00-37af-8df7-485f6a31fcc4");
            System.Threading.Thread.Sleep(500);
            var ret31 = Lookup.ReleaseGroup("70664047-2545-4e46-b75f-4556f2a7b83e");
            System.Threading.Thread.Sleep(500);
            var ret32 = Lookup.Series("7b4bad67-c2fa-445d-b4ea-f415dc00e00c");
            System.Threading.Thread.Sleep(500);
            var ret33 = Lookup.Work("10c1a66a-8166-32ec-a00f-540f111ce7a3");
            System.Threading.Thread.Sleep(500);
            var ret34 = Lookup.Url("b663423b-9b54-4067-9674-fffaecf68851");
            System.Threading.Thread.Sleep(500);

            Console.ReadLine();
        }

        private static void LoggingOnStatusTriggered(object sender, ApiStatus e)
        {
            Console.WriteLine(e + "Error: " + e.ErrorOccurred + " Url: " + e.Url);
        }


        private static void LoggingOnTriggered(object sender, LoggingArgs e)
        {
            Console.WriteLine(e.ToString());
        }

        private static void ExceptionOnTriggered(object sender, ExceptionsArgs e)
        {
            Console.WriteLine(e.Exception.Message);           
        }
    }
}
