using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    enum Plec
    {
        Kobieta,
        Mezczyzna
    }

    struct Student
    {
        public string Nazwisko;
        public int NrAlbumu;
        public double Ocena;
        public Plec Plec;
    }

    internal class Program
    {
        
            static void Main(string[] args)
            {
                Student[] grupa = new Student[5];

                for (int i = 0; i < grupa.Length; i++)
                {
                    Console.WriteLine("Wprowadź dane dla studenta {0}:", i + 1);
                    WypelnijStudenta(ref grupa[i]);
                    Console.WriteLine();
                }

                Console.WriteLine("Dane studentów:");
                WyswietlStudentow(grupa);
                Console.WriteLine();

                double srednia = ObliczSrednia(grupa);
                Console.WriteLine("Średnia ocen: {0}", srednia);

                // Poczekaj na naciśnięcie klawisza przed zakończeniem programu
                Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
                Console.ReadKey();
            }

            static void WypelnijStudenta(ref Student student)
            {
                Console.Write("Nazwisko: ");
                student.Nazwisko = Console.ReadLine();

                Console.Write("Nr albumu: ");
                int nrAlbumu;
                if (int.TryParse(Console.ReadLine(), out nrAlbumu))
                {
                    student.NrAlbumu = nrAlbumu;
                }
                else
                {
                    Console.WriteLine("Błędny format numeru albumu. Ustawiono wartość domyślną (0).");
                    student.NrAlbumu = 0;
                }

                Console.Write("Ocena: ");
                double ocena;
                if (double.TryParse(Console.ReadLine(), out ocena))
                {
                    if (ocena < 2.0)
                        ocena = 2.0;
                    else if (ocena > 5.0)
                        ocena = 5.0;
                    student.Ocena = ocena;
                }
                else
                {
                    Console.WriteLine("Błędny format oceny. Ustawiono wartość domyślną (2.0).");
                    student.Ocena = 2.0;
                }

                Console.Write("Płeć (Kobieta/Mężczyzna): ");
                string plec = Console.ReadLine();
                if (plec.ToLower() == "kobieta")
                    student.Plec = Plec.Kobieta;
                else
                    student.Plec = Plec.Mezczyzna;
            }

            static void WyswietlStudentow(Student[] grupa)
            {
                foreach (var student in grupa)
                {
                    Console.WriteLine("Nazwisko: {0}, Nr albumu: {1}, Ocena: {2}, Płeć: {3}",
                        student.Nazwisko, student.NrAlbumu, student.Ocena, student.Plec);
                }
            }

            static double ObliczSrednia(Student[] grupa)
            {
                double suma = 0.0;
                foreach (var student in grupa)
                {
                    suma += student.Ocena;
                }
                return suma / grupa.Length;
            }
        
    }
}
