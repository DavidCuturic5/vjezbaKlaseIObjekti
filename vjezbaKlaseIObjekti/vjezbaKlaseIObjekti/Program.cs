using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbaKlaseIObjekti
{

    class Zrakoplov
    {
        string naziv;
        double snagaMotora;
        int dosegLeta;

        private string Naziv { get => naziv; set => naziv = value; }
        private double SnagaMotora { get => snagaMotora; set => snagaMotora = value; }
        private int DosegLeta { get => dosegLeta; set => dosegLeta = value; }

        
        public Zrakoplov() { }

        public Zrakoplov(string naziv, double snagaMotora, int dosegLeta)
        {
            this.naziv = naziv;
            this.snagaMotora = snagaMotora;
            this.dosegLeta = dosegLeta;
            
        }
        

        public override string ToString()
        {
            string ispis = "Naziv: " + this.naziv + ", " + "Snaga motora: " + this.snagaMotora + "kW" + ", " + "Doseg Leta: " + this.dosegLeta + "km";

            return ispis;
        } 
    
       
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Zrakoplov x380 = new Zrakoplov("Airbus", 2000, 6000);
            Zrakoplov C162 = new Zrakoplov("Cessna Skycatcher", 75, 870);
            Zrakoplov PC21 = new Zrakoplov("Pilatus", 1200, 1333);

            Console.WriteLine(x380.ToString());
            Console.WriteLine(C162.ToString());
            Console.WriteLine(PC21.ToString());

            Console.ReadKey();
        }
    }
}
