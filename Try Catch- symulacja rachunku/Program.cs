using System.IO;
class Paragaon
{



    static void Main(string[] args)
    {
        string nazwa_produktu;
        double cena_produktu;
        double ilosc_produktu;
        double upust;
        double rabat;
        double wartosc;
        double wartosc_rabatu;
        double wartosc_do_zaplaty;
        FileStream F = new FileStream("paragon.txt", FileMode.Create);
        StreamWriter zapis = new StreamWriter(F);
        Console.Write("Podaj nazwę produktu: ");
        nazwa_produktu = Console.ReadLine();
        try
        {
            //Console.Write("Podaj nazwę produktu: ");
            //nazwa_produktu = isString(Console.ReadLine());
            Console.Write("Podaj cenę produktu: ");
            cena_produktu = double.Parse(Console.ReadLine());
            Console.Write("Podaj liczbę sztuk: ");
            ilosc_produktu = double.Parse(Console.ReadLine());
            Console.Write("Podaj rabat (%): ");
            rabat = double.Parse(Console.ReadLine());
           

        } catch(Exception)
        {
           Console.Write("Podano nieprawidłowe dane!");
            zapis.Close();
            return;
        }
        zapis.WriteLine();
        zapis.WriteLine("Rachunek: ");
        zapis.WriteLine("==========================================");
        zapis.WriteLine("                RACHUNEK             ");
        zapis.WriteLine("==========================================");
        zapis.WriteLine();
        zapis.WriteLine($"Produkt: {nazwa_produktu}");
        zapis.WriteLine($"Cena: {cena_produktu:F2} zł");
        zapis.WriteLine($"Liczba sztuk: {ilosc_produktu}");
        zapis.WriteLine();
        wartosc = cena_produktu * ilosc_produktu;
        wartosc_rabatu = wartosc * (rabat / 100);
        wartosc_do_zaplaty = wartosc - wartosc_rabatu;
        zapis.WriteLine($"Wartość: {wartosc:F2} zł");
        zapis.WriteLine($"Rabat: {rabat} %");
        zapis.WriteLine($"Kwota rabatu: {wartosc_rabatu:F2} zł");
        zapis.WriteLine();
        zapis.WriteLine($"DO ZAPŁATY: {wartosc_do_zaplaty:F2} zł");
        zapis.WriteLine();
        zapis.WriteLine("==========================================");
        zapis.Close();
        F.Close();
        FileStream F1 = new FileStream("paragon.txt", FileMode.Open);
        StreamReader odczyt = new StreamReader(F1);
        string odczytanie;
        while ((odczytanie = odczyt.ReadLine()) != null)
        {
            Console.WriteLine(odczytanie);
        }
        F1.Close();
        odczyt.Close();


    }
}