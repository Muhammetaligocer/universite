int i = 0;
int EnBuyuk = 0;
int enkucuk = 100;
int yer = 0;
int ortalama = 0;
int toplam = 0;

String[] ogr = {"Yaver","Mali","Haci","Umut","Burak"};
int[] not = { 56,48,78,78,48};
for (i = 0; i <= ogr.Length - 1; i++)
{
    if (not[i] >= EnBuyuk)
    {
        EnBuyuk = not[i];
        yer = i;
    }
}
Console.WriteLine("En Yüksek Not : " + not[yer]);


for (i = 0; i < ogr.Length; i++)
{
    if(EnBuyuk == not[i])
    {
        Console.WriteLine("En yüksek notları alan kişiler : " + ogr[i]);
    } 
}


for (i=0; i < ogr.Length; i++)
{

    if (not[i] <= enkucuk)
    {
        enkucuk = not[i];
        yer = i;
    }
   
}
Console.WriteLine("En küçük not: " + not[yer]);
for (i = 0; i < ogr.Length; i++)
{
    if(enkucuk == not[i])
    {
        yer = i;
        Console.WriteLine("En düşük notları alan kişiler :" + ogr[yer]);
       
    }
}

for(i = 0;i < not.Length; i++)
{
    toplam +=  not[i];
    
}
ortalama = toplam / not.Length;
Console.WriteLine("Sınıfın ortalaması : " + ortalama);
