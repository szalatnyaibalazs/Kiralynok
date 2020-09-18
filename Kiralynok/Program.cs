using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiralynok
{
    class Tabla
    {
        char[,] T; 
        char UresCella;
        int UresOszlopokSzama;
        int UresSorokSzama;
        public void Elhelyez(int N)
        {
            /*1.véletlen helyiérték létrehozása
                -Random osztály értékek halmaza(0,7)
                -Kell véletlen sor és oszlop
                -Elhelyezzük a K-t csak akkor ha üres -> '#'*/

            Random vel = new Random();
            for (int i = 0; i < N; i++)
			{
                bool igaz = true;
                while (igaz)
                {
                    int sor = vel.Next(0, 8);
                    int oszlop = vel.Next(0, 8);
                    if (T[sor, oszlop] == '#')
                    {
                        T[sor, oszlop] = 'K';
                        igaz = false;
                    }

                }

            
			}
        }

        public void FajlbaIr()
        {

        }

        public void Megjelenit()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"{T[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        public Tabla(char ch)
        {
            T = new char[8, 8];
            UresCella = ch;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    T[i, j] = UresCella;
                }
            }
        }
        public bool UresOszlop(int oszlop)
        {
            int i = 0;
            while (i<8&&T[i,oszlop]!='K')
            {
                i++;
            }
            if (i<8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool UresSor(int sor)
        {
            int i = 0;
            while (i < 8 && T[sor,i] != 'K')
            {
                i++;
            }
            if (i < 8)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Királynők feladat");


            Tabla t = new Tabla('#');
            Console.WriteLine("Üres tábla: ");
            t.Megjelenit();
            t.Elhelyez(8);
            Console.WriteLine();
            t.Megjelenit();

            Console.WriteLine("8. feladat: az üres oszlopok és sorok száma:");
            int uresSor = 0;
            int uresOszlop = 0;
            for (int i = 0; i < 8; i++)
            {
                if (t.UresOszlop(i))
                {
                    uresOszlop++;
                }
            }
            
            for (int i = 0; i < 8; i++)
            {
                if (t.UresSor(i))
                {
                    uresSor++;
                }
            }
            Console.WriteLine("Oszlopok: {0}", uresOszlop);
            Console.WriteLine("Sorok: {0}",uresSor);
            Console.ReadKey();
        }
    }
}
