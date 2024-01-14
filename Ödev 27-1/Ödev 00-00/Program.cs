Console.WriteLine("Araç türünü giriniz :");
string aracturu  = Console.ReadLine();

Console.WriteLine("Kalınacak saati seçiniz :");
int kalinansaat  =Convert.ToInt32(Console.ReadLine());

int kalinangun = kalinansaat / 24;
int kalansaat = kalinansaat  % 24;
int odeme = 0;
if(aracturu == "O")
{
    if(kalansaat <= 2 && kalansaat >=1)
    {
        odeme = 5 + (kalinangun * 13);
        Console.WriteLine("ödemeniz için gereken tutar " + odeme);
    }
    else if(kalansaat >= 3 && kalansaat <= 10){
        odeme = 5 + ((kalansaat - 2)* 1)+ (kalinangun * 13);
        Console.WriteLine("ödemeniz için gereken tutar " + odeme);
    }
    else if (kalansaat > 10)
    {
        odeme = 13 + (kalinangun * 13);
        Console.WriteLine("ödemeniz için gereken tutar " + odeme);
    }
    else if (kalansaat == 0 || kalansaat == 24)
    {
        odeme =  (kalinangun * 13);
        Console.WriteLine("ödemeniz için gereken tutar " + odeme);

    }
    else
    {
        Console.WriteLine("Hatalı veri girdiniz tekrar deneyiniz");
    }
}
else if(aracturu == "K")
{
    if (kalansaat <= 2 && kalansaat >= 1)
    {
        odeme = 8 + (kalinangun *24);
        Console.WriteLine("ödemeniz için gereken tutar " + odeme);
    }
    else if (kalansaat >= 3 && kalansaat <= 10)
    {
        odeme = 8 + ((kalansaat - 2) * 2) + (kalinangun * 24);
        Console.WriteLine("ödemeniz için gereken tutar " + odeme);
    }
    else if (kalansaat > 10)
    {
        odeme = 24 +(kalinangun * 24);
        Console.WriteLine("ödemeniz için gereken tutar " + odeme);
    }
    else if (kalansaat == 0 || kalansaat == 24)
    {
        odeme = (kalinangun * 24);
        Console.WriteLine("ödemeniz için gereken tutar " + odeme);
    }
    else
    {
        Console.WriteLine("Hatalı veri girdiniz tekrar deneyiniz");
    }


}
else if (aracturu == "İ")
{
    if (kalansaat <= 2 && kalansaat >= 1)
    {
        odeme = 12 + (kalinangun * 36);
        Console.WriteLine("ödemeniz için gereken tutar " + odeme);
    }
    else if (kalansaat >= 3 && kalansaat <= 10)
    {
        odeme = 12 + ((kalansaat - 2) * 3) + (kalinangun * 36);
        Console.WriteLine("ödemeniz için gereken tutar " + odeme);
    }
    else if (kalansaat > 10)
    {
        odeme = 36 + (kalinangun * 36);
        Console.WriteLine("ödemeniz için gereken tutar " + odeme);
    }
    else if (kalansaat == 0 || kalansaat == 24)
    {
        odeme = (kalinangun * 36);
        Console.WriteLine("ödemeniz için gereken tutar " + odeme);

    }
    else
    {
        Console.WriteLine("Hatalı veri girdiniz tekrar deneyiniz");
    }
}


