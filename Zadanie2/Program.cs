using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadanie2
{
    struct Osoba
    {

        public string imie;
        public string nazwisko;
        public string email;
        public int telefon;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, s = 0;
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


            // fragment operacji na plikach
            string nazwa = @"C:\Users\sagata\Downloads\inne\kursy\C#\zaj5\pliki10\zastepstwo\wizytowka.txt";

            FileStream plik = new FileStream(nazwa, FileMode.Create, FileAccess.Write, FileShare.None);
            System.IO.StreamWriter zapis = new StreamWriter(plik);


            // pierwszy wiersz wizytówki
            for (int i = 0; i < dlugoscWizytowki; i++)
            {
                zapis.Write("*");
            }
            zapis.WriteLine();
            // imie+nazwisko
            zapis.Write("*");
            s = (dlugoscWizytowki - a) / 2 - 1;
            for (int i = 0; i < s; i++)
            {
                zapis.Write(" ");
            }
            zapis.Write(os.imie + " " + os.nazwisko);
            for (int i = 0; i < s; i++)
            {
                zapis.Write(" ");
            }
            zapis.Write("*");
            zapis.WriteLine();
            // email
            zapis.Write("*");
            s = (dlugoscWizytowki - b) / 2 - 1;
            for (int i = 0; i < s; i++)
            {
                zapis.Write(" ");
            }
            zapis.Write(os.email);
            for (int i = 0; i < s; i++)
            {
                zapis.Write(" ");
            }
            zapis.Write("*");
            zapis.WriteLine();

            // telefon
            zapis.Write("*");
            s = (dlugoscWizytowki - c) / 2 - 1;
            for (int i = 0; i < s; i++)
            {
                zapis.Write(" ");
            }
            zapis.Write(napisTelefon);
            for (int i = 0; i < s; i++)
            {
                zapis.Write(" ");
            }
            zapis.Write("*");
            zapis.WriteLine();

            // ostatni wiersz wizytówki
            for (int i = 0; i < dlugoscWizytowki; i++)
            {
                zapis.Write("*");
            }
            zapis.WriteLine();

            zapis.Close();
            plik.Close();

            //Console.WriteLine(os.imie);
            //Console.WriteLine(os.nazwisko);
            //Console.WriteLine(os.email);
            //Console.WriteLine(os.telefon);



            Console.ReadKey();
        }
    }
}
