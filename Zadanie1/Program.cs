using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    struct Osoba {

        public string imie;
        public string nazwisko;
        public string email;
        public int telefon;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, s=0; 
            Osoba os;
            Console.WriteLine("Podaj imie: ");
            os.imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            os.nazwisko = Console.ReadLine();
            a = os.imie.Length + os.nazwisko.Length + 1;

            Console.WriteLine("Podaj email: ");
            os.email = Console.ReadLine();
            os.email = "e-mail: " + os.email;
            b = os.email.Length;

            Console.WriteLine("Podaj numer telefonu(9cyfra liczba): ");
            os.telefon = Convert.ToInt32(Console.ReadLine());
            string napisTelefon = "tel. " + os.telefon;
            c = napisTelefon.Length;
            int dlugoscNajdluzszegoNapisu = Math.Max(Math.Max(a, b), c);
            int dlugoscWizytowki = dlugoscNajdluzszegoNapisu + 4;

            // pierwszy wiersz wizytówki
            for (int i = 0; i < dlugoscWizytowki; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            // imie+nazwisko
            Console.Write("*");
            s = (dlugoscWizytowki - a) / 2 - 1;
            for (int i = 0; i < s; i++)
            {
                Console.Write(" ");
            }
            Console.Write(os.imie + " " + os.nazwisko);
            for (int i = 0; i < s; i++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            Console.WriteLine();
            // email
            Console.Write("*");
            s = (dlugoscWizytowki - b) / 2 - 1;
            for (int i = 0; i < s; i++)
            {
                Console.Write(" ");
            }
            Console.Write(os.email);
            for (int i = 0; i < s; i++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            Console.WriteLine();

            // telefon
            Console.Write("*");
            s = (dlugoscWizytowki - c) / 2 - 1;
            for (int i = 0; i < s; i++)
            {
                Console.Write(" ");
            }
            Console.Write(napisTelefon);
            for (int i = 0; i < s; i++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            Console.WriteLine();

            // ostatni wiersz wizytówki
            for (int i = 0; i < dlugoscWizytowki; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            //Console.WriteLine(os.imie);
            //Console.WriteLine(os.nazwisko);
            //Console.WriteLine(os.email);
            //Console.WriteLine(os.telefon);

            Console.ReadKey();


        }
    }
}
