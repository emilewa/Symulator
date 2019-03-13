using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Projekt4
{
    public static class metody
    {
// Zamiana z tekstu na binarny
//******************************************************************
        //zmiana na binarny jednej litery
        private static bool[] ZamienZnakNaBinarny(char x)
        {
            int kodznaku = (int)x;
            bool[] nabinarny = new bool[8];

            nabinarny = NaBinarny(kodznaku);


            return (nabinarny);
        }

        //zamiana koduznaku na binarny
        private static bool[] NaBinarny(int x)
        {
            int liczba = x;
            bool[] binarna = new bool[16];
            bool[] binarnaodwrocona = new bool[16];
            for (int i = 15; i >= 0; i--)
            {
                if (liczba % 2 == 1) binarna[i] = true;
                else binarna[i] = false;
                liczba /= 2;
            }


            for (int i = 0; i < binarna.Length; i++)
            {
                binarnaodwrocona[i] = binarna[binarna.Length - 1 - i];
            }

            bool[] slowoBinarne = new bool[11];
            slowoBinarne = PlusbitStartiStop(binarnaodwrocona);

            return slowoBinarne;
        }

        //Dodanie bitu 1 startu i 2 stopu [11] 
        private static bool[] PlusbitStartiStop(bool[] x)
        {
            bool[] zbitamistopuistartu = new bool[11]; 
            zbitamistopuistartu[0] = false;
            for (int i = 0; i < 8; i++)
            {
                zbitamistopuistartu[i + 1] = x[i];
            }
            zbitamistopuistartu[9] = true;
            zbitamistopuistartu[10] = true;

            return zbitamistopuistartu;
        }

        //zamienia tekst na słowa binarne, tworzy tablice binarnie słów binarnych
        public static bool[][] lancuchNaSlowaBinarne(string tekst)
        {
            bool[][] tablicaslowBinarnie = new bool[tekst.Length][];
            for (int i = 0; i < tekst.Length; i++)
            {
                tablicaslowBinarnie[i] = NaBinarny(tekst[i]);
            }
            return tablicaslowBinarnie;
        }

        //Zamienia na Stringa tablice bool[]
        private static string BinarnanaText(bool[] nr)
        {
            string wypisywanebinarnie = "";
            for (int i = 0; i < nr.Length; i++)
            {
                if (nr[i]) wypisywanebinarnie = wypisywanebinarnie + "1";
                else wypisywanebinarnie = wypisywanebinarnie + "0";
            }
            return (wypisywanebinarnie);
        }

        //Wypisuje
        public static string piszcaloscText(bool[][] nr)
        {
            string z = "";
            int i = 0;
            foreach (bool[] x in nr)
            {
                z += (BinarnanaText(x) + "  ");
            }
            return z;
        }
//*********************************************************************

// Zamiana z binarnego na łańcuch
//*********************************************************************
        //binarna na liczbe
        private static int binarnanaliczbe(bool[] binarna)
        {
            int liczba = 0;
            int n = 1;
            for (int i = binarna.Length - 1; i >= 0; i--)
            {
                if (binarna[i])
                {
                    liczba += n;
                }
                n *= 2;
            }
            return liczba;
        }

        //usuwa bit startu i stopu
        private static bool[] usunstartstop(bool[] x)
        {
            bool[] b = new bool[8];
            for (int i = 0; i < 8; i++)
            {
                b[i] = x[i + 1];
            }
            return b;
        }

        //Zamienia liczbe binarna na znak char
        private static char binarnanazchar(bool[] binarna)
        {
            bool[] bajt = new bool[8];
            bool[] binarnaodwrocona = new bool[8];
            bajt = usunstartstop(binarna);

            for (int i = 0; i < bajt.Length; i++)
            {
                binarnaodwrocona[i] = bajt[bajt.Length - 1 - i];
            }

            int kodASCIIZnaku = binarnanaliczbe(binarnaodwrocona);
            char znak = (char)kodASCIIZnaku;
            return znak;
        }

        // Zamienia całe słowo binarne na ciag znaków char = > String słowo
        public static string binarnenastring(bool[][] binarneslowo)
        {
            string s = "";
            foreach (bool[] x in binarneslowo)
            {
                s += binarnanazchar(x);
            }
            return s;
        }
//*********************************************************************


//Cenzura
//********************************************************************* 
  internal static string cenzuruj(string tekst)
        {
            String x="";
            char spacja=' ';
            String docenzury = "";

            for (int i = 0; i < tekst.Length; ++i)
            {
               
                if (tekst[i] == spacja)
                {
                    x = x + czycenzura(docenzury);

                    docenzury = "";
                }
                docenzury = docenzury + tekst[i];
            }
            if(docenzury != "") x = x + czycenzura(docenzury);


            return (x);
        }

        //Cenzura pojedynczego slowa / gwiazdki ***
        public static string cenzurajednegoslowa(string docenzury)
        {
            StringBuilder tekst = new StringBuilder(docenzury);
            string gwiazdki = "";
            
                for (int j = 0; j < docenzury.Length; j++)
                {
                    gwiazdki += "*";
                }
            return (gwiazdki);
        }

        //szuka w pliku czy podane słowo podlega cenzurze i zwraca z cenzura lub bez
        public static String czycenzura(String x)
        {
            String z=x;

            //otwórz plik i sprawdz czy x wystepuje jesli tak to z = cenzurajednegoslow(x);


            StreamReader R = new StreamReader(("C:/Users/Emilia/Documents/Visual Studio 2015/Projects/CPUprocesor/Projekt4/slowa.txt"), true);
            String linijka;
            while ((linijka = R.ReadLine())!=null)
            {
                linijka = linijka.ToLower();
                x = x.ToLower();
                if(linijka == x)
                {
                    z =cenzurajednegoslowa(x);
                }else 
                    if(" " + linijka == x)
                {
                    z = " " + cenzurajednegoslowa(x);
                }
            }

            return (z);
        }

//*********************************************************************
    }
}
