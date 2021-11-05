using System;

namespace positivenegative
{
    class Program
    {
        static void Main(string[] args)
        {   
            int sayi;
            Console.WriteLine("Bir sayı giriniz.");
            sayi =int.Parse(Console.ReadLine());
            
            
             
            if (sayi < 0)
            {
                Console.WriteLine("Girdiğiniz sayı negatif.");

            }
            else if(sayi>0)
            {
                Console.WriteLine("Girdiğiniz sayı pozitif.");

            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı sıfır.");
            }
            Console.ReadKey();
        }
    }
}
