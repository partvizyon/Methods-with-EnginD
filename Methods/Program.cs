using System;

namespace Methods
{
   class Program
   {
      static void Main(string[] args)
      {
         string urunAdi = "Elma";
         double fiyati = 15;
         string aciklama = "Amasya Elması";

         string[] meyveler = new string[] { "Elma", "Karpuz" };

         Urun urun1 = new Urun();
         urun1.Adi = "Elma";
         urun1.Fiyati = 15;
         urun1.Aciklama = "Amasya Elma";

         Urun urun2 = new Urun();
         urun2.Adi = "Karpuz";
         urun2.Fiyati = 80;
         urun2.Aciklama = "Diyarbakır Karpuz";

         Urun urun3 = new Urun();
         urun3.Adi = "Çilek";
         urun3.Fiyati = 25;
         urun3.Aciklama = "Akdeniz Çilek";

         Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

         // type-safe -- tip güvenli
         foreach (Urun urun in urunler)
         {
            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.Fiyati);
            Console.WriteLine(urun.Aciklama);
            Console.WriteLine("--------------");
         }

         Console.WriteLine("---------Methods---------");

         // Instance - Ornek
         // Encapsulation
         SepetManager sepetManager = new SepetManager();

         sepetManager.Ekle(urun1);
         sepetManager.Ekle(urun2);
         sepetManager.Ekle(urun3);
         
         sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 20);
         sepetManager.Ekle2("Elma", "Yeşil Elma", 20, 40);
         sepetManager.Ekle2("Karpuz", "Kesmece Karpuz", 80, 70);
      }
   }
}

// Don't repeat yourself - DRY
// Clean Code
// Best Practice