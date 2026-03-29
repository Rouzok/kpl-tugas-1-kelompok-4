using QuizInggris_TableDriven;
using System;

namespace QuizInggris_TableDriven
{
    public enum DaftarKata
    {
        thelf, wainch, going, anslip, anspe, see, an, good,
        caffie, sier, elm, nineteen, water, brother, easy, give, @new, daiy
    }

    class PemeriksaKata
    {
        private bool[] tabelValidasi = {
                false, // thelf
                false, // wainch
                true,  // going
                false, // anslip
                false, // anspe
                true,  // see
                true,  // an
                true,  // good
                false, // caffie
                false, // sier
                true,  // elm
                true,  // nineteen
                true,  // water
                true,  // brother
                true,  // easy
                true,  // give
                true,  // new
                false  // daiy
            };

        public bool CekKebenaran(DaftarKata kata)
        {
            return tabelValidasi[(int)kata];
        }
    }


    // Kemungkinan Implementasi di windows app
    public class QuizForm
    {
        private PemeriksaKata logic = new PemeriksaKata();

        // Simulasi Event Handler saat tombol "Submit" diklik di UI
        public void btnSubmit_Click(List<string> pilihanUser)
        {
            Console.WriteLine("--- Hasil Pengecekan Jawaban ---");
            int kataYangBenar = 11;
            int skor = 0;

            foreach (string kataInput in pilihanUser)
            {
                if (Enum.TryParse(kataInput, out DaftarKata kataEnum))
                {
                    if (logic.CekKebenaran(kataEnum))
                    {
                        Console.WriteLine($"[BENAR] {kataInput} adalah kata bahasa Inggris nyata.");
                        skor++;
                    }
                    else
                    {
                        Console.WriteLine($"[SALAH] {kataInput} bukan kata bahasa Inggris nyata.");
                    }
                }
            }
            Console.WriteLine($"\nTotal Skor: {skor} dari {kataYangBenar} kata dipilih.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            QuizForm simulation = new QuizForm();
            List<string> kataDipilih = new List<string> { "going", "thelf", "water", "new" };

            simulation.btnSubmit_Click(kataDipilih);
        }
    }
}