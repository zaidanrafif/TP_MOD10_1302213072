using AljabarLibraries;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("A. Mencari akar - akar dari persamaan kuadrat");
        Console.Write("Masukkan koefisien a, b, c: ");
        string[] inputKoefisien = Console.ReadLine().Split(',');
        double a = Convert.ToDouble(inputKoefisien[0]);
        double b = Convert.ToDouble(inputKoefisien[1]);
        double c = Convert.ToDouble(inputKoefisien[2]);

        double[] persamaan = { a, b, c };
        try
        {
            double[] akar = PersamaanKuadrat.AkarPersamaanKuadrat(persamaan);
            Console.Write("Output: {");
            for (int i = 0; i < akar.Length; i++)
            {
                Console.Write(akar[i]);
                if (i < akar.Length - 1)
                {
                    Console.Write(", ");
                }
            }Console.WriteLine("}");Console.WriteLine();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine("B. Mendapatkan hasil kuadrat dari persamaan berpangkat 1");
        Console.Write("Masukkan koefisien a, b: ");
        inputKoefisien = Console.ReadLine().Split(',');
        a = Convert.ToDouble(inputKoefisien[0]);
        b = Convert.ToDouble(inputKoefisien[1]);

        double[] persamaan2 = { a, b };
        double[] hasilKuadrat = PersamaanKuadrat.HasilKuadrat(persamaan2);
        Console.Write("Output: {");
        for (int i = 0; i < hasilKuadrat.Length; i++)
        {
            Console.Write(hasilKuadrat[i]);
            if (i < hasilKuadrat.Length - 1)
            {
                Console.Write(", ");
            }
            
        }Console.WriteLine("}");
    }
}
