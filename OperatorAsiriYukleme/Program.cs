using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorAsiriYukleme
{
    class Dizi {
        public int[,] d_elemanlar;
        public static int boyut;
        
        

        public Dizi(int [,] Elemanlar,int diziboyut) {
           d_elemanlar = Elemanlar;
            boyut = diziboyut;

        }

        public static Dizi operator +(Dizi dizi1,Dizi dizi2) {
            int[,] dizi3=new int[boyut,boyut];
            
            for (int i=0; i<boyut;i++) {
                for (int j=0;j<boyut;j++) {
                    dizi3[i,j] = dizi1.d_elemanlar[i, j] + dizi2.d_elemanlar[i,j];
                }
                

            }
            Dizi donenDizi = new Dizi(dizi3,boyut);
            return donenDizi;
        }

        public static Dizi operator -(Dizi d1,Dizi d2) {
            int[,] dizi4 = new int[boyut,boyut];

            for (int i=0;i<boyut;i++) {
                for (int j = 0; j < boyut; j++) {
                    dizi4[i, j] = d1.d_elemanlar[i, j] - d2.d_elemanlar[i, j];
                }
            }
            Dizi donenDizi = new Dizi(dizi4,boyut);
            return donenDizi;
        }

        public static Dizi operator *(Dizi d1,Dizi d2) {
            int [,] dizi5 = new int[boyut,boyut];

            for (int i=0;i<boyut;i++) {
                for (int j=0;j<boyut;j++) {
                    for (int k=0;k<boyut;k++) {
                        dizi5[i, j] += d1.d_elemanlar[i, k] * d2.d_elemanlar[k,i];
                    }
                }
            }
            Dizi donenDizi = new Dizi(dizi5,boyut);
            return donenDizi;
        }

        public static bool operator ==(Dizi d1,Dizi d2) {
            int sayac = 0;
            for (int i=0;i<boyut;i++) {
                for (int j=0;j<boyut;j++) {
                    if (d1.d_elemanlar[i,j]==d2.d_elemanlar[i,j]) {
                        sayac++;

                    }
                }
            }
            if (sayac == boyut)
            {
                return true;
            }
            else
                return false;
            

        }
        public static bool operator !=(Dizi d1, Dizi d2)
        {
            int sayac = 0;
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    if (d1.d_elemanlar[i, j] == d2.d_elemanlar[i, j])
                    {
                        sayac++;

                    }
                }
            }
            if (sayac == boyut)
            {
                return true;
            }
            else
                return false;

        }

       


    }

    class Program
    {
        static void DiziYaz(int [,] d1,int [,] d2,int boyut) {
            Console.WriteLine("Matris-1");
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    Console.Write(d1[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Matris-2");
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    Console.Write(d2[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        static void DiziTopla(int boyut,Dizi t) {
            Console.WriteLine();
            Console.WriteLine("Toplama");
            

            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    Console.Write(t.d_elemanlar[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
        static void DiziCikar(int boyut, Dizi c)
        {
            Console.WriteLine();
            Console.WriteLine("Çıkarma");
            

            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    Console.Write(c.d_elemanlar[i, j] + " ");
                }
                Console.WriteLine();
            }


        }

        static void DiziCarp(int boyut,Dizi carpmaIslemı) {
            Console.WriteLine();
            Console.WriteLine("Çarpma");

            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    Console.Write(carpmaIslemı.d_elemanlar[i, j] + " ");
                }
                Console.WriteLine();
            }


        }

        static void DiziEsitmi(Dizi dizi1,Dizi dizi2) {
            Console.WriteLine();
            Console.WriteLine("Eşitlik Kontrolü");
            Console.WriteLine(dizi1==dizi2);

        }
        static void Main(string[] args)
        {
            int boyut;
           
            Random rastgele = new Random();
            Console.WriteLine("Boyut girin : ");
            boyut = Convert.ToInt32(Console.ReadLine());

            int[,] d1 = new int[boyut, boyut];
            int[,] d2 = new int[boyut, boyut];

            for (int i=0;i<boyut;i++) {
                for (int j=0;j<boyut;j++){
                    d1[i, j] = rastgele.Next(0,10);
                    d2[i, j] = rastgele.Next(0,10);
                }
            }
            Dizi dizi1 = new Dizi(d1,boyut);
            Dizi dizi2 = new Dizi(d2, boyut);
            Dizi toplama = dizi1 + dizi2;

            Dizi cikarma = dizi1 - dizi2;

            Dizi carpma = dizi1 * dizi2;

            
            DiziYaz(d1,d2,boyut);
            DiziTopla(boyut,toplama);
            DiziCikar(boyut, cikarma);
            DiziCarp(boyut,carpma);
            DiziEsitmi(dizi1,dizi2);

            Console.WriteLine("Yunus");

            Console.ReadKey();

        }
    }
}
