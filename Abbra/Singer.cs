using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abbra
{
    class Singer
    {
        string singerName;
        Album albumName;

        public Singer(string singerName, Album albumName)
        {
            this.singerName = singerName;
            this.albumName = albumName;
        }
    }
}
