using System;
using System.Collections.Generic;
using MusicBrainz.Metadata;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MusicBrainz.Metadata.Recording> list = new List<Recording>();           
            var ret = MusicBrainz.Search.Recording(artist: "madonna", limit: 100);

            list.AddRange(ret.Recording);

            int i = Convert.ToInt32(ret.Count)  ;

            int ii = i / 100;
            int offset = 100;

            for (int x = 0; x <= ii; x++)
            {
                ret = MusicBrainz.Search.Recording(artist: "madonna", limit: 100, offset: offset);

                list.AddRange(ret.Recording);

                offset += 100;
            }

        }
    }
}
