Console.WriteLine("Kaç adet sayı girmek istersiniz : ");
int adet =Convert.ToInt32(Console.ReadLine());
float toplam = 0;
float ortalama = 0;

for (int i = 1; i <= adet; i++)
{
    Console.WriteLine("{0}.Sayı giriniz",i);
    int sayi = Convert.ToInt32(Console.ReadLine());
    toplam += sayi;
}
ortalama = toplam / adet;
Console.WriteLine("Girdiğiniz {0} adet sayının toplamı {1}",adet,toplam);
Console.WriteLine("Girdiğiniz {0} adet sayının ortalaması {1}", adet,ortalama);
