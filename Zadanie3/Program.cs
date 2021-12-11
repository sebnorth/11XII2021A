using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ile
             * suma
             * średnia
             */

            // fragment operacji na plikach
            string nazwa = @"C:\Users\sagata\Downloads\inne\kursy\C#\zaj5\pliki10\zastepstwo\liczby3.txt";
            string s; // bieżąca linia
            double suma = 0;

            FileStream plik = new FileStream(nazwa, FileMode.Open, FileAccess.Read, FileShare.None);
            System.IO.StreamReader odczyt = new StreamReader(plik);

            while ((s = odczyt.ReadLine())!= null)
            {
                Console.WriteLine(s);
                suma += Convert.ToDouble(s);
            }

            odczyt.Close();
            plik.Close();
            Console.WriteLine("Suma: {0}", suma);

            Console.ReadKey();
        }
    }
}
