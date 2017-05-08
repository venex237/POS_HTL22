using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTree
{
    class Student
    {
        string PK, Klasse, KatalogNummer, Name, Vorname;

        public Student(string _PK, string _Klasse, string _KatalogNummer, string _Name, string _Vorname)
        {
            PK = _PK;
            Klasse = _Klasse;
            KatalogNummer = _KatalogNummer;
            Name = _Name;
            Vorname = _Vorname;
        }

        public override string ToString()
        {
            return PK + Klasse + KatalogNummer + Name + Vorname;
        }

    }
}
