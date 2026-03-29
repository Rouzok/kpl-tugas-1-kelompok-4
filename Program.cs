using System;
using System.Collections.Generic;

public enum DaftarKata
{
    air, fire, water, earth
}

class PencocokKata
{
    // Table-driven: pasangan kata berdasarkan index enum
    private string[] pasangan = {
        "udara", // air
        "api",   // fire
        "air",   // water
        "tanah"  // earth
    };

    public string AmbilPasangan(DaftarKata kata)
    {
        return pasangan[(int)kata];
    }
}

// Simulasi tampilan soal
public class QuizForm
{
    private PencocokKata logic = new PencocokKata();

    public void TampilkanSoal()
    {
        Console.WriteLine("=== Soal Mencocokkan Kata ===\n");

        foreach (DaftarKata kata in Enum.GetValues(typeof(DaftarKata)))
        {
            string arti = logic.AmbilPasangan(kata);
            Console.WriteLine($"{kata} | {arti}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        QuizForm quiz = new QuizForm();
        quiz.TampilkanSoal();
    }
}