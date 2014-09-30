MusicBrainz
===========

.Net data bindings for [MusicBrainz XML Web Service v2.0](http://musicbrainz.org/doc/Development/XML_Web_Service/Version_2/Search)

The search fields are identical to the online search.

Any Examples:
```c#
  var anno = MusicBrainz.Search.Annotation(entity: "bdb24cb5-404b-4f60-bba4-7b730325ae47");
  var area = MusicBrainz.Search.Area("germany", type: "Country");
  var artist = MusicBrainz.Search.Artist("fred");
  var cd = MusicBrainz.Search.CdStub(title: "Doo");
  var fdb = MusicBrainz.Search.Freedb(discid: "6e108c07");
  var lab = MusicBrainz.Search.Label("Devils");
  var place = MusicBrainz.Search.Place("Studio");
  var recording = MusicBrainz.Search.Recording("Fred");
  var release = MusicBrainz.Search.Release("Schneider");
  var releaseGroup = MusicBrainz.Search.ReleaseGroup("Tenance");
  var work = MusicBrainz.Search.Work("Devils");
```
Search a CD with a Song from a specific Artist:
```c#
  var rec = MusicBrainz.Search.Recording("Inheritance", artist: "Scorpions");

  foreach (var s in rec.Data)
	foreach (var r in s.Releaselist)
	{
	  if (r.Id == string.Empty) continue;
	  foreach (var a in s.Artistcredit.Where(a => a.Artist.Id != string.Empty))
	  {
		Console.WriteLine(@"Artist ID: {0} Releas ID: {1} Releas Title: {2}", a.Artist.Id, r.Id, r.Title);
		return;
	  }
	}
```