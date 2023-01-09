    using System;
using System.Collections.Generic;
using System.Linq;
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

        // Costruttore della classe
        public Biglietto(string serie, int numero, string citta, int premio)
        {
            this.serie = serie;
            this.numero = numero;
            this.citta = citta;
            this.premio = premio;
        }
        protected Biglietto(Biglietto other) : this(other.serie, other.numero, other.citta, other.premio)
        {
        }

        public string Serie {
            get { return serie; }
           set { serie = value; }
        }
        public int Numero { 
            get { return numero; }
            set { numero = value; }
        }
        public string Citta { 
            get { return citta; }
            set { citta = value; }
        }
        public int Premio { 
            get { return premio; }
            set { premio = value; }
        }

        public Biglietto Clone()
        {
            return new Biglietto (this);
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


        public void GeneraNumeroCasuale()
        {
            Random rnd = new Random();
            this.numero = rnd.Next(1000000);
        }

       
        public void ImpostaDati(string serie, int numero, string citta, int premio)
        {
            this.serie = serie;
            this.numero = numero;
            this.citta = citta;
            this.premio = premio;
        }

       
        public int VisualizzaSeVincente()
        {

            int a=1;
            int b=0;
            if (this.premio > 0)
            {
              return a;
            }
            else
            {
               return b;
            }
        }

        
        public int ConfrontaBiglietti( Biglietto biglietto1)
        {
            int a=1;
            int b=-1;
            int c=0;
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

        public int ControllaAppartenenzaSerie(Biglietto biglietto1)
        {
            int a = 1;
            int b = 0;
            if (this.serie == biglietto1.serie)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

      
    }
    }
