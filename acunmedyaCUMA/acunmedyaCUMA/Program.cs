// See https://aka.ms/new-console-template for more information
using acunmedyaCUMA.Abstracts;
using acunmedyaCUMA.classes;
using System.Collections;
using System.Reflection;

Console.WriteLine("Hello, World!");

//bir class tan nesne oluşturma
//ClassIsmi nesneAdi = new ClassIsmi();
Insan i = new Insan();
i.adi = "ibrahim";
i.soyadi = "gökyar";
i.yas = 46;
i.maas = 3.14;
i.cinsiyet = false;
//metodu çağırmak 
i.uyu("hakan", "yılmaz");
i.uyu(i.adi, i.soyadi);
int gelenYas = i.yasHesapla(1980);
Console.WriteLine("Yasiniz: " + gelenYas);

Araba a = new Araba();
a.marka = "bmw";
a.model = "x5";
a.kapiSayisi = 4;
a.pencereSayisi = 4;
a.git("mercedes", "xl");
a.git(a.marka, a.model);

Matematik m = new Matematik();
//1. yöntem 
int gelenDeger = m.topla(5, 5);
Console.WriteLine("Toplam : " + gelenDeger);

//2.yöntem
Console.WriteLine("Toplam 2. yöntem : " + m.topla(10, 10));

Console.WriteLine("çıkan sonuç : " + m.cikar(5, 5));

Console.WriteLine("Çarpım Sonucu : " + m.carp(10, 10));

Console.WriteLine("Bölüm Sonucu : " + m.bol(10, 10));

Anne an = new Anne();
an.adi = "belgin";
an.soyadi = "turan";
an.ekranaYaz(an.adi, an.soyadi);
an.oku(an.adi);
an.dinle(an.adi);
an.yaz(an.adi);


Baba b = new Baba();
b.ekranaYaz("Kasım", "gökyar");
b.oku("Tuncay");

Cocuk c = new Cocuk();
c.ekranaYaz("ibrahim", "gökyar");

Bmw bm = new Bmw();
//bm.markaModelYaz("Bmw", "X5");
//bm.isim = Bmw; 

Mercedes me = new Mercedes();
//me.markaModelYaz("Mercedes", "Xl");

Porsche p = new Porsche();
//p.markaModelYaz("Porche", "Carrera");

bm.HizliGider();
bm.Ucar();
bm.Yuzer();

me.Ucar();
me.Yuzer();

p.Ucar();




Akillicocuk ak = new Akillicocuk();
ak.adi = "Hakan";
ak.soyadi = "Yilmaz";
ak.sifat = "Akillidir";
ak.adSoyadSifatYaz(ak.adi,ak.soyadi,ak.sifat);
ak.Askeregit(ak.adi);
ak.EhliyetAl(ak.adi);
ak.KlubeGit(ak.adi);

Uslucocuk us = new Uslucocuk();
us.adSoyadSifatYaz("Mehmet", "Yildiz", "Usludur");
us.Askeregit("Mehmet");
us.EhliyetAl("Mehmet");

otamatik ot = new otamatik();
ot.tür = "otomatik vitestir.";
ot.marka = "Porsche";
ot.markaTürYaz(ot.marka,ot.tür);

ot.tür = "otomatik vitestir.";
ot.marka = "Togg";
ot.markaTürYaz(ot.marka, ot.tür);

duz dz = new duz();
dz.tür = "düz vitestir.";
dz.marka = "BMW";
dz.markaTürYaz(dz.marka,dz.tür);

dz.tür = "düz vitestir.";
dz.marka = "Toyota";
dz.markaTürYaz(dz.marka, dz.tür);

HiperAktifCocuk hp = new HiperAktifCocuk();
hp.EhliyetAl("Huseyin");

GenelMudur gm = new GenelMudur();
Mudur mu = new Mudur();
Programci pr = new Programci();
Stajyer s = new Stajyer();

double toplamMaas = 0.0;

//toplamMaas = toplamMaas + gm.maasinizNedir(); 
toplamMaas += gm.maasinizNedir();
toplamMaas += mu.maasinizNedir();
toplamMaas += pr.maasinizNedir();
toplamMaas += s.maasinizNedir();

Console.WriteLine("Toplam: " + toplamMaas + "TL maas aliyorlar.");



ArrayList arr = new ArrayList();
//ayni turden verileri bir isim altinda tutmamizi saglar
//1.kullanimi
//hangiturdenveri[] diziadi = newturdenveri[7];


string[] gunler = new string[7];
gunler[0] = "pazartesi";
gunler[1] = "sali";
gunler[2] = "carsamba";
gunler[3] = "persembe";
gunler[4] = "cuma";
gunler[5] = "cumartesi";
gunler[6] = "pazar";

//if (kosul) {} else else if

int yas = 33;
if (yas > 0 && yas<=18)
{
    Console.WriteLine("Kucuksunuz.");
}
else if (yas>18 && yas<=35)
{
    Console.WriteLine("Gencsiniz.");
}
else
{
    Console.WriteLine("sisteme giris yapamazsiniz.");
}

//dizi tanım 2. yöntem
int[] sayilar = { 3, 5, 7, 8, 9, 11, 22, 33, 44, 55, 77, 88, 99, 105 };
int sayiToplam = 0;
for (int x = 0; x < sayilar.Length; x++)
{
    // sayiToplam = sayiToplam + sayilar[x];
    sayiToplam += sayilar[x];
}
Console.WriteLine("Sayıların toplamı : " + sayiToplam);



//for(int sayac=0;sayac <10; sayac++)  {  }
for (int sayac = 0; sayac < 10; sayac++)
{
    Console.WriteLine("Merhaba Dünya : " + sayac);
}






