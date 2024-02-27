using System;

namespace ConsoleApp1
{
    internal class Program
  {
     static void Main(string[] args)
  {
            // tür dönüşümleri 
            int a = 0;   
            int b = new int();
            string c = a.ToString() + b.ToString();
            string s = "";
            string e = "merhaba \n";
            string t = "feyza";
            string p = e+ t;
            System.Console.WriteLine(c + "\n" + p);

            byte veri = 5;
            byte veri2 = 9;
            int veri3 = veri+veri2;

            int veri4 = a;
            int veri5 = veri4 + 8;
            int veri6 = a*veri4;
            bool veri7 = false;
            s = a.ToString();
            s = s + "8";

            Console.ReadLine();
           

    //  object x;
     // x=10;
     // Console.WriteLine(x.GetType());
   //   x="B";
   //   Console.WriteLine(x.GetType());
    //  x=8.78d;
    //  Console.WriteLine(x.GetType());
     // x=false ;
   //   Console.WriteLine(x.GetType());
     // x=5.489M;
    //  Console.WriteLine(x.GetType());
   //   x="a";
     // Console.WriteLine(x.GetType());
      
    // Console.Readline();
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


            //OPERATÖRLER( derste yaptıklarımız)
            //int i = 5 * 4 / 6;
            //Console.WriteLine(i);

            //işlem önceliğine önem verir.

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

            //arttırma azaltma

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
            
            // karşılaştırma operatörleri

            //bool a = 30 == 45;
            //bool b = 30 > 45;
            //bool c = 30 < 45;
            //bool d = 30 != 45;
            //bool e = 30 <= 45;
            //bool f = 30 >= 45;
            //Console.WriteLine("{0} \n {1} \n {2} \n {3} \n {4} \n {5}\n ",a,b,c,d,e,f);
            //Console.ReadLine();

            //   AS ve İS  operatörü

            //object o = 25;
            //string s = o as string;
            //int i = 17;
            //bool b = i is int;
            //bool c = i is double ;
            //Console.WriteLine("{0} \n {1} \n {2} \n {3} \n {4} \n  ",o,s,i,b,c);
            //Console.ReadLine();
        }
    }
}
    
     
