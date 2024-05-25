using System;
using System.Linq;
using System.Diagnostics;
using System.Data;
using System.Net;
using System.ComponentModel;
using System.Web;
using System.Xml;
using System.Net.Configuration;
using System.Runtime.InteropServices;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Csharp'a giriş
            //TÜR DÖNÜŞÜMLERİ

            //int a = 0;
            //int b = new int();
            //string c = a.ToString() + b.ToString();
            //string s = "";
            //string e = "merhaba \n";
            //string t = "hüdayi";
            //string p = e + t;
            //System.Console.WriteLine(c + "\n" + p);

            //byte veri = 5;
            //byte veri2 = 9;
            //int veri3 = veri + veri2;

            //int veri4 = a;
            //int veri5 = veri4 + 8;
            //int veri6 = a * veri4;
            //bool veri7 = false;
            //s = a.ToString();
            //s = s + "8";

            //Console.ReadLine();
            //int i = 256;
            //byte b;
            ////checked
            //{
            //    b = (byte)i;
            //}
            //Console.WriteLine(b);
            //Console.ReadLine();

            //byte i = 254;
            //int j = 500;
            //byte b, c;
            //checked
            //{
            //    b = (byte)i;
            //    Console.WriteLine(b);
            //}
            //unchecked
            //{
            //    c = (byte)j;
            //    Console.WriteLine(c);
            //}
            //Console.ReadLine(); 

            //int a = 500;
            //object b = (object)a;

            //int a = 500;
            //object b = a;


            // kutu açma
            //int i = 15;
            //object o = i; // boxing
            //int j = (short)o; // unboxing
            //Console.WriteLine(i);
            //Console.WriteLine(j);
            //Console.ReadLine(); 


            //int i = 15;
            //object o = i;
            //short j = (short)o;
            //Console.WriteLine(i);
            //Console.WriteLine(j);
            //Console.ReadLine();

            //int i = 15;
            //object o = i;
            //int j =(int)o;
            //Console.WriteLine(i);
            //Console.WriteLine(j);
            //Console.ReadLine();


            // toplama yapan C#  kodu 


            //string s1, s2, s3;
            //int i1, i2, i3;

            //Console.WriteLine("1.sayıyı girin ");
            //s1 = Console.ReadLine();

            //Console.WriteLine("2.sayıyı girin");
            //s2 = Console.ReadLine();

            //Console.WriteLine("3.sayıyı girin");
            //s3 = Console.ReadLine();

            //i1 = Convert.ToInt32(s1);
            //i2 = Convert.ToInt32(s2);
            //i3 = Convert.ToInt32(s3);

            //i3 = i1 + i2 + i3;

            //Console.WriteLine("toplam: " + i3);
            //Console.ReadLine();

            // BENİM YAPTIKLARIM 
            //TUPLE

            // tuple  belirli sayıda ve sırada elemana sahip veri yapılarıdır.
            //örnek
            //var person = Tuple.Create("hüdayi", 18);
            //Console.WriteLine(person);
            //Console.ReadLine();

            //OPERATÖRLER( derste yaptıklarımız)
            //int i = 5 * 4 / 6;
            //Console.WriteLine(i);

            // C# işlem önceliğine önem verir.

            //örnek:

            //i = 5 * (4 / 6);
            //Console.WriteLine(i);
            //Console.ReadLine();

            //int i = 5 + -4;
            //Console.WriteLine(i);
            //Console.ReadLine();

            // operatör önceliği  

            //int i = 8 / 3;
            //float j = 8 / 3;
            //float k = 8f / 3f;
            //Console.WriteLine("{0} \n {1} \n {2} \n",i,j,k);
            //Console.ReadLine();

            /* Arttırma Azaltma operatörleri */

            //int a = 10;
            //Console.WriteLine(a++);
            ////a = 10;
            //Console.WriteLine(++a);
            //Console.ReadLine();

            //int a = 10;
            //int b = a++;
            //Console.WriteLine("a++ atamasında b:" +b);
            //Console.WriteLine("a++ atamasında:"+ a + "\n");
            //b = ++a;
            //Console.WriteLine("++a atamasında b:" + b);
            //Console.WriteLine("++a atamasında a:" + a);
            //Console.ReadLine();

            /*Karşılaştırma operatörleri */

            //bool a = 30 == 45;
            //bool b = 30 > 45;
            //bool c = 30 < 45;
            //bool d = 30 != 45;
            //bool e = 30 <= 45;
            //bool f = 30 >= 45;
            //Console.WriteLine("{0} \n {1} \n {2} \n {3} \n {4} \n {5}\n ", a, b, c, d, e, f);
            //Console.ReadLine();

            /*AS ve İS  operatörü */
            /* as operatörü
            1) Uygun türler arasındaki dönüşümü sağlar.
            2) Üretilen değer referans türündendir. 
            // is operatörü //  
            Çalışma zamanında bir nesnenin türünün operand ile verilen türe
            uyumlu olup olmadığını kontrol eder.
            Üretilen değer true yada false olur.
             */

            //object o = 25;
            //string s = o as string;
            //int i = 17;
            //bool b = i is int;
            //bool c = i is double;
            //Console.WriteLine("{0} \n {1} \n {2} \n {3} \n {4} \n  ", o, s, i, b, c);
            //Console.ReadLine();
            /*Mantıksal  Operatörler */
            //bool b = 5 > 10 && 3 == 4;
            //bool c = 5 < 10 && 3 != 4;
            //Console.WriteLine("{0} \n {1} \n", b,c );
            //Console.ReadLine();

            //bool a = 5 > 10 || 3 == 3;
            //bool h = !(5 < 10) || 3 != 4;
            //Console.WriteLine("{0} \n {1} \n ", a, h);
            //Console.ReadLine();

            //Bitsel operatörler

            //byte b =   255;
            //byte c= (byte) ~ b;
            //Console.WriteLine("{0} \n {1} \n", b, c);
            //Console.ReadLine();

            // bitsel ve "&&" operatörü

            //byte a = 145;
            //byte b = 73;
            //int c = (byte) ( a & b );
            //Console.WriteLine("{0} \n {1} \n {2} \n" ,a, b, c );
            //Console.ReadLine();

            // bitsel veya "||" operatörü 
            //byte a = 145;
            //byte b = 73;
            //int c = (byte)(a | b);
            //Console.WriteLine("{0} \n {1} \n {2} \n", a, b, c);
            //Console.ReadLine();

            // bitsel özel veya "^"  (xor) operatörü 

            //byte a = 10;
            //byte b = 99;
            //byte c = (byte)( b ^ a );
            //Console.WriteLine("{0} \n {1} \n {2} \n", a, b, c);
            //Console.WriteLine(c);
            //Console.ReadLine();


            /* Atama ve İşlemli Atama Operatörleri */

            // "="  operatörü bir değişkene herhangi bir değeri atamak için kullanılır.

            //int a = 15;
            //int b = 20;
            //int c = 30;
            //int d = 50;
            //a *= b;
            //c = a++;
            //d = ++c;
            //d -= c;
            ////Console.WriteLine(d);
            ////Console.ReadLine();


            // bool g isimli bir veri tipi tanımlayınız.İçerisine veri tipini kontrol eden operatörü kullanarak f nin int olma durumunu atayınız .


            // double f ;
            // f = (double)c ;

            //bool g = f is int ;
            // Console.WriteLine(g) ;
            // Console.WriteLine(f) ;
            // Console.ReadLine() ;

            // Özel amaçlı operatörler. 

            //string str = "hüdayi emre ";
            //int sayi = 1;
            //str = str + (sayi == 2 ? "" : "lar  "); /* if else gibi çalışır. */
            //Console.WriteLine(str);
            //Console.ReadLine();

            //string str = "hüdayi emre";
            //int sayi = 3;
            //str = str + ((sayi == 1 || sayi == 0) ? "" : "ler");
            //Console.WriteLine(str);
            //sayi = 1;
            //str = "hüdayi" + ((sayi == 1 || (sayi == 0) ? "" : "lar"));
            //Console.WriteLine(str);
            //Console.ReadLine();

            //int a = 15;
            //int b = 20;
            //int c = 30;
            //int d = 50;
            //a *= b;
            //c = a++;
            //d = ++c;
            //d -= c;
            //Console.WriteLine(d);
            //Console.ReadLine();

            //double f;
            //f = (double)c;

            //bool g = f is int;
            //string s = g ? "f integer" : " f is not integer  ";
            //string a = g ? "f integer" : "f   " + f.GetType().Name + " tipindedir ";

            //Console.WriteLine(s);
            //Console.WriteLine(a);
            //Console.ReadLine();

            //Console.WriteLine(g);
            //Console.WriteLine(f);
            //Console.ReadLine();

            //karar yapıları (if else elseif switch case)
            //int a = 15, b = 20, c, d;
            //a *= b;
            //Console.WriteLine(a);
            //c = a++;
            //Console.WriteLine(c);
            //d = ++c;
            //Console.WriteLine(d);
            //d -= c;
            //Console.WriteLine(d);
            //double f = (double)c;
            //bool g = f is int;
            //string s;
            ////string s = g ? "f integer" : "f verisi  " + f.GetType().Name + " tipindedir ";

            //if (g)
            //{
            //    s = "f verisi integer tipinde";

            //}
            //else
            //    s = "f verisi" + f.GetType().Name + "tipindedir";

            //Console.WriteLine(s);
            //Console.ReadLine();

            // if-else-elseif yapısı

            // vize ve final notlarını harfe dökme 
            //Console.WriteLine("Vize ve final notunu giriniz:");
            //int vize = Convert.ToInt32(Console.ReadLine());
            //int final = Convert.ToInt32(Console.ReadLine());
            //int ortalama = (vize + final) / 2;
            //string harf;

            //if (ortalama >= 90 && ortalama <= 100)
            //{
            //    Console.WriteLine(harf = "AA");
            //}
            //else if (ortalama >= 85 && ortalama <= 89)
            //{
            //    Console.WriteLine(harf = "BA");
            //}
            //else if (ortalama >= 80 && ortalama <= 84)
            //{
            //    Console.WriteLine(harf = "BB");
            //}
            //else if (ortalama >= 75 && ortalama <= 79)
            //{
            //    Console.WriteLine(harf = "CB");
            //}
            //else if (ortalama >= 60 && ortalama <= 74)
            //{
            //    Console.WriteLine(harf = "CC");
            //}
            //else if (ortalama >= 55 && ortalama <= 59)
            //{
            //    Console.WriteLine(harf = "DC");
            //}
            //else if (ortalama >= 50 && ortalama <= 54)
            //{
            //    Console.WriteLine(harf = "DD");
            //}
            //else if (ortalama <= 49)
            //{
            //    Console.WriteLine(harf = "FF");
            //}
            //Console.ReadLine();

            //switch case yapısı 

            //int a = 4;
            //switch (a)
            //{
            //    case 1:
            //        Console.WriteLine("case 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("case 2");
            //        break;
            //    case 3:
            //        Console.WriteLine("case3");
            //        break;
            //    default:
            //        Console.WriteLine("bu sayı burada yok");
            //        break;
            //}
            //Console.ReadLine();

            /* ÖRNEKLER */

            //girilen 3 basamaklı sayıyı basamaklarına ayıran kodu yazınız
            //Console.WriteLine("3 basamaklı sayıyı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int yuzler = sayi / 100;
            //sayi = sayi - (yuzler * 100);
            //int onlar = sayi / 10;
            //sayi = sayi - (onlar * 10);
            //int birler = sayi;

            //Console.WriteLine($"Yüzler: {yuzler}");
            //Console.WriteLine($"Onlar: {onlar}");
            //Console.WriteLine($"birler : {birler}");
            //Console.ReadLine();

            //  kullanıcıdan aldığı tam sayı çift ise  sayının yarısını, tek ise sayının  3 katını ekrana yazdır.

            //Console.WriteLine("sayı girin:     ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine($"sayının yarısı:  {sayi / 2} ");
            //}
            //else
            //{
            //    Console.WriteLine($"sayının üç katı :  {sayi * 3} ");
            //}
            //Console.ReadLine();

            // iki iç açısı girilen üçgenin diğer açısını bulan kod 

            //Console.WriteLine("üçgenin iki açısını siz girin diğerini biz bulalım :   ");
            //int aci = Convert.ToInt32(Console.ReadLine());
            //int aci2 = Convert.ToInt32(Console.ReadLine());
            //aci = 180 - (aci + aci2);
            //Console.WriteLine();
            //Console.ReadLine();

            // kullanıcıdan ürün fiyatı alınsın 100 TL üzerinde ise 20 TL,100 TL altında ise 30 tl , 300 Tl ise 0 tl kargo ücreti ekleyen kodu yazınız.

            //Console.WriteLine("ürünün fiyatını giriniz:  ");
            //int ürün = Convert.ToInt32(Console.ReadLine());
            //{
            //    Console.WriteLine($"ürünün fiyatı : {ürün + 10 }");
            //}
            //else if (ürün < 100)  
            //{
            //    Console.WriteLine($"ürünün fiyatı :  {ürün + 30}");
            //}
            //else if (ürün >= 300)
            //{
            //    Console.WriteLine(" bu kargoyu satıcı karşılıyor o yüzden sizden para almadık  :)  ");
            //}
            //else 
            //{
            //    Console.WriteLine("geçersiz işlem,lütfen tekrar deneyiniz ");
            //}
            //Console.ReadLine();


            // ürün fiyatını aldır . 100 - 200 arası % 5  200 - 400 arası % 10 400  ve üzeri % 15 indirim yap.

            //Console.WriteLine("ürünün fiyatını giriniz:  ");
            //int urun = Convert.ToInt32(Console.ReadLine());
            //if (urun >= 100 && urun < 200)
            //{
            //    Console.WriteLine("ürünün indirimli fiyatı: " + (urun  - (urun * 0.25)));
            //}
            //else if (urun >= 200 && urun <= 400)
            //{
            //    Console.WriteLine("ürünün indirimli fiyatı: " + (urun - (urun * 0.1)));
            //}
            //else if (urun > 400)
            //{
            //    Console.WriteLine("ürünün indirimli fiyatı: " + (urun - (urun * 0.15)));
            //}
            //else
            //{
            //    Console.WriteLine("diğer ürünlerimizde  indirim bulunmamaktadır. ");
            //}
            //Console.ReadLine();

            //  girilen mevsimin aylarını ekrana yazdıran switch case kodu  .

            //Console.WriteLine("mevsimin adını yazınız:  ");
            //string mevsim = Console.ReadLine();
            //switch (mevsim)
            //{
            //    case "yaz":
            //        Console.WriteLine("TEMMUZ, AĞUSTOS, EYLÜL");
            //        break;

            //    case "sonbahar":
            //        Console.WriteLine("EKİM , KASIM, ARALIK");
            //        break;
            //    case "kış":
            //        Console.WriteLine("OCAK, ŞUBAT, MART");
            //        break ;
            //    case "ilkbahar":
            //        Console.WriteLine("NİSAN, MAYIS, HAZİRAN");
            //        break;
            //    default:
            //        Console.WriteLine("tüm mevsimler yazıldı ");
            //        break;
            //}
            //Console.ReadLine();

            /* for döngüsü */

            //int i ;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            // 1'den 100'e kadar olan,5 e tam bölünüp 7 ye tam bölünemeyen sayıları ekrana yazdıran kod.

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 5 == 0 && i % 7 != 0)
            //        Console.WriteLine(i);
            //}
            //Console.ReadLine();

            /* 7 satır 4 sutün (*) olan kodu for döngüsü ile yazınız.*/
            // for(int  i = 0;i < 7;i++)
            //{
            //    for ( int j = 0; j <4;  j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Read();

            /* yıldız karakteri ile  dik üçgen oluştur.*/

            //for(int i  = 0; i < 7; i++)
            //{
            //    for(int  j = 0; j < i; j++) {

            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Read();

            /*Döngüler ve atlama deyimleri(for-while-do while- foreach)  */

            /* bu kod kullanıcıdan değer istemekte ve girilen değer "q" değilse ekrana yazdırmaktadır.Girilen değer "q" ise programı sonlandırmaktadır.*/

            //char ch;
            //for (ch = Convert.ToChar(Console.ReadLine()); ch != 'q'; ch = Convert.ToChar(Console.ReadLine())) ;
            //Console.WriteLine(ch);

            /*for ile döngüleri*/
            //int k = 0;
            // for (; k < 10; ++k)
            // {
            //     Console.WriteLine(k);
            // }
            // Console.Read();

            // int k = 0;
            // for(; k < 10;)
            // {
            //     Console.WriteLine(k);
            //     ++k;
            // }
            // Console.Read();

            /* sonsuz dongu */
            //int k = 0;
            //for (; ; )
            //{
            //    Console.WriteLine(k);
            //    ++k ;
            //}
            //Console.Read();

            /* While döngüsü */
            //int n = 0;
            //int toplam = 0;
            //while (n <= 100)
            //{
            //    toplam += n;
            //    n+= 2;
            //}
            //Console.WriteLine(toplam);
            //Console.ReadLine();
            /* iki tam sayı girilmesi isteyiniz.Bu iki tam sayı arasındaki sayıların ortalamasını ekrana yazdıran kodu yazdırınız. */

            //Console.Write("Birinci sayıyı giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("İkinci sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //int toplam = 0;
            //int sayac = 0;

            //for (int i = sayi1; i <= sayi2; i++)
            //{
            //    toplam += i;
            //    sayac++;
            //}

            //double ortalama = (double)toplam / sayac;

            //Console.WriteLine("Girilen sayılar arasındaki sayıların ortalaması: " + ortalama);
            //Console.Read();

            /* kullanıcıdan 20 tam sayı alınacaktır. Girilen sayılardan kaç tanesi 100'den buyuk ekrana yazdırın*/
            //int sayac = 0;
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("sayi girin");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi > 100)
            //    {
            //        sayac++;
            //    }
            //}
            //Console.WriteLine("girilen sayılardan " + sayac + " tanesi 100'den büyüktür");
            //Console.ReadLine();

            /* Do-While */
            // döngüyü en az bir kere çalıştırır.

            //string yazi = " ";
            //do
            //{
            //    Console.WriteLine("Şifreyi Girin: ");
            //    Console.ReadLine();
            //} while (yazi != "sifre");

            /* Foreach-Döngüsü  */

            //foreach ( int x in Dizi)
            //{
            //Console.WriteLine(x);
            //}

            /*Atlama  yazar 4 te durur.
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 4)
            //        break;
            //    Console.WriteLine(i);
            //}
            //Console.Read();

            /*Continue operatörü*/
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 4)
            //        continue;
            //    Console.WriteLine(i);
            //}
            //Console.Read();

            /*goto operatörü*/

            //    Console.WriteLine("bir sayı giriniz");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    if (a % 2 == 0)
            //    {
            //        goto cift;
            //    }
            //    Console.WriteLine("girilen sayı tek :");
            //    goto son;
            //cift:
            //    Console.WriteLine("girilen sayı çift ");
            //son:
            //    Console.Read();

            /* klavyeden 10 tane sınav sonucu girilecektir her sınav notu işleme alınmadan önce doğru girildiği,yani 0 100 arasında olduğu kontrol edilecektir.Eğer sınav notu doğru girilmediyse tekrar not girilmesi istenecektir doğru girilen sınav notları toplanıp sınıf ortalaması hesaplanıp ekranda gösterilecektir.  */

            // int not = 0;
            //int  toplam = 0;
            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine("Not girin : ");
            //     not = Convert.ToInt32(Console.ReadLine()); 
            //     if(not >= 0 && not <=100 ) 
            //     {
            //         toplam += not;
            //     }
            //     else
            //     {
            //         Console.WriteLine("hatalı giriş");
            //         goto git;
            //     }
            // }
            // double ort = toplam / 10;
            // Console.WriteLine(ort);
            // Console.ReadLine();

            /*Diziler (Array)*/

            /*buradaki "int[]" kodu sayı dizisi olduğunu belirtir.*/
            //int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] sayilar2 = new int[10];
            //for (int i = 0; i < sayilar2.Length; i++)
            //{
            //    sayilar2[i] = i + 1;
            //    Console.WriteLine(sayilar2[i]);
            //}
            //foreach (int i in sayilar2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();
            // string[] dizi = { "selam","merhaba","naber"};
            // Console.ReadLine();

            /* sayıların hepsini yazdıran kod */

            //int[] sayi = new int[10];
            // for (int i = 0; i < sayi.Length; i++)
            //{ 
            //    sayi[i] = (i + 1) * 10;
            //    Console.WriteLine(sayi[i]);
            //}

            //Console.ReadLine();
            //tam sayi degerleri alan 10 elemanli bir dizi tanimla.dizinin icine Random metodunu kullanarak 0 ile 100 arasinda random degerler ata .Bu degerleri ekrana yazdir
            //sonrasinda dizinin icerisinde olan cif  sayilarin bulundugu indekse 2 ,tek sayilarin bulundugu indekse 1 degerini ata.Dizinin son halini
            //tekrar ekrana yansit
            //sonrasında,dizinin içerisinde olan çift sayıların bulundugu ındekse 2 , tek sayıların bulundugu ındekse 1 degerını ata dızının son halını tekrar ekrana yansıt.

            //ornek kullanım 
            //asagıdakı kod,sayı verısının ıcerısıne 0-100 arasında random bır deger ataması yapar 100 degerını asla atamaz yanı sınır dahıl degıldır 

            //Random rnd =new Random();
            //int sayi = rnd.Next(100);


            //Random rnd = new Random();
            //int[] sayi = new int[10];
            //int a = 0;
            //for (int i = 0; i < sayi.Length; i++)
            //{

            //    sayi[i] = rnd.Next(100);
            //    Console.WriteLine(sayi[i]);


            //}
            //Console.WriteLine("\n\n");
            //foreach (var i in sayi)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sayi[a] = 2;
            //    }
            //    else
            //    {
            //        sayi[a] = 1;
            //    }
            //    a++;
            //}
            //foreach (var i in sayi)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            /*Örnekler */
            /*kelimeyi ters çevirme */
            //string str = "Merhaba dünya";
            //string kelime = new string(str.Reverse().ToArray());
            //char[] chars = kelime.ToCharArray();
            //Console.WriteLine(chars);
            //Console.ReadLine();


            //Random rnd = new Random();
            //Console.WriteLine("sayı girin:  ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] dizi = new int[n - 1];
            //dizi[0] = rnd.Next(1, n + 1);

            //for (int i = 0; i < dizi.Length; i++)
            //{

            //    int a = rnd.Next(1, n + 1);
            //    int index = Array.IndexOf(dizi, a);
            //    if (index != -1)
            //    {
            //        i--;
            //    }

            //    else
            //    {
            //        dizi[i] = a;
            //    }
            //}
            //int ol_ger_top = 0;
            //for (int j = 1 ; j < n+1; j++)
            //{
            //    ol_ger_top += j ;                
            //}
            //int dizi_top = 0;
            //for (int k = 0; k < dizi.Length; k++)
            //{
            //    dizi_top += dizi[k];
            //    Console.WriteLine(dizi[k]);
            //}
            //int fark = ol_ger_top - dizi_top;
            //Console.WriteLine(fark);
            //Console.ReadLine();


            //int[] arr = { 23, 25, 13, 37, 83, 11 };       
            //int min = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < min)
            //        min = arr[i];      
            //}
            //Console.WriteLine(min);
            //Console.ReadLine();


            //int[ ]arr2 = { 23, 25, 13, 37, 83,11 };
            //int sum = 0;
            //int ort = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum + = arr2[i]; 
            //}
            //ort = sum / arr2.Lenght;
            //Console.WriteLine(ort);
            //Console.ReadLine();

            //int a= 5;
            //int b = 1;
            //int c = 7;
            //int d = (((a + b--) * a++) + 5 / c++) - --c / 2;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.ReadLine();


            /*Dizi Metotları */

            // int[] dizi = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] dizi2 = new int[5];
            // int sayi = dizi[0];
            // for (int i = 0; i < dizi2.Length; i++)
            // {
            //    dizi2[i] = i + 1;
            //     Console.WriteLine(dizi2[i]);
            //}
            // Console.ReadKey();


            // string dizi metodları 

            /* split(); giriş dizesini bir veya daha fazla sınırlayıcıya göre bölerek bir alt dize dizisi oluşturur.*/

            /* join(); Her öğe veya üye arasında belirtilen ayırıcıyı kullanarak, belirtilen bir dizinin veya bir koleksiyonun üyelerini birleştirir.*/

            /* ToCharArray(); karakterleri bir Unicode karakter dizisine kopyalar.   */

            /* Array.Reverse(); kelimeleri ters çeviren metoddur  */



            /* ÖRNEK */

            //string kelime = "merhaba arkadaşlar";

            //string[] dizi[] = kelime.Split(' ');

            // dizi[] {"merhaba ", "arkadaşlar" , "nasılsınız "};

            //string[] dizi2 = { "arkadaşım", "ders", "dinle" };

            //string kelime 2 = string.Join(",", dizi);

            // kelime 2 = " arkadaşım dersi dinle"



            /* split &&  join metodu */
            //string kelime = "bu kelime bir dizidir ";
            //string[] dizi = kelime.Split(' ');
            //string dizi2 = string.Join(",", dizi);
            //foreach (var i in dizi)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(dizi2, " \n");
            //Console.ReadLine();


            /*join metodu */
            // string[] dizi1 = { "merhaba", "bu", "bir", "join", "dizisidir" };
            // string kelime1 = string.Join(",", dizi1);
            // foreach (var i in kelime1)
            // {
            //     Console.Write(i);
            // }
            // Console.WriteLine(dizi1);
            // Console.ReadLine();

            /* ToCharArray(); methodu */

            //string veri = "bıdı bıdı ";
            //char[] veri_dizi = veri.ToCharArray();
            //foreach (var i in veri_dizi)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadLine();

            /*Array.reverse(); */


            //string veri = "dünya merhaba ";
            //char[] veri_dizi = veri.ToCharArray();
            //Array.Reverse(veri_dizi);
            //foreach (var i in veri_dizi)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            /* kullanıcıdan veri al , aldığın veriyi b harfine göre böl 
               Aldığın veriyi 'b' harfine göre böl,diziye dönüştür
               Dizininin içinde 'a' harfini 'e ' yap 
               diziyi düzden ters yap.
               terse dönen diziyi string veriye dönüştür.              
             */
            //Console.WriteLine("kelime girin:   ");
            //string veri = Console.ReadLine();
            //string[] strings = veri.Split('b');
            //char[] karakter = string.Join(" ", strings).ToCharArray();
            //for (int i = 0; i < karakter.Length; i++)
            //{
            //    if (karakter[i] == 'a')
            //        karakter[i] = 'e';
            //}
            //foreach (char c in karakter)
            //{
            //    Console.WriteLine(c);
            //}
            //Array.Reverse(karakter);
            //Console.WriteLine();
            //foreach (char c in karakter)
            //{
            //    Console.WriteLine(c);
            //}
            //string yeni_metin = string.Join(" ", karakter);
            //Console.WriteLine();
            //Console.WriteLine(yeni_metin);
            //Console.ReadLine();

            //Console.WriteLine("   içinde 'a' harfi olan  kelime girin   ");
            //string isimler = Console.ReadLine();
            //string[] isimler_dizisi = isimler.Split('a');
            //string isimler2 = string.Join(" " , isimler_dizisi);
            //char[] name = string.Join("  ", isimler2 ).ToCharArray();
            //for (int i = 0; i < isimler_dizisi.Length; i++)
            //{
            //    if (name[i] == 'a')
            //        name[i] = 'h';
            //}
            //foreach (char d  in name)
            //{
            //    Console.WriteLine(d);
            //}
            //Array.Reverse(name);
            //Console.WriteLine();
            //foreach (char d in name)
            //{
            //    Console.WriteLine(d);   
            //}
            //string ters = string.Join(" " , name);
            //Console.WriteLine();
            //Console.WriteLine(isimler2);
            //Console.ReadKey();

            /*Array.sort() metodu */

            // dizileri kurallı bir sıraya sokar. 

            // int[] numbers = {3,2,1,4,7,5,6,8,9};
            // Array.Sort(numbers);
            // foreach(int i in numbers)
            // {
            //     Console.WriteLine(i);
            // }
            //Console.ReadKey();

            /* Array.Clear() Metodu  */

            // Dizinin 1. indeksinden başlayarak 3 elemanı sıfırlar.

            //int[] number = { 1,2,4,5,6,7,8,3,9 };
            //Array.Clear(number,1 , 3);
            //foreach (int i in number)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            /* Array.Resize() Metodu   */
            // bir dizinin boyutunu yeniden belirler.

            //int[] sayi = { 1, 2, 3 ,4,5};
            //Array.Resize(ref sayi, 10);
            //sayi[5] = 10;
            //sayi[9] = 20;
            //foreach (int i in sayi)
            //{
            //    Console.WriteLine(i);

            //}
            //Console.ReadLine();

            /*Array.Copy*/
            // Bir dizinin elemanlarını başka bir diziye kopyalar.

            //int[] kaynak_kod = { 1, 2, 3, 4, 5, 6};
            //int[] hedef = new int[6];
            //Array.Copy(kaynak_kod, hedef, kaynak_kod.Length);
            //Console.WriteLine("hedef dizi :" );
            //foreach (int i in hedef)
            //{
            //    Console.WriteLine(i);

            //}
            //Console.ReadLine();

            /*Array.İndexof*/

            // Belirli bir değerin dizideki ilk indeksini döner.

            //int[] köfte = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int index = Array.IndexOf(köfte, 3);
            //Console.WriteLine("3 değeri dizinin " + index + ". indeksinde buluyor");
            //Console.Read();
            /* Array.Exits */

            // Belirtilen bir koşulu sağlayan en az bir eleman olup olmadığını kontrol eder.

            //int[] kokoreç = { 1, 2, 3, 6 , 9 , 5 };
            //bool exit = Array.Exists(kokoreç, eleman => eleman > 100);
            //Console.WriteLine(exit);
            //Console.ReadLine();

            /* Array.Find()  */

            //Belirtilen koşulu sağlayan ilk elemanı Yazdırır.

            //int[] pilav = { 1, 2, 3,4,5,6,7,8,9 };
            //int found = Array.Find(pilav , eleman => eleman > 4);
            //Console.WriteLine(found);
            //Console.ReadLine();


            //Console.WriteLine("kelime girin   :       ");
            //string kelime = Console.ReadLine();
            //string[] strings = kelime.Split(' ');
            //char[] charArray = string.Join(" ", strings).ToCharArray();
            //for (int i = 0; i < charArray.Length; i++)
            //{
            //    if (charArray[i] == 'c')
            //        charArray[i] = 'c';
            //}
            //foreach (var d in charArray)
            //{
            //    Console.WriteLine(d);
            //}
            //Array.Reverse(charArray);
            //Console.WriteLine();
            //foreach (var d in charArray)
            //{
            //    Console.WriteLine(d);
            //}
            //string yeni_metin = string.Join("", charArray);
            //Console.WriteLine(yeni_metin);
            //Console.ReadLine();


            //Console.WriteLine("kelime girin   :       ");
            //string kelime = Console.ReadLine();
            //string[] strings = kelime.Split(' ');
            //char[] charArray = string.Join(" ", strings).ToCharArray();
            //Array.Reverse(charArray);
            //string ters_kelime = string.Join(" ", charArray);
            //Console.WriteLine("yazdığınız kelimenin tersi :   " + ters_kelime);
            //Console.ReadKey();

            







        }
    }
}