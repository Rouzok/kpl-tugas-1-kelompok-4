using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Table-driven: pasangan kata (Inggris -> Indonesia)
        Dictionary<string, string> table = new Dictionary<string, string>()
        {
            {"Apple", "Apel"},
            {"Cat", "Kucing"},
            {"Book", "Buku"}
        };

        Console.WriteLine("Soal Mencocokkan Kata:\n");

        int score = 0;

        foreach (var item in table)
        {
            Console.Write($"Apa arti dari '{item.Key}'? ");
            string jawaban = Console.ReadLine();

            // cek jawaban
            if (jawaban.Equals(item.Value, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Benar!\n");
                score++;
            }
            else
            {
                Console.WriteLine($"Salah! Jawaban yang benar: {item.Value}\n");
            }
        }

        Console.WriteLine($"Skor akhir: {score} / {table.Count}");
    }
}