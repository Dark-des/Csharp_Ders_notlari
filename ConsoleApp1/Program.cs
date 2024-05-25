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
           
            
        }
    }
}

     //1.bilinçsiz tür dönüşümleri 
      
     