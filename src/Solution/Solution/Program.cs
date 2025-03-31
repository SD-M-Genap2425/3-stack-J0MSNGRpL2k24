using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;
using static Solution.BrowserHistory.Halaman;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Browser history
        HistoryManager history = new HistoryManager();

        history.KunjungiHalaman("google.com");
        history.KunjungiHalaman("youtube.com");
        history.KunjungiHalaman("stackoverflow.com");
        history.KunjungiHalaman("roblox.com");
        history.KunjungiHalaman("chatgpt.com");

        Console.WriteLine($"Halaman saat ini: {history.LihatHalamanSaatIni()}");

        Console.WriteLine("Kembali ke halaman sebelumnya...");
        history.Kembali();
        Console.WriteLine($"Halaman saat ini: {history.LihatHalamanSaatIni()}");

        Console.WriteLine("Menampilkan history:");
        history.TampilkanHistory();



        // Bracket validator

        var validator = new BracketValidator();

        string ekspresiValid = "[{}](){}";
        string ekspresiInvalid = "(]";

        Console.WriteLine($"Ekspresi '{ekspresiValid}' valid? {validator.ValidasiEkspresi(ekspresiValid)}");
        Console.WriteLine($"Ekspresi '{ekspresiInvalid}' valid? {validator.ValidasiEkspresi(ekspresiInvalid)}");



        //Palindrome Checker

        string[] testPalindromes = { "Cristiano Ronaldo Memenangkan Piala Dunia", "kasurinirusak", "strukdat merupakan matkul yang menyenangkan" };
        foreach (var testPalindrome in testPalindromes)
        {
            Console.WriteLine($"Input: \"{testPalindrome}\" -> Output: {PalindromeChecker.CekPalindrom(testPalindrome)}");




        }
    }
}
