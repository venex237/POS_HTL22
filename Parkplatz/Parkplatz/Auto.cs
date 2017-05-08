using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkplatz
{
    
    class Auto
    {
        static Random rnd = new Random();
        public int startZeit = 0;
        public int endZeit = 0;
        public int Zeit = 0;

        public Auto(int _startzeit)
        {
            startZeit = _startzeit;
            Zeit = rnd.Next(5, 61);
            endZeit = startZeit + Zeit;
        }

    }
}
