using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericType_Debby
{
    internal class Program
    {
        public static T InputData<T>(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return (T)Convert.ChangeType(input, typeof(T));
        }

        static void Main(string[] args)
        {
            string nama = InputData<string>("Masukkan nama anda : ");

            int point = 0;

            Console.WriteLine("Selamat kamu sudah menyelesaikan 1 level!");

            point += 10;

            Console.WriteLine($"\nNama  : {nama}");
            Console.WriteLine($"Point : {point}");

            Console.ReadLine();
        }
    }
}
