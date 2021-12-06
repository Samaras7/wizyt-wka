using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace laborka6
{
    class Program
    {
        struct osoba
        {
            public string imie, nazwisko, email, nrTelefonu;
        }
        static void Main(string[] args)
        {
            osoba o;
            Console.WriteLine("podaj imie");
            o.imie = Console.ReadLine();
            Console.WriteLine("podaj nazwisko");
            o.nazwisko = Console.ReadLine();
            Console.WriteLine("podaj e-mail");
            o.email = Console.ReadLine();
            Console.WriteLine("podaj numer telefonu");
            o.nrTelefonu = Console.ReadLine();
            int szerokoscWizytowki = 0;
            if ((Convert.ToInt32(o.imie.Length + o.nazwisko.Length) + 5) > (Convert.ToInt32(o.email.Length) + 10)) szerokoscWizytowki = Convert.ToInt32(o.imie.Length + o.nazwisko.Length) + 5;
            else szerokoscWizytowki = Convert.ToInt32(o.email.Length) + 12;
            int dopelnienie = (szerokoscWizytowki - Convert.ToInt32(o.imie.Length + o.nazwisko.Length) - 5) / 2;
            string path = "wizytówka.txt";
            FileStream plik = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            System.IO.StreamWriter zapis = new StreamWriter(plik);

            for (int i = 0; i < szerokoscWizytowki; i++)
            {
                Console.Write("*");
                zapis.Write("*");
            }
            Console.Write("\n* ");
            zapis.Write("\n* ");
            for (int i = 0; i < dopelnienie; i++)
            {
                Console.Write(" ");
                zapis.Write(" ");
            }
            Console.Write(o.imie + " " + o.nazwisko);
            zapis.Write(o.imie + " " + o.nazwisko);
            if ((o.imie.Length + o.nazwisko.Length) % 2 == 1)
            {
                Console.Write(" ");
                zapis.Write(" ");
            }
            for (int i = 0; i < dopelnienie; i++)
            {
                Console.Write(" ");
                zapis.Write(" ");
            }
            Console.WriteLine(" *");
            zapis.WriteLine(" *");

            dopelnienie = (szerokoscWizytowki - Convert.ToInt32(o.email.Length) - 12) / 2;
            Console.Write("* ");
            zapis.Write("* ");
            for (int i = 0; i < dopelnienie; i++)
            {
                Console.Write(" ");
                zapis.Write(" ");
            }
            Console.Write("e-mail: " + o.email);
            zapis.Write("e-mail: " + o.email);
            for (int i = 0; i < dopelnienie; i++)
            {
                Console.Write(" ");
                zapis.Write(" ");
            }
            Console.WriteLine(" *");
            zapis.WriteLine(" *");

            dopelnienie = (szerokoscWizytowki - Convert.ToInt32(o.nrTelefonu.Length) - 9) / 2;
            Console.Write("* ");
            zapis.Write("* ");
            for (int i = 0; i < dopelnienie; i++)
            {
                Console.Write(" ");
                zapis.Write(" ");
            }
            Console.Write("tel. " + o.nrTelefonu);
            zapis.Write("tel. " + o.nrTelefonu);
            for (int i = 0; i < dopelnienie; i++)
            {
                Console.Write(" ");
                zapis.Write(" ");
            }
            if (o.nrTelefonu.Length % 2 == 1)
            {
                Console.Write(" ");
                zapis.Write(" ");
            }
            Console.WriteLine(" *");
            zapis.WriteLine(" *");
            for (int i = 0; i < szerokoscWizytowki; i++)
            {
                Console.Write("*");
                zapis.Write("*");
            }
            zapis.Close();
            plik.Close();
            Console.ReadKey();
        }
    }
}