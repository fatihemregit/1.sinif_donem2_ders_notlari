//ÖNEMLİ NOT:BURAYA DERS NOTLARINDAKİ HERŞEYİ YAZMADIM.O YÜZDEN EĞER TAM ANLAMIYLA ÖĞRENMEK İSTİYORSANIZ DERS NOTUNA BAKINIZ

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace hafta2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //ÖNEMLİ NOT:BURAYA DERS NOTLARINDAKİ HERŞEYİ YAZMADIM.O YÜZDEN EĞER TAM ANLAMIYLA ÖĞRENMEK İSTİYORSANIZ DERS NOTUNA BAKINIZ
            int a = 55;//tanımlama ve değer verme aynı satırda
            int b,c,d,e;//aynı türden birden fazla değişken tanımlama
            int f = 110, g, m = 710;//tanımlanan değişkenlerin bazılarına değer verilirken bazılarına vermedi

            /*
             * DEĞİŞKEN TÜRLERİ
             * Sayısal Türler(boyut)(Kapasitesi)(kapasite türü)(tanımlama örneği)
                 * byte(1 byte) (0,..,255)(tam sayı)(byte a = 5)
                 * sbyte(1 byte)(-128,...,127)(tam sayı)(sbyte a = 5)
                 * short(2 byte)(-327678,...,32767)(tam sayı)(short a = 5)
                 * ushort(2 byte)(0,65535)(tam sayı)(ushort a = 5)
                 * int(4 byte)(-2147483648, ..., 2147483647)(tam sayı)(int a = 5)
                 * uint(4 byte)(0,...,4294967295)(tam sayı)(uint a=5)
                 * long(8 byte)(-9223372036854775808, ..., 9223372036854775807 )(tam sayı)(long a = 5)
                 * ulong(8 byte)(0,...,18446744073709551615)(tam sayı)(ulong a = 5)
                 * float(4 byte)(±1.5*10-45, ..., ±3.4*1038)(reel sayı)(float a= 5F veya float a= 5f)
                 * double(8 byte)(±5.0*10-324, ..., ±1.7*10308 )(reel sayı)(double a = 5 veya double a = 5d veya double a=5D )
                 * decimal(16 byte)(±1.5*10-28, ..., ±7.9*1028)(reel sayı)(decimal a = 5M veya decimal a = 5m)
                Not:bazı değişken türlerinde değer atarken değerin sonuna bir karakter eklenmiş, 
                bu değişken türlerindeki değişkenlere değer atarken bunlara dikkat edilmelidir. 
            *Metinsel Türler(boyut)(Açıklama)(tanımlama örneği)
               * char(2 byte)(Tek bir karakteri tutar)(char a ='h')
               * string(Sınırsız)(Metin tutar)(string a = "Adana MYO")
            * Her iki tür olmayanlar
               * bool:koşullu yapılarda kullanırız.yalnızca iki değeri vardır true,false
               * object:her türden veri verebilirsiniz

             */
            //Değişkenlerin program içinde kullanılması
            //örnek 2-2.1
            byte bit = 5;
            Console.WriteLine(bit);
            //örnek 2-2.2
            byte bit2 = 5;
            byte bit3 = 8;
            Console.WriteLine(bit2 + bit3);
            //örnek 2-2.3
            string string1 = "Adana", string2 = "MYO";
            char char1 = ' ';
            Console.WriteLine(string1 + char1 + string2);
            // örnek 2-2.4(kod hatalıydı düzelttim o yüzden aynı kodu yazmadım :) )
            string string3 = Console.ReadLine();
            Console.WriteLine(string3 + "metnini yazdınız.");
            // Değişken ad verme kuralları kısmını geçiyorum zaten programlama temellerinde bahsedildi.(isterseniz hafta2nin pdfinde sayfa6da yazıyor)
            // Sabit değişkenler:
            /*
             Sabit değişkenlerin normal değişkenlerden farkı,
            değişken değiştirilmek istendiğinde ortaya çıkar, 
            sabit olarak belirtilen değişken değiştirilirse 
            derleyici hata verir programı derlemez.sabit değişkenler tanımlandığı satırda değer verilmelidir.
            const örnekleri aşağıdadır
             */
            const int sayi1 = 5;
            const string string4 = "deneme";
            const char char2 = 's';
            /*
             Sabit ifadelere değer olarak sabit,sabit değişken ya da sabit ve /veya sabit değişkenlerden oluşan matematiksel ifadeler verilebilir.
                ÖR:
             */
            const int sayi2 = 5;
            const int sayi3 = sayi2 + 7;
            const int sayi4 = sayi2 * sayi3;
            //Escape sequence kullanımı(Kaçış Karakterleri)
            string string5 = "Deneme\"Deneme";
            Console.WriteLine(string5);
            string string6 = "Windows\\Program Files";
            string string7 = @"Windows\Program Files";
            Console.WriteLine("Satır\nYeniSatır\nYeniSatır");
            //Nesne Açıklanması tanımlanması ve kullanılması
            /* 
             c# da herşey nesnedir nesneler ise class'lardan oluşur
              class lar şöyle tanımlanır
                (bilerek kodda tanımlamıyorum çünkü main metodu içinde class tanımlayamazssınız)
                class Class1{
                Sınıf Kodları    
            }
            nesne üretmek için ise 
            Class1 cs1 = new Class1();
             */
            //operatörler (buranın neredeyse hepsini geçiyorum çünkü daha önceki dönem programlama temellerinde öğrendik)
            /*
             * as Operatörü
             * Tüm değişken türlerinden object'e ve string değerli olmak
               şartıyla object'ten string'e dönüşüm sağlar
               
             */
            object object1 = "50";
            string string8 = object1 as string;
            Console.WriteLine(string8);
            /*
             * is operatorü:
             * Verilen değişken, 
               sabit ya da bir ifadenin türünü kontrol eder. 
            Eğer söz konusu değişken, sabit ya da ifade verilen türle uyumluysa true 
            değilse false değeri üretir. 
            Eğer söz konusu değişken, 
            sabit ya da ifadenin türü her zaman true ya da false üretiliyorsa derleyici uyarı verir, 
            ancak bu uyarı derlemeye engel değildir. 
             */
            int sayi5 = 7;
            bool bool1 = sayi5 is int;
            Console.WriteLine(bool1);
            Console.ReadLine();


        }

    }
}
