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
            int sor = vel.Next(0,7);
            int oszlop = vel.Next(0, 7);
            if (T[sor,oszlop] =='#')
            {
                T[sor, oszlop] = 'K';
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
        public int UresOszlop()
        {

            return 0;
        }

        public int UresSor()
        {

            return 0;
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
            t.Elhelyez(1);
            Console.WriteLine();
            t.Megjelenit();

            Console.ReadKey();
        }
    }
}
