double[] burslar = { 150, 600, 700, 450, 850, 275, 950, 1500, 210, 368 };

int a = 0;
foreach (int c in burslar){
    
    if (c < 500)
    {
        burslar[a] += burslar[a] * 0.1 +50;
    }
    Console.WriteLine(burslar[a++]);
    
}


