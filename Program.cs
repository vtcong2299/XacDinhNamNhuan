using System;
 

namespace XacDinhNamNhuan
{
    class Program
    {
        static void Main(string[]args)
        {
            int year;
            Console.Write("Nhap vao nam muon xac dinh: ");
            year = int .Parse(Console.ReadLine());
            
            
            if ((year%4==0 && year%100!=0) || year%400==0)
            {
                Console.WriteLine("Nam {0} la nam nhuan: ", year);
            }
            
            else 
            Console.WriteLine("Nam {0} khong phai la nam nhuan: ", year);
            
            
            Console.ReadKey();
        }
    }
}