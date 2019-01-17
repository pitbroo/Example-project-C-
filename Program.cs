using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Brodziak49084
{
    class Program
    {
        static void Main(string[] args)
        {




            ConsoleKeyInfo WybranaFunkcjonalnosc;


            do
            {
                //-------------Lista funkcjonalności-------------------
                {
                    Console.Write("\n\tMenu Funkcjonalne:");
                    Console.Write("\n\tA. Obliczanie sumy<in-line>");
                    Console.Write("\n\tB. Obliczanie sumy<method-call>");
                    Console.Write("\n\tC. Obliczanie iloczynu<in-line>");
                    Console.Write("\n\tD. Obliczanie iloczynu<method-call>");
                    Console.Write("\n\tE. Obliczanie średniej arytmatycznej<in-line>");
                    Console.Write("\n\tF. Obliczanie średniej arytmatycznej<method-call>");
                    Console.Write("\n\tG. Obliczanie średniej ważonej<in-line>");
                    Console.Write("\n\tH. Obliczanie średniej ważonej<method-call>");
                    Console.Write("\n\tI. Obliczanie ceny jednostki paszy<in-line>");
                    Console.Write("\n\tJ. Obliczanie ceny jednostki paszy<method-call>");
                    Console.Write("\n\tK. Obliczanie średniej harmonicznej<in-line>");
                    Console.Write("\n\tL. Obliczanie średniej harmonicznej<method-call>");
                    Console.Write("\n\tM. Obliczanie średniej geomertycznej<in-line>");
                    Console.Write("\n\tN. Obliczanie średniej geometrycznej<method-call>");
                    Console.Write("\n\tO. Obliczanie średniej kwadratowe> <in-line>");
                    Console.Write("\n\tP. Obliczanie średniej kwadratowej<method-call");
                    Console.Write("\n\tQ. Obliczanie średniej potęgowej(uogulnionej)> <in-line>");
                    Console.Write("\n\tR. Obliczanie średniej potęgowej(uogulnionej)<method-call");
                    Console.Write("\n\tZ. Zakończenie programu");

                    Console.WriteLine("\n\tWybierz odpowednią funkcję naciskając odpowiedni przycisk");
                }
                WybranaFunkcjonalnosc = Console.ReadKey();
                Console.Clear();

                switch (WybranaFunkcjonalnosc.Key)
                {
                    case ConsoleKey.A:
                        Console.Write("\n\tObliczanie sumy");
                        Console.WriteLine("\n\tPodaj licebność ciągu: ");
                        float.TryParse(Console.ReadLine(), out float pbLiczebnosc);
                        Console.WriteLine("\n\tLiczba ciągu wynosi" + pbLiczebnosc);
                        float pbsuma = 0f;
                        for (int i = 0; i < pbLiczebnosc; i++)
                        {
                            Console.WriteLine("\n\tPodaj {0} liczbę ciągu", i + 1);
                            float.TryParse(Console.ReadLine(), out float n);
                            pbsuma = pbsuma + n;
                        }
                        Console.WriteLine("\n\tSuma ciągu liczbowego wnosi: " + pbsuma);

                        break;
                    case ConsoleKey.B:
                        SumaCiagu();
                        break;
                        Console.Clear();
                    case ConsoleKey.C:
                        Console.Write("\n\t Obliczanie iloczynu");
                        int pbn;
                        Console.WriteLine("\n\tPodaj liczebność ciągu");
                        do
                        {
                            Console.Write("\n\tPodaj licznosc ciagu liczbowego: ");

                            while (!int.TryParse(Console.ReadLine(), out pbn))
                            {
                                Console.WriteLine("\n\tERROR: Wystapil niedozwolony znak, sproboj ponownie");
                                Console.Write("\n\tPodaj ponownie licznosc ciagu liczbowego: ");
                            }

                            if (pbn <= 0)
                            {
                                Console.WriteLine("\n\tERROR: Wartosc N musi byc wieksza od 0");
                            }
                            Console.WriteLine("");
                        }
                        while (pbn <= 0);
                        Console.WriteLine("\n\tLiczba Ciągu wynosi:" + pbn);
                        float pbiloczyn = 1;
                        for (int i = 0; i < pbn; i++)
                        {
                            Console.WriteLine("\t\nPodaj {0} liczbę ciągu: ", i + 1);
                            float.TryParse(Console.ReadLine(), out float pbNastepna);
                            pbiloczyn = pbiloczyn * pbNastepna;
                        }
                        Console.WriteLine("\n\tIloczyn ciągu liczbowego jest równy: " + pbiloczyn);

                        break;
                        
                    case ConsoleKey.D:
                        IloczynCiagu();
                        break;
                        Console.Clear();
                    case ConsoleKey.E:
                        Console.Write("\n\tObliczanie średniej arytmatycznej");
                        Console.WriteLine("\n\tPodaj liczebność ciągu");
                        do
                        {
                            Console.Write("\n\tPodaj licznosc ciagu liczbowego: ");

                            while (!int.TryParse(Console.ReadLine(), out pbn))
                            {
                                Console.WriteLine("\n\tERROR: Wystapil niedozwolony znak, sproboj ponownie");
                                Console.Write("\n\tPodaj ponownie licznosc ciagu liczbowego: ");
                            }

                            if (pbn <= 0)
                            {
                                Console.WriteLine("\n\tERROR: Wartosc N musi byc wieksza od 0");
                            }
                            Console.WriteLine("");
                        }
                        while (pbn <= 0);
                        Console.WriteLine("\n\tLiczba Ciągu wynosi:" + pbn);
                        float pbSuma = 0;

                        for (int i = 0; i < pbn; i++)
                        {
                            float pbNext;
                            Console.WriteLine("\n\tPodaj {0} wyraz ciągu: ", i + 1);
                            while (!float.TryParse(Console.ReadLine(), out pbNext))
                            {
                                Console.WriteLine("\n\tERROR: Wystapil niedozwolony znak, sproboj ponownie");
                                Console.Write("\n\tPodaj ponownie wyraz ciagu liczbowego: ");
                            }
                            pbSuma = pbSuma + pbNext;
                        }

                        Console.WriteLine("\n\tŚrednia arytmetyczna podanego ciągu liczbowego jest równa:" + pbSuma / pbn);
                        break;
                        Console.Clear();
                    case ConsoleKey.F:
                        SredniaCiagu();
                        break;
                        Console.Clear();
                    case ConsoleKey.G:
                        Console.WriteLine("\n\t Obliczanie średniej ważonej");
                        Console.WriteLine("Podaj liczebność ciągu");
                        do
                        {
                            Console.Write("\n\tPodaj licznosc ciagu liczbowego: ");

                            while (!int.TryParse(Console.ReadLine(), out pbn))
                            {
                                Console.WriteLine("\n\tERROR: Wystapil niedozwolony znak, sproboj ponownie");
                                Console.Write("\n\tPodaj ponownie licznosc ciagu liczbowego: ");
                            }

                            if (pbn <= 0)
                            {
                                Console.WriteLine("\n\tERROR: Wartosc N musi byc wieksza od 0");
                            }
                            Console.WriteLine("");
                        }
                        while (pbn <= 0);
                        Console.WriteLine("\n\tLiczba Ciągu wynosi:" + pbn);
                       
                        float pbsum = 0;
                        float pbnext;
                        for (int i = 0; i < pbn; i++)
                        {
                            Console.WriteLine("\n\tPodaj {0} liczbę ciągu", i + 1);
                            pbnext = pobierzFloat();

                            pbsum = pbsum + pbnext;
                        }
                        float pbsrednia = pbsum / pbn;
                        Console.WriteLine("\n\tŚrednia podanego ciągu wynosi" + pbsrednia);
                        break;
                        Console.Clear();
                    case ConsoleKey.H:
                        SredniaWazona();
                        break;
                        Console.Clear();
                    case ConsoleKey.I:
                        Console.WriteLine("\n\tObliczanie jednostki paszy dostepne metodą method call ");

                        break;
                        Console.Clear();
                    case ConsoleKey.J:
                        CenaJednostkiPaszy();
                        break;
                        Console.Clear();
                    case ConsoleKey.K:
                        Console.WriteLine("\n\tObliczanie średniej harmonicznej dostepne w method call (H)");
                       
                        break;
                        Console.Clear();
                    case ConsoleKey.L:
                        SredniaHarmoniczna();
                        break;
                        Console.Clear();
                    case ConsoleKey.M:
                        Console.WriteLine("\n\tObliczanie średniej geomatrycznej dostępne metodą method-call(N) ");
                       
                        break;
                        Console.Clear();
                    case ConsoleKey.N:
                        SredniaGeometryczna();
                        break;
                        Console.Clear();
                    case ConsoleKey.O:
                        Console.WriteLine("\n\tbliczanie średniej kwadratowej dostępne metodą method-call (P)");

                        break;
                        Console.Clear();
                    case ConsoleKey.P:
                        SredniaKwadratowa();
                        break;
                        Console.Clear();
                    case ConsoleKey.Q:
                        Console.WriteLine("\n\tObliczanie średniej potęgowej dostępne w metodzie method-call(Q)");
                        break;
                        Console.Clear();
                    case ConsoleKey.R:
                        SredniaPotegowa();
                        break;
                        Console.Clear();


                    default:
                        
                        Console.Clear();
                        Console.WriteLine("\n\tNie wykryto funkcjonalności pod tym klawiszem");
                        Console.WriteLine("\n\tDla kontyunuacji naciśnij dowolny klawisz");
                        Console.ReadKey();
                        break;

                }
                



            } while (!(WybranaFunkcjonalnosc.Key == ConsoleKey.Z));
            Console.WriteLine("\n\t\t\tKoniec działania programu. Przygotował: Piotr Bordziak");
            Console.WriteLine("\n\t\t\tNaciśnij dowolny przycisk by przerwać");
            System.Console.ReadKey();
        }
        static float pobierzFloat()
        {
            float pbn;
            while (!float.TryParse(Console.ReadLine(), out pbn))
            {
                Console.WriteLine("\n\tERROR: Wystapil niedozwolony znak, sproboj ponownie");
                Console.Write("\n\tPodaj ponownie liczbę: ");
            }
            return pbn;
        }
        static int liczCiagu()
        {
            int pbn;

            do
            {
                Console.Write("\n\tPodaj licznosc ciagu liczbowego: ");

                while (!int.TryParse(Console.ReadLine(), out pbn))
                {
                    Console.WriteLine("\nERROR: Wystapil niedozwolony znak, sproboj ponownie");
                    Console.Write("\nPodaj ponownie licznosc ciagu liczbowego: ");
                }

                if (pbn <= 0)
                {
                    Console.WriteLine("\nERROR: Wartosc N musi byc wieksza od 0");
                }
                Console.WriteLine("");
            }
            while (pbn <= 0);
            Console.WriteLine("\n\tLiczba Ciągu wynosi:" + pbn);
            return pbn;


        }


        static void SumaCiagu()
        {
            Console.Write("\n\tObliczanie sumy");
            int liczebnoscCiagu = liczCiagu();


            float suma = 0;
            for (int i = 0; i < liczebnoscCiagu; i++)
            {
                Console.WriteLine("\n\tPodaj {0} liczbę ciągu ", i + 1);
                int nLiczba = int.Parse(Console.ReadLine());
                suma = suma + nLiczba;
            }
            Console.Clear();
            Console.WriteLine("\n\tSuma ciągu wynosi: " + suma);
        }
        static void IloczynCiagu()
        {
            Console.Write("\n\t Obliczanie iloczynu");
            int licznoscCiagu = liczCiagu();
            float pbiloczyn = 1;
            for (int i = 0; i < licznoscCiagu; i++)
            {
                Console.WriteLine("\n\tPodaj {0} liczbę ciągu: ", i + 1);
                float.TryParse(Console.ReadLine(), out float pbNastepna);
                pbiloczyn = pbiloczyn * pbNastepna;
            }
            Console.WriteLine("\n\tIloczyn ciągu liczbowego jest równy: " + pbiloczyn);

        }
        static void SredniaCiagu()
        {
            Console.Write("\n\t Obliczanie średniej arytmatycznej");
            int pbn = liczCiagu();
            float pbsuma = 0;
            float pbnext;
            for (int i = 0; i < pbn; i++)
            {
                Console.WriteLine("\n\tPodaj {0} liczbę ciągu", i + 1);
                pbnext = pobierzFloat();

                pbsuma = pbsuma + pbnext;
            }
            float pbsrednia = pbsuma / pbn;
            Console.WriteLine("\n\tŚrednia podanego ciągu wynosi" + pbsrednia);

        }
        static void SredniaWazona()
        {
            Console.Write("\n\tObliczanie średniej ważonej>");
            int pbn = liczCiagu();
            float pbsuma = 0;
            float pbnext;
            float pbwaga;
            float pbSumaWag = 0;
            for (int i = 0; i < pbn; i++)
            {
                Console.WriteLine("\n\tPodaj {0} liczbę ciągu", i + 1);
                pbnext = pobierzFloat();
                Console.WriteLine("\n\tPodaj wagę podanego wyrazu ciągu: ");
                pbwaga = pobierzFloat();

                pbsuma = pbsuma + pbnext * pbwaga;
                pbSumaWag = pbSumaWag + pbwaga;
            }
            float srednia = pbsuma / pbSumaWag;
            Console.WriteLine("\n\tŚrednia podanego ciągu wynosi" + srednia);
        }
        static void SredniaHarmoniczna()
        {
            Console.WriteLine("\n\tObliczanie średniej harmonicznej: ");
            float pbsumaOdwrotna = 0;
            float bpnext;
            int pbn = liczCiagu();
            for (int i = 0; i < pbn; i++)
            {
                Console.WriteLine("\n\tPodaj {0} liczbę ciągu", i + 1);
                bpnext = pobierzFloat();

                pbsumaOdwrotna = pbsumaOdwrotna + (1 / bpnext);

            }
            float srednia = pbn / pbsumaOdwrotna;
            Console.WriteLine("\n\tŚrednia podanego ciągu wynosi" + srednia);
        }
        static void SredniaGeometryczna()
        {
            Console.WriteLine("\n\tObliczanie średniej geomatrycznej: ");
            double pbnext;
            double pbn = liczCiagu();
            double pbiloraz = 1;
            for (int i = 0; i < pbn; i++)
            {
                Console.WriteLine("\n\tPodaj {0} wyraz ciągu", i + 1);
                pbnext = pobierzFloat();
                pbiloraz = pbiloraz * pbnext;
            }
            double pbpower = 1 / pbn;
            double pbwynik = Math.Pow(pbiloraz, pbpower);
            Console.WriteLine("\n\tŚrednia geometryczna wynosi: " + pbwynik);
        }
        static void SredniaKwadratowa()
        {
            Console.WriteLine("\n\tObliczanie średniej kwadratowej");
            double pbn = liczCiagu();
            double pbsuma = 0;
            double pbnext;
            for (int i = 0; i < pbn; i++)
            {
                Console.WriteLine("\n\tPodaj {0} liczbę ciągu", i + 1);
                pbnext = pobierzFloat();

                pbsuma = pbsuma + pbnext * pbnext;
            }
            double pbsrednia = Math.Sqrt(pbsuma / pbn);
            Console.WriteLine("\n\tŚrednia podanego ciągu wynosi" + pbsrednia);
        }
        static void SredniaPotegowa()
        {

            Console.WriteLine("\n\tOliczanie średniej kwadratowej");
            Console.WriteLine("\n\tPodaj wartość k rzędu średniej: ");
            int.TryParse(Console.ReadLine(), out int pbk);
            double pbn = liczCiagu();
            double pbsuma = 0;
            double pbnext;
            
            for (int i = 0; i < pbn; i++)
            {
                Console.WriteLine("\n\tPodaj {0} liczbę ciągu", i + 1);
                pbnext = pobierzFloat();

                for (int j = 0; j < pbk; j++)
                {
                    pbnext = pbnext * pbnext;
                }
                pbsuma = pbsuma + pbnext;
                
            }
            double pbsrednia = Math.Sqrt(pbsuma / pbn);
            Console.WriteLine("\n\tŚrednia kwadratowa {0} rzędu wynosi podanego ciągu wynosi : {1}", pbk, pbsrednia);
        }
        static void CenaJednostkiPaszy()
        {
            Console.WriteLine("Obliczanie ceny jednostki paszy: ");
            Console.WriteLine("Podaj ilość składników: ");
            int pbis;
            while (!int.TryParse(Console.ReadLine(), out pbis) /*|| (pbis > 0 )*/)
            {
                Console.WriteLine("ERROR: Wystąpił niedozwolony błąd");
                Console.WriteLine("Podaj ponownie odpowiedni format ilości składników");
                    if (pbis <= 0)
                    {
                    Console.WriteLine("Ilość składników musi być większa od zera aby operacja miała sens. Podaj wartość większą od zera.");
                    }
                    
            
            }
            float c, m, cena, licznik = 0, mianownik = 0;
            for (int i = 0; i < pbis; i++)
            {
                Console.WriteLine("Podaj mase {0} skłądnika:", i+1);
                m = pobierzFloat();
                Console.WriteLine("Podaj cenę {0} składnika", i+1);
                c = pobierzFloat();

                licznik = licznik + m * c;
                mianownik = mianownik + m;
                
            }
            cena = licznik / mianownik;
            Console.WriteLine("Cena jedostki paszy wynosi: "+cena);
           
        }
    }
}
