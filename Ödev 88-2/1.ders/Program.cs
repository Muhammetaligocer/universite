int i ;
int enbuyuk = 0;
int ortalama =0;
int toplam = 0;
int enkucuk =100;

string []ogr ={"Raşit","Yaver","Mali","Burak","Muhammet","Umutcan"};
int []not ={30,25,99,48,12,99};

for(i=0; i < ogr.Length; i++){
   if(not[i] > enbuyuk){
      enbuyuk = not[i];
   }

}
Console.WriteLine("En yüksek not {0}",enbuyuk);
for(i=0; i < ogr.Length; i++){
   if(not[i] == enbuyuk){
      enbuyuk = not[i];
      Console.WriteLine("En yüksek not alanlar {0}",ogr[i]);
   }
}

for(i=0; i<ogr.Length; i++){
   if(not[i]<enkucuk){
         enkucuk=not[i];
         
   }
}
Console.WriteLine("En düşük not {0}",enkucuk);

for(i=0; i<ogr.Length; i++){
   if(not[i] == enkucuk){
         enkucuk = not[i];
Console.WriteLine("En düşük not alanlar {0}",ogr[i]);
   }
}

for(i=0; i<ogr.Length; i++){
      toplam = toplam + not[i];
      if(i == 5){
         ortalama = toplam / ogr.Length;
      }
}
Console.WriteLine("Sınıfın not ortalaması {0}",ortalama);   

