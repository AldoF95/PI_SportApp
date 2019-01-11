using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB_app.Model
{
    public class Ekipa
    {
        //geter i seter za atribute
        //u svim klasama je isto
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Trener { get; set; }

        //jednostavan konstruktor
        public Ekipa() { }
    }
}
