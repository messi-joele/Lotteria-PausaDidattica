using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Biglietto
    {
        // Campi della classe
        private string serie;
        private int numero;
        private string citta;
        private int premio;
        private static Random rnd = new Random();

        // Costruttore della classe
        public Biglietto(string citta, int premio)
        {


            ImpostaSerieCasuale();
            ImpostaNumeroCasuale();
            this.citta = citta;
            this.premio = premio;
        }
        protected Biglietto(Biglietto other) : this(other.citta, other.premio)
        {
        }

        public string Serie
        {
            get { return serie; }
            private set { serie = value; }
        }
        public int Numero
        {
            get { return numero; }
            private set { numero = value; }
        }
        public string Citta
        {
            get { return citta; }
            set { citta = value; }
        }
        public int Premio
        {
            get { return premio; }
            set { premio = value; }
        }

        public Biglietto Clone()
        {
            return new Biglietto(this);
        }
        public bool Equals(Biglietto p)
        {
            if (p == null) return false;

            if (this == p) return true;

            return (this.serie == p.serie);
        }
        public override string ToString()
        {
            return "biglietto:" + Serie + ";" + numero + ";" + citta + ";" + premio;
        }


        public void ImpostaNumeroCasuale()
        {
            this.numero = rnd.Next(1000000);
        }
        public void ImpostaSerieCasuale()
        {



            int randomNumber = rnd.Next(26);


            char randomLetter = (char)('a' + randomNumber);

            this.serie = Convert.ToString(randomLetter);
        }


        public void ModDati (string citta, int premio)

        {

            this.citta = citta;
            this.premio = premio;
            ImpostaSerieCasuale();
            ImpostaNumeroCasuale();

        }

       


        public bool VisualizzaSeVincente()
        {

            return (this.premio > 0);

        }


        public int ConfrontaBiglietti(Biglietto biglietto1)
        {
            int a = 1;
            int b = -1;
            int c = 0;
            if (this.premio > biglietto1.premio)
            {
                return a;
            }
            else if (biglietto1.premio > this.premio)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        public bool ControllaAppartenenzaSerie(Biglietto biglietto1)
        {

            if (this.serie == biglietto1.serie)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ConfrontaNumeri(Biglietto b)
        {
            string a1 = Convert.ToString(this.numero).Substring(0,1);
            string a2 = Convert.ToString(this.numero).Substring(1,1);
            string a3 = Convert.ToString(this.numero).Substring(2,1);
            string a4 = Convert.ToString(this.numero).Substring(3,1);
            string a5 = Convert.ToString(this.numero).Substring(4,1);
            string a6 = Convert.ToString(this.numero).Substring(5,1);
            string b1 = Convert.ToString(b.numero).Substring(0,1);
            string b2 = Convert.ToString(b.numero).Substring(1,1);
            string b3 = Convert.ToString(b.numero).Substring(2,1);
            string b4 = Convert.ToString(b.numero).Substring(3,1);
            string b5 = Convert.ToString(b.numero).Substring(4,1);
            string b6 = Convert.ToString(b.numero).Substring(5,1);

            if(a1 != b1)
            {
                return false;
                
            }
            else if (a2 != b2)
            {
                    return false;
            }
            else if (a3 != b3)
            {
                return false;
            }
            else if (a4 != b4)
            {
                return false;
            }
            else if (a5 != b5)
            {
                return false;
            }
            else if (a6 != b6)
            {
                return false;
            }
            return true;
        }


    }
}
