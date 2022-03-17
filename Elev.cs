using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPIU
{
    class Elev // Clasa Elev va contine date despre participantii la quiz: nume, clasa, profil,
    {
        string nume;
        string clasa;
        string profil;

        public Elev(string nume, string clasa, string profil)  //Construcor explicit
        {
            this.nume = nume;
            this.clasa = clasa;
            this.profil = profil;
        }
    }
}
