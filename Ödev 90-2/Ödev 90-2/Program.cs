//int a ;
//string s = " ";
//string[] Birler = { "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
//string[] Onlar = { "On ", "Yirmi ", "Otuz ", "Kırk ", "Elli ", "Altmış ", "Yetmiş ", "Seksen ", "Doksan " };
//string[] yüzler = {"yüz ","iki yüz ","üç yüz ","dört yüz ","beş yüz ","altı yüz ","yedi yüz ","sekiz yüz ","dokuz yüz "};


//Console.Write("Bir Sayı Giriniz: ");
//a = Convert.ToInt32(Console.ReadLine());


//if (a / 100 > 0)
//{
//  s = s + yüzler[(a / 100)-1];
//     a = a % 100;
//}else if (a / 100 < 0)
//{
//    s = s + "eksi "+ yüzler[(Math.Abs(a / 100))-1];
//    a = Math.Abs(a % 100);
//}

//if (a / 10 >= 1)
//{
//    s =  s + Onlar[(a / 10) - 1];

//}


//if (a % 10 != 0)
//{
//    s = s + Birler[(a % 10) - 1];

//}

//Console.WriteLine(s);
//Console.Write("Press any key to continue . . . ");
//Console.ReadKey(true);











//Console.WriteLine("Sayı giriniz");

//int sayi = Convert.ToInt32(Console.ReadLine());

//string s = " ";

//string[] yüzler = { "yüz ", "iki yüz ", "üç yüz ", "dört yüz ", "beş yüz ", "altı yüz ", "yedi yüz ", "sekiz yüz ", "dokuz yüz " };
//string[] onlar = { "on ", "yirmi ", "otuz ", "kırk ", "elli ", "altmış ", "yetmiş ", "seksen ", "doksan " };
//string[] birler = { "bir ", "iki ", "üç ", "dört ", "beş ", "altı ", "yedi ", "sekiz ", "dokuz " };
//if (sayi < 0)
//{
//    s = "Eksi ";
//    sayi = Math.Abs(sayi);

//}
//if (sayi / 100 > 0)
//{
//    s = s + yüzler[(sayi / 100) - 1];
//    sayi = sayi % 100;

//}

//if (sayi / 10 > 0)
//{
//    s = s + onlar[(sayi / 10) - 1];
//    sayi = sayi % 10;
//}
//if (sayi % 10 > 0)
//{
//    s = s + birler[(sayi % 10) - 1];
//}

//Console.WriteLine(s);
//Console.ReadKey();






Console.WriteLine("Sayı giriniz");

int sayi = Convert.ToInt32(Console.ReadLine());

string s = " ";

string[] yüzler = { "yüz ", "iki yüz ", "üç yüz ", "dört yüz ", "beş yüz ", "altı yüz ", "yedi yüz ", "sekiz yüz ", "dokuz yüz " };
string[] onlar = { "on ", "yirmi ", "otuz ", "kırk ", "elli ", "altmış ", "yetmiş ", "seksen ", "doksan " };
string[] birler = { "bir ", "iki ", "üç ", "dört ", "beş ", "altı ", "yedi ", "sekiz ", "dokuz " };

if (sayi < 0)
{
    s += "Eksi ";
    sayi = Math.Abs(sayi);

}
if (sayi / 100 > 0)
{
    s += yüzler[(sayi / 100) - 1];
    sayi = sayi % 100;
}
if(sayi / 10 > 0)
{
    s += onlar[(sayi / 10) - 1];
    sayi = sayi % 10;
}
if(sayi % 10 > 0)
{
    s += birler[(sayi % 10) - 1];
}
if(sayi == 0)
{
    s = "SIFIR";
}

Console.WriteLine(s);
Console.ReadKey();









