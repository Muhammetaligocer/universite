string[] ogretmen = { "Muhammet", "Burak", "Umut", "Mali", "Yaver","haci" };
string[] sehir = { "Suriye", "Afganistan","Türkiye","Almanya","Amerika","Ermenistan" };


Random random = new Random();

random.Shuffle(sehir);
random.Shuffle(ogretmen);

for (int i = 0; i < sehir.Length; i++)
{
    Console.WriteLine(sehir[i] + " " + ogretmen[i]);
}