using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AvventuraTestuale {
    class Program {
         static InventorySystem Inventario;

        static void Main(string[] args) {
            Console.WriteLine("MAIN");
            bool stop = true;
                string text = null;

            // Ho aggiunto un commento
                Inventario=new InventorySystem();
                Titoli();
                Console.WriteLine("A OVEST DELLA CASA");
                Coloreforesta();
                Console.WriteLine("Sei in una foresta ad ovest di una casa di mattoni.");
                Thread.Sleep(500);
                Console.WriteLine("Vedi un foglio attaccato in un albero.");

                do {
                    try {
                        Console.Write(">: ");
                        text = Console.ReadLine();
                        stop = Comandi(text);
                        Foresta(text);
                    } catch(Exception e) { Console.WriteLine("COSA?!?!?!"+e.Message+e.StackTrace);}
                } while(stop);
                Console.WriteLine(stop);
            Console.ReadKey();
        }
        static void Coloreforesta() { Console.BackgroundColor = ConsoleColor.DarkGreen; Console.ForegroundColor = ConsoleColor.White; }
        static void Titoli() { Console.ForegroundColor = ConsoleColor.DarkGray; }

        /**
         *  2 caratteri: pr
         *  10 caratteri: prendi foglio
         *  
         *  int lunghezza1 =  primastringa.Length; // 2
         *  
         *  secondastringa = substring(secondastringa, 0, lunghezza1); // la accorcio fino a 7 caratteri "prendi foglio" => "pr"
         *  
         *  primastringa = primastringa.ToLower();
         *  secondastringa = secondastringa.ToLower();
         *  
         *  if(primastringa == secondastringa){
         *      
         *  }
         */
        static bool confronta_comando(string input,string comando) {
            if(input.Length > 3) {
                int lunghezza_split;
                if(input.Length > comando.Length) lunghezza_split = comando.Length;
                else                              lunghezza_split = input.Length;
                comando = comando.Substring(0,lunghezza_split); // Accorcia comando alla lunghezza dell'input
                input = input.ToLower(); // Fai l'input in piccolo
                comando = comando.ToLower(); // Fai anche il comando in piccolo per poi confrontare
                return (input == comando); // Se sono uguali allora il comando inserito è giusto (vero) sennò vai a cagare (false)
            } else {
                return false;
            }
        }

        static bool Comandi(string text) {
            bool uscita = true;

            if(confronta_comando(text,"prendi foglio") || confronta_comando(text,"stacca foglio")) {
                try {
                    Foglio foglio = new Foglio("CYKABLYAT");
                    Inventario.AddItem(foglio,1);
                    Console.WriteLine("Hai raccolto un foglio.");
                } catch(Exception e) {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
            } else if(confronta_comando(text,"leggi foglio")) {
                for(int i = 0; i < Inventario.getItemList().Count; i++) {
                    ObtainableItem oi = Inventario.getItemRecord(i).GetObtainableItem();
                    if(oi.GetType() == typeof(Foglio)) {
                        Foglio x = (Foglio)oi;
                        Console.WriteLine("Contenuto del foglio: \n\n" + x.leggi());
                    }
                }
            } else if(text=="n" || text=="N") {
                Console.WriteLine("NANI?!?!?!");
            } else if(confronta_comando(text," ")) {

            } else {
                Console.WriteLine("Non conosco questo comando (O la lunghezza non è sufficiente).");
            }
            return uscita;
        }
        static void Foresta(string text) {

        }
    }
}
