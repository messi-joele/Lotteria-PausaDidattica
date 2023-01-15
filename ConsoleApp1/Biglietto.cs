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


        public void Aggiungi(string serie, int numero, string citta, int premio)

        {

            this.numero = rnd.Next(1000000);
            int randomNumber = rnd.Next(26);


            char randomLetter = (char)('a' + randomNumber);

            this.serie = Convert.ToString(randomLetter);
          
            this.citta = citta;
            this.premio = premio;
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


    }
}
