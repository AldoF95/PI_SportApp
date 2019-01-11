using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB_app.Model
{
    public class Prisutnost
    {
        public int Id { get; set; }
        public int Igrac_id { get; set; }
        public int Trening_id { get; set; }
        public List<Igraci> Igraci_prisut = new List<Igraci>();
        public bool Prisutan { get; set; }
        public string Trening_prisut { get; set; }

        public Prisutnost()
        {

        }

        public void Dodaj_Igraca_Prisut(Igraci igr)
        {
            this.Igraci_prisut.Add(igr);
        }
    }
}
