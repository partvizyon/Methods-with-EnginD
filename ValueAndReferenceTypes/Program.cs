using System;

namespace ValueAndReferenceTypes
{
   class Program
   {
      static void Main(string[] args)
      {

         int sayi1 = 10;
         int sayi2 = 30;
         sayi1 = sayi2;
         sayi2 = 65;
         //sayi1 ??  Cevap:30

         Console.WriteLine(sayi1);
         // int, decimal, float, double, bool 0 değer tiptir.

         int[] sayilar1 = new int[] { 10, 20, 30 };
         int[] sayilar2 = new int[] { 100, 200, 300 };
         sayilar1 = sayilar2;
         sayilar2[0] = 999;

         Console.WriteLine(sayilar2[0]);
         //sayilar[0]  Cevap 999

         // array, class, interface = referans tip.
         // Bellekte stasck ve heap şeklinde 2 alan var.
         // Değer tip olanlar STACK te tanımlanır.

         // Referans tipler ise Heap'te tanımlanır.
      }
   }
}
