using System.Collections.Generic;
using System.Collections;
using System;




//Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

/*
Negatif ve numeric olmayan girişleri engelleyin.
Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
*/
//Liste oluştur.
ArrayList asalSayilar = new ArrayList(); 
ArrayList asalOlmayanSayilar = new ArrayList();
bool sonuc ;


// Kullanıcıdan 20 sayının isteneceği for döngüsü 
for(int i =0 ; i<20;i++)
{
    Console.WriteLine($"Lütfen {i+1}. sayıyı giriniz");
    //Kullanıcının girdiği sayıları int türüne çevirmeyi nedeyen kod(Eğer çevirebilirse outSayi isminde değişkene atama yapar ve bool sonuç döner)
    sonuc = int.TryParse(Console.ReadLine(), out int outSayi);
    
    //Eğer girilen sayı int tipine dönüştürülürse aşağıdaki kodlar çalışacaktır.
    if (sonuc)
    {
        // sayının pozitif olup olmadığını kontrol eden kod.
        if(outSayi>0)
        {
            // Asal sayı hesaplamasını yapan fonksiyon
            int sayi1 = Asalmi(outSayi);
            if(sayi1 != 0)
            {
            asalSayilar.Add(outSayi);
            }
             else 
            {
            asalOlmayanSayilar.Add(outSayi);
            }
        }
        else 
        {
            Console.WriteLine("Pozitif sayı girmelisiniz!");
        }
        
        
    }else 
    {
        Console.WriteLine("Lütfen sayi girdiğinizden emin olunuz!");
    }
}
//Listeyi küçükten büyüğe sıralar
asalSayilar.Sort();
//Diziyi ters çevirir
asalSayilar.Reverse();
foreach(var item in asalSayilar)
{
    System.Console.WriteLine("Girilen Sayılardan Asal Olanları: "+item);
}
asalOlmayanSayilar.Sort();
asalOlmayanSayilar.Reverse();
foreach(var item in asalOlmayanSayilar)
{
    System.Console.WriteLine("Girilen Sayılardan Asal olmayanlar: "+item);
}
//Dizilerin eleman sayılarını ekrana yazdıran kod
Console.WriteLine("Asal Olan Listenin Eleman Sayısı: "+asalSayilar.Count);
Console.WriteLine("Asal Olmayan Listenin Eleman Sayısı: "+asalOlmayanSayilar.Count);

int toplam1 = 0;
int toplam2 = 0;

foreach (int item in asalSayilar)
{
    toplam1 = toplam1+item;
}
Console.WriteLine("Asal Olan Sayıların Ortalaması: "+ (toplam1/asalSayilar.Count));
foreach (int item in asalOlmayanSayilar)
{
    toplam2 += item;
}
Console.WriteLine("Asal Olmayan Sayıların Ortalaması: "+ (toplam2/asalOlmayanSayilar.Count));




//Sayının asal olup olmadığını kontrol eden metot


static int Asalmi(int sayi)
{
    int i;
    for (i = 2; i <= sayi - 1; i++)
    {
        if (sayi % i == 0)
        {
            return 0;
        }
    }
        if (i == sayi)
        {
            return 1;
        }
            return 0;
}



/*
Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. 
(Array sınıfını kullanarak yazınız.)
*/

ArrayList girilenSayilar = new ArrayList();
for(int i = 0 ; i<20 ;i++)
{
    Console.WriteLine($"Lütfen {i+1}. sayıyı girin");
    girilenSayilar.Add(int.Parse(Console.ReadLine()));
}
List<int> _intList = new List<int>();
foreach (int item in girilenSayilar)
{
    _intList.Add(item);    
}

_intList.Sort();
Console.WriteLine("En küçük 3 sayı sırasıyla: "+_intList[0]+" "+_intList[1]+" "+_intList[2]);
int enKucukOrtalama = (_intList[0]+_intList[1]+_intList[2])/3;
Console.WriteLine("Girilen en küçükm 3 sayının ortalaması: "+enKucukOrtalama);
_intList.Reverse();
Console.WriteLine("En büyük 3 sayı sırasıyla: "+_intList[0]+" "+_intList[1]+" "+_intList[2]);
int enBuyukOrtamala = (_intList[0]+_intList[1]+_intList[2])/3;
Console.WriteLine("Girilen en büyük 3 sayının ortalaması: "+enBuyukOrtamala);
Console.WriteLine("En büyük ve en küçük sayıların ortalamasının toplamı: "+enKucukOrtalama+enBuyukOrtamala);

/*
Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi 
içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
*/

//Kullanmak Üzere sesli harfleri içeren string değişkeni olutur.
string sesli = "aAeEıIiİoOöÖuUüÜ";

//Sesli Harfleri tutacağımız ArrayList 
ArrayList sesliHarfler = new ArrayList();
Console.WriteLine("Lütfen Bir Cümle Giriniz!");
string girilenCumle = Console.ReadLine();
//Girilen Cümledeki sesli harfleri kontrol eden for döngüsü
for(int i = 0; i<girilenCumle.Length; i++)
{
    if(sesli.Contains(girilenCumle[i]))
    {
        sesliHarfler.Add(girilenCumle[i]);
    }
}
//Liste içerisindeki sesli harfleri sırala
sesliHarfler.Sort();
Console.WriteLine("Girilen Cümledeki Sesli Harfler Sırasıyla: ");
//Listeyi Ekrana Yazdır.
foreach (var item in sesliHarfler)
{
    Console.Write(item+",");
}