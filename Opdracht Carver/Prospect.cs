using Carver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_Carver
{
    internal class Prospect
    {
        private int id;
        private string naam;
        private string postcode;
        private string woonplaats;
        private string email;
        private int rijbewijstype;

        // Hier onder de setters
        private void setId(int iid) { id = iid;}
        private void setNaam(string Naam) { naam = Naam;}
        private void setPostcode(string Postcode) { postcode = Postcode;}
        private void setWoonplaats(string Woonplaats) { woonplaats = Woonplaats;}
        private void setEmail(string Email) { email = Email;}
        private void setRijbewijs(int Rijbewijs) { rijbewijstype = Rijbewijs;}
        
        // Hier onder de getters

        public string getNaam() { return naam; }
        public string getPostcode() { return postcode; }
        public string getWoonplaats() { return woonplaats; }
        public string getEmail() { return email; }
        public int getRijbewijstype() { return rijbewijstype; }

        // Hieronder een object voor de class database
        Database db = new Database();

        // Hier onder de constructor

        public Prospect(string n, string p, string w, string e, int r)
        {
            setNaam(n);
            setPostcode(p);
            setWoonplaats(w);
            setEmail(e);
            setRijbewijs(r);
        }
        public void insertInDb()
        {
            string sql = "INSERT INTO prospect (Naam, Postcode, Woonplaats, Email, Rijbewijstype) VALUES ( '" + getNaam() + "', '" + getPostcode() + "', '" + getWoonplaats() + "', '" + getEmail() + "', " + getRijbewijstype() + ")";               
            MessageBox.Show(db.ExecuteQueries(sql));
        }
    }
}
