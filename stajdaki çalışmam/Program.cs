using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace stajdaki_çalışmam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 

             int sayı1 = 13;
             int sayı2 = 14;
             Console.Write(sayı1);
             Console.Write(sayı2);
             Console.ReadLine();


            */

            /*
          
            //Değerler tırnak içerisinde yazılır.
            
            string isim="Cem";
            string soyisim="ERCOŞMAN";
            Console.WriteLine(isim);
            Console.WriteLine(soyisim);
            Console.ReadLine();


            */

            /*

            double ondalıksayı1 = 123.123;
            double ondalıklısayı2 = -789.789;
            Console.WriteLine(ondalıksayı1);
            Console.WriteLine(ondalıklısayı2);
            Console.ReadLine();


            */


            // Karakterleri tutmak için char veri tipini kullnırız.
            // Tek tırnak içinde tek değer ya da ifade olacak şekilde kullanılır.


            /*
           
            char deger1 = '%';
            char deger2 = '?';
            Console.WriteLine(deger1);
            Console.WriteLine(deger2);
            Console.ReadLine();

            */


            //Bool veri tipi true ya da false değerlerini tutar.


            /*
            bool kontrol1 = false;
            bool kontrol2 = true;

            bool sonuc=5>3;
            Console.WriteLine(sonuc);
            Console.ReadLine();
            */


            // Object veri tipi her türlü değeri (sayı,harf,ifade vb) içinde tutar.

            /*
            
            object a = "Cem";
            object b = "33";
            object c = "?";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadLine();
            
            */


            /*
             OPERATÖRLER
                1)Çarpma Operatörü:  *
                2)Mod Alma Operatörü (Kalan Bulma Operatü):    %
                3)Atama Operatörü:   =
                4)Eşit Operatörü:    ==
                5)Farklı Operatörü:  !=
                6)Ve Operatörü:      &&
                7)Veya Operatörü:    ||
                8)Değil Operatörü:   !

            */


            //Toplama Operatörü: +
            //Çıkarma Operatörü: -


            /*
            
            int sayı1 = 15;
            int sayı2 = 20;
            int sonuc = (sayı1+sayı2);
            Console.WriteLine(sonuc);
            Console.ReadLine();
           
            */


            //Çarpma Operatörü: *
            //Bölme Operatörü:  /

            /*
            int sayı1 = 33;
            int sayı2 = 3;
            int sonuc = sayı1 / sayı2;
            Console.WriteLine(sonuc);
            Console.ReadLine();
            */


            //Mod alma (kalan bulma) operatörü: %

            /*
            
            int sayı1 = 10;
            int sayı2 = 3;
            int sonuc = sayı1 % sayı2;
            Console.WriteLine(sonuc);
            Console.ReadLine();
            
             */


            //Arttırma Öperatörü: ++
            //Azaltma Operatörü:  --

            /*
            
            int a = 9;
            int b = 10;
            int c = ++a;
            int d = ++b;
            int sonuc = c + d;
            Console.WriteLine(sonuc);
            Console.ReadLine();

            */


            //Eşittir Operatörü:  ==

            /*
            
            int a = 5;
            int b = 5;

            bool kontrolEt = a==b;
            Console.WriteLine(kontrolEt);
            Console.ReadLine();

            */


            //Farklı Operatörü: !=

            /*
            int sayı1 = 5;
            int sayı2 = 5;

            bool kontrolEt = sayı1 != sayı2;
            Console.WriteLine(kontrolEt);
            Console.ReadLine();
            */


            //Büyük Operatörü: >
            //Büyük Ve Eşittir Operatörü: >=


            /*
            int a = 5;
            int b = 6;
            int c = 6;
         
            bool sonuc = a > b;
            bool sonuc2= b >= c;
            Console.WriteLine(sonuc);
            Console.WriteLine(sonuc2);
            Console.ReadLine();
            */

            
            //Ve operarörü:  &&

            /*
            int a = 1; 
            int b = 1; 
            int c = 1;
            bool kontrolEt = a==b && a<c;
            Console.WriteLine(kontrolEt);
            Console.ReadLine();
            */


            //Veya Operatörü:||

            /*
            int a = 1;
            int b = 1;
            int c = 1;
            bool kontrolEt = a == b || a < c;
            Console.WriteLine(kontrolEt);
            Console.ReadLine();
            */


            //Değil Operatörü: ! (Var olan değerin zıttını söyler.)
            
            /*
            bool a = true;
            Console.WriteLine(!a);
            Console.ReadLine();
            */


            //   DİĞER OPERATÖRLER
            //    += 
            //    -=
            //    /=
            //    *=


            /*
            int a = 5;
            //a = a + 4;    //Burda a'nın değerinin üstüne 4 ekleme işlemini yaptık.
            a += 4;         //Burası üstteki yapılan işlemin kısaltılmış hali.
            Console.WriteLine("a'nın değeri:"+a);
            Console.ReadLine();
            */


            //Kullanıcıdan Değer Alma

            /*
            string x = "Cem ERCOŞMAN";
            Console.WriteLine("Hoşgeldiniz" + x);
            Console.ReadLine();
            */


            /*
            Console.WriteLine("Lütfen isminizi giriniz.");
            string isim=Console.ReadLine();

            Console.WriteLine("Lütfen soyisminizi giriniz.");
            string soyisim=Console.ReadLine();

            Console.WriteLine("Kullanıcının adı: "+isim);
            Console.WriteLine("Kullanıcının soyismi: "+soyisim);
            Console.ReadLine();
            */


            //TÜR DÖNÜŞÜMLERİ


            /*
            int a=5; 
            byte b=(byte)a;
            Console.WriteLine(b.GetType());                //burdaki GetType sayesinde onun türünü ekrana yazdırırız. GetType bu işe yarar.
            Console.WriteLine(b);
            Console.ReadLine();
            */


            /*
            string sayı1 = "123";
            string say2 = "12";

            int a = int.Parse(sayı1);
            int b=int.Parse(say2);
                                                          //Burda string veri tipipni int veri tipine dönüştürdük.
                                                          //stringi int yapmak için  int.Parse kullanılı
            Console.WriteLine(a+b);
            Console.ReadLine();
            */


            /*
            string sayı1 = "1";
            string sayı2 = "2";
                                                          //Burda string veri tipini int veri tipine dönüştürdük.
            int a = Convert.ToInt32(sayı1);               //stringi int yapmak için başka bir yol ise Convert.ToInt32 kullanmaktır.
            int b=Convert.ToInt32(sayı2 );

            Console.WriteLine(a+b);
            Console.ReadLine();
            */


            /*
            int sayı1 = 10;
            int sayı2 = 5;

            string a=sayı1.ToString();
            string b=sayı2.ToString();             //Biz burda int veri tipini ToString kullanarak string veri tipine dönüştürdük.
                                                   //İnt veri tipinde bırakıp toplama işlemi yapsaydık çıktıda 15 değerini görürüdük ama yaptığımız işlemden sonra çıktıda 15 yerine 105 görüyoruz.

            Console.WriteLine(a+b);
            Console.ReadLine();
            */


            // IF ELSE YAPISI


            /*
            int not = 70;                                                                          //Önce öğrenciye bir not tanımladık
                                                                                                   //Daha sonra eğer true dönerse if içerisindeki kıvırcık parantezler döner, false dönerse else içerisindeki kıvırcık parantezler döner.
            if (not> 50) 
            {
                Console.WriteLine("Öğrenci başarılı şekilde dersten geçmiştir.");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Öğrenci dersten kalmıştır.");
                Console.ReadLine();
            }

            */


            //IF - ELSE IF - ELSE


            /*
           
            int not = 55;

            if (not >= 60)
            {
                Console.WriteLine("Öğrenci Başarılı Şekilde Geçmiştir");
                Console.ReadLine();

            }
            else if (not>=50) 
            {                                                                                    // Birden fazla durumun olduğu yerlerde bunu kullanırız.
                Console.WriteLine("öğrenci Ortalaması Sayesinde Geçmiştir");
                Console.ReadLine();
            }

            else if(not<50)
            {
                Console.WriteLine("Öğrenci kalmıştır.");
                Console.ReadLine();
            }
            
             */


            //Uygulama


            /*
           
            Console.Write("Lütfen 1. Sınav Notunuzu Giriniz: ");
            string ilk_not =Console.ReadLine();
            Console.Write("Lütfen 2. Sınav Notunuzu Giriniz: ");
            string ikinci_not = Console.ReadLine(); 
            Console.Write("Lütfen 3. Sınav Notunuzu Giriniz: ");
            string ucuncu_not=Console.ReadLine();
            int a=Convert.ToInt32(ilk_not);
            int b=Convert.ToInt32(ikinci_not);
            int c=Convert.ToInt32(ucuncu_not);
            Console.Write("Öğrencinin Ortalması: ");
            Console.WriteLine((a + b + c) / 3);
            if (a >= 60) 
            {
            Console.WriteLine("Öğrenci Başarılı Şekilde Geçmiştir.");
            Console.ReadLine();
            }
            else if (b >= 50)                                                            
            {

            Console.WriteLine("Öğrenci Ortalaması Sayesinde Geçmiştir.");
            Console.ReadLine(); 
            }
            else if (c == 0)
            {
            Console.WriteLine("Öğrenci Dersten Kalmıştır.");
            Console.ReadLine();
            }

            */


            //Başka bir uygulama (if-else olmadan)

            /*
            Console.WriteLine("Dörtgen Alanı Hesaplama");
            Console.Write("Kenar Uzunluğunun İlk Değerini Giriniz: ");
            string ilkuzunluk=Console.ReadLine();
            Console.Write("Kenar Uzunluğunun İkinci Değerini Giriniz: ");
            string ikinciuzunluk=Console.ReadLine();

            int a=Convert.ToInt32(ilkuzunluk);
            int b=Convert.ToInt32(ikinciuzunluk);
            int c = a * b;
            Console.WriteLine("Dörtgenin ALanı: "+c);
            Console.ReadLine();
            */


            // DÖNGÜLER


            // FOR DÖNGÜSÜ







            /*
            for(degisken_adi = baslangıcDegeri; koşul; arttırmaAzaltma)
            {
                Çalışacak Kodlar                                                     //Bu şekilde yapacağız.
            }
            Console.ReadLine();
           */





            //Uygulama 1
            // 1 den 10 a kadar olan sayıları alt alta yazdıralım.

            /*
            for(int i = 1; i<=10; i++) 
            
            {
             Console.WriteLine(i);
            }

            Console.ReadLine();
            */

            //Uygulama 2
            //1 den 10a kadar olan sayılardan çift olanları yazdıralım.

            for (int i = 0; i <= 10; i=i+2) 
            {
             Console.WriteLine(i);
            }
            Console.ReadLine();














































































































        }
    }
}
