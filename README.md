MusicBrainz
===========

.Net data bindings for [MusicBrainz XML Web Service v2.0](http://musicbrainz.org/doc/Development/XML_Web_Service/Version_2/Search)

The search fields are identical to the online search.

Any Examples (C#):
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

  // Search a CD with a Song from a specific Artist
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
Any Examples (VB):
```vb
  Dim anno = MusicBrainz.Search.Annotation(entity:="bdb24cb5-404b-4f60-bba4-7b730325ae47")
  Dim area = MusicBrainz.Search.Area("germany", type:="Country")
  Dim artist = MusicBrainz.Search.Artist("fred")
  Dim cd = MusicBrainz.Search.CdStub(title:="Doo")
  Dim fdb = MusicBrainz.Search.Freedb(discid:="6e108c07")
  Dim lab = MusicBrainz.Search.Label("Devils")
  Dim place = MusicBrainz.Search.Place("Studio")
  Dim recording = MusicBrainz.Search.Recording("Fred")
  Dim release = MusicBrainz.Search.Release("Schneider")
  Dim releaseGroup = MusicBrainz.Search.ReleaseGroup("Tenance")
  Dim work = MusicBrainz.Search.Work("Devils")

  ' Search a CD with a Song from a specific Artist
  Dim rec = MusicBrainz.Search.Recording("Inheritance", artist:="Scorpions")

  For Each s In rec.Data
    For Each r In s.Releaselist
	  If r.Id = String.Empty Then Continue For
	  For Each a In s.Artistcredit
		If a.Artist.Id <> String.Empty Then
		  Console.WriteLine("Artist ID: {0} Releas ID: {1} Releas Title: {2}", a.Artist.Id, r.Id, r.Title)
		  Return
		End If
	  Next
	Next
  Next
```