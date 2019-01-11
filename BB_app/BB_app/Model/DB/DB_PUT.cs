using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace BB_app.Model.DB
{
    static class DB_PUT
    {
        //sve se ponavlja
        //staticna metoda sprema jednu instancu Vjezbe
        public static void Vjezbe_Put(Vjezbe vj)
        {
            //command to execute from connection conn (iz DB_connection)
            SQLiteCommand com = DB_connection.conn.CreateCommand();
            com.CommandText = String.Format(@"INSERT INTO VJEZBE (Naziv, Opis, Sutevi, Brzina, Brojac, Udaljenost, Drugo)
                                               VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", //insert request
                                               vj.Naziv, vj.Opis, vj.Sutevi, vj.Brzina, vj.Brojac, vj.Udaljenost, vj.Drugo);
            com.ExecuteNonQuery();//executes a non querry (ne vraca nista)
            com.Dispose();//command dispose
        }
        public static void Igraci_Put(Igraci igr)
        {
            SQLiteCommand com = DB_connection.conn.CreateCommand();
            com.CommandText = String.Format(@"INSERT INTO IGRAC (Ime, Prezime, Godiste, Spol, Zdravstveni_karton, Ekipa_ID)
                                               VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                                               igr.Ime, igr.Prezime, igr.Godiste, igr.Spol, igr.Karton, igr.Ekipa_id);
            com.ExecuteNonQuery();
            com.Dispose();
        }
        public static void Prisutnost_Put(Prisutnost pri)
        {
            SQLiteCommand com = DB_connection.conn.CreateCommand();
            com.CommandText = String.Format(@"INSERT INTO PRISUTNOST (Trening_ID, Igrac_ID, Prisutan)
                                               VALUES ('{0}', '{1}', '{2}')",
                                               pri.Trening_id, pri.Igrac_id, pri.Prisutan);
            com.ExecuteNonQuery();
            com.Dispose();
        }
        //sprema listu tako sto za svaki element u listi poziva insert od pripadajuce klase
        public static void Prisutnost_Put_List(List<Prisutnost> pri)
        {
            foreach(var p in pri)
            {
                Prisutnost_Put(p);
            }
        }
        public static void Kosevi_Put(Kosevi ko)
        {
            SQLiteCommand com = DB_connection.conn.CreateCommand();
            com.CommandText = String.Format(@"INSERT INTO KOSEVI (Pozicija_x, Pozicija_y, Suter_ID, Vrsta_sutera, Pogodjeno, Br_bodova)
                                               VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                                              ko.Poz_X, ko.Poz_Y, ko.Suter_id, ko.Vrsta_sut, ko.Pogodak, ko.Br_Bod);
            com.ExecuteNonQuery();
            com.Dispose();
        }
        public static void Zapisnik_Put(Zapisnik za)
        {
            SQLiteCommand com = DB_connection.conn.CreateCommand();
            com.CommandText = String.Format(@"INSERT INTO ZAPISNIK (Datum, Ekipa_ID, Ekipa_G, Rez_d, Rez_g)
                                               VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                                              za.Datum, za.Ekipa_id, za.Ekipa_gost, za.Rez_dom, za.Rez_gost);
            com.ExecuteNonQuery();
            com.Dispose();
        }
        public static void Ekipa_Put(Ekipa ek)
        {
            SQLiteCommand com = DB_connection.conn.CreateCommand();
            com.CommandText = String.Format(@"INSERT INTO EKIPA (Naziv, Ime_trenera)
                                               VALUES ('{0}', '{1}')",
                                              ek.Naziv, ek.Trener);
            com.ExecuteNonQuery();
            com.Dispose();
        }
        public static void Trening_Put(Trening tr)
        {
            SQLiteCommand com = DB_connection.conn.CreateCommand();
            com.CommandText = String.Format(@"INSERT INTO TRENING (Datum, Naziv, Br_vjezbi)
                                               VALUES ('{0}', '{1}', '{2}')",
                                              tr.Datum, tr.Naziv, tr.Br_Vjezbi);
            com.ExecuteNonQuery();
            com.Dispose();
        }
    }
}
