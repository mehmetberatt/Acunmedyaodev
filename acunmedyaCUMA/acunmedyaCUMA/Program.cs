// See https://aka.ms/new-console-template for more information
using acunmedyaCUMA.classes;
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
an.adi = "fahriye";
an.soyadi = "gökyar";
an.ekranaYaz(an.adi, an.soyadi);

Baba b = new Baba();
b.ekranaYaz("Kasım", "gökyar");

Cocuk c = new Cocuk();
c.ekranaYaz("ibrahim", "gökyar");

Bmw bm = new Bmw();
bm.markaModelYaz("Bmw", "X5");

Mercedes me = new Mercedes();
me.markaModelYaz("Mercedes", "Xl");

Porsche p = new Porsche();
p.markaModelYaz("Porche", "Carrera");

akillicocuk ak = new akillicocuk();
ak.adi = "Hakan";
ak.soyadi = "Yilmaz";
ak.sifat = "Akillidir";
ak.adSoyadSifatYaz(ak.adi,ak.soyadi,ak.sifat);

uslucocuk us = new uslucocuk();
us.adSoyadSifatYaz("Mehmet", "Yildiz", "Usludur");

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



