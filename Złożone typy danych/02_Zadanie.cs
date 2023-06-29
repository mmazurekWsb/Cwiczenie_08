using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Cw
{
    internal class Program
    {
        struct Student
        {
            public string Imie;
            public string Nazwisko;
            public int NumerIndeksu;
            public string Kierunek;
        }

        struct Przedmiot
        {
            public string Nazwa;
            public string KodPrzedmiotu;
            public int LiczbaGodzin;
            public string Prowadzacy;
        }

        struct NauczycielAkademicki
        {
            public string Imie;
            public string Nazwisko;
            public string TytulNaukowy;
            public string Specjalizacja;
        }
        static void Main(string[] args)
        {
        }
    }
}
