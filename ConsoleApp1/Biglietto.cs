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

        // Genera un numero casuale per il biglietto
        public void GeneraNumeroCasuale()
        {
            Random rnd = new Random();
            this.numero = rnd.Next(1000000);
        }

        // Imposta/modifica i dati del biglietto
        public void ImpostaDati(string serie, int numero, string citta, int premio)
        {
            this.serie = serie;
            this.numero = numero;
            this.citta = citta;
            this.premio = premio;
        }

        // Visualizza se il biglietto è vincente
        public void VisualizzaSeVincente()
        {
            if (this.premio > 0)
            {
                Console.WriteLine("Il biglietto è vincente!");
            }
            else
            {
                Console.WriteLine("Il biglietto non è vincente.");
            }
        }

        // Confronta due biglietti e segnala quello con il premio maggiore
        public static void ConfrontaBiglietti(Biglietto biglietto1, Biglietto biglietto2)
        {
            if (biglietto1.premio > biglietto2.premio)
            {
                Console.WriteLine("Il biglietto 1 ha il premio maggiore.");
            }
            else if (biglietto2.premio > biglietto1.premio)
            {
                Console.WriteLine("Il biglietto 2 ha il premio maggiore.");
            }
            else
            {
                Console.WriteLine("I biglietti hanno lo stesso premio.");
            }
        }

        // Controlla l'appartenenza di due biglietti alla stessa serie
        public static void ControllaAppartenenzaSerie(Biglietto biglietto1, Biglietto biglietto2)
        {
            if (biglietto1.serie == biglietto2.serie)
            {
                Console.WriteLine("I biglietti appartengono alla stessa serie.");
            }
            else
            {
                Console.WriteLine("I biglietti non appartengono alla stessa serie.");
            }
        }
    }
    }
