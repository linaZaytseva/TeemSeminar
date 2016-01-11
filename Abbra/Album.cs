using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abbra
{
    class Album
    {
        string name;
        List<string> songs;

        public Album(string name, List<string> songs)
        {
            this.name = name;
            this.songs = songs;
        }
    }
}
