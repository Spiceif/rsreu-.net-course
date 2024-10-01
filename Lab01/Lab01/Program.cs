//var 4

namespace Lab01
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double result;
            result = Math.Pow(-1, n) * ((Math.Pow(n, 2) + 1) / (Math.Pow(n, 3) + 3));
            Console.WriteLine("Результат: ");
            Console.WriteLine(result);
        }
    }
}

