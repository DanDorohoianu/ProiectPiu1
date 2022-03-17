using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPIU
{
    class Intrebare // Clasa Intrebare va contine numarul intrebarii, textul intrebarii, poze, daca sunt necesare
    {
        int nrIntrebare;
        string[] text;

        public Intrebare(int nrIntrebare, string[] Text) //Constructor explicit
        {
            this.nrIntrebare = nrIntrebare; 
            text = Text;
        }
        public void SetnrIntrebare()  //Set pentru nrIntrebare
        {
            this.nrIntrebare = nrIntrebare;
        }
        public GetnrIntrebare() //Get pentru nrIntrebare
        {
            return nrIntrebare;
        }
    }
}
