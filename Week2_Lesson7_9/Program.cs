public class Program
{
    private static void Main(string[] args)
    {
        /*
            Napisz program, który odczyta temperaturę I zwróci nazwę jak w poniższych kryteriach
            Temp < 0 – cholernie piździ
            Temp 0 – 10 – zimno
            Temp 10 – 20 – chłodno
            Temp 20 – 30 – w sam raz
            Temp 30 – 40 – zaczyna być słabo, bo gorąco
            Temp >= 40 – a weź wyprowadzam się na Alaskę.
            Dane testowe : 41
            Rezultat w terminalu :
            a weź wyprowadzam się na Alaskę.
        */

        Console.WriteLine("Podaj temperaturę:");
        int temp = Int32.Parse(Console.ReadLine());

        if (temp >= 40)
        {
            Console.WriteLine("a weź wyprowadzam się na Alaskę");
        }
        else if (temp < 40 & temp > 30)
        {
            Console.WriteLine("zaczyna być słabo, bo gorąco");
        }
        else if (temp <= 30 & temp > 20)
        {
            Console.WriteLine("w sam raz");
        }
        else if (temp <= 20 & temp > 10)
        {
            Console.WriteLine("chłodno");
        }
        else if (temp <= 10 & temp >= 0)
        {
            Console.WriteLine("zimno");
        }
        else
        {
            Console.WriteLine("cholernie piździ");
        }

    }

}

