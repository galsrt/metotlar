// See https://aka.ms/new-console-template for more information
using metotlar;

Console.WriteLine("Hello, World!");



string urunAdi = "Elma";
double fiyati = 15;
string açiklama = "Amasya elmasi";

string[] meyveler = new string[] { };

Urun urun1 = new Urun();
urun1.Adi = "elma";
urun1.Fiyat = 15;
urun1.Aciklama = "Amasya elması";

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyat = 80;
urun2.Aciklama = "Diyarbakır karpuzu";

Urun[] urunler = new Urun[] {urun1,urun2 };

foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyat);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("-----------------");
}

Console.WriteLine("--------Metotlar-------");

sepetManager sepetManager = new sepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("Armut", "Yeşil armut", 12,10);
sepetManager.Ekle2("Elma", "Yeşil elma", 12,9);
sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,8);

