namespace Cwiczenia_4_Zad_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = 1, m;

            while (n <= 4)
            {
                m = 1;
                while (m <= 4)
                {
                    if (n == 1 | n == 4 | m == 1 | m == 4) 
                        Console.Write("*");
                    else
                        Console.Write(" ");
                    m++;
                }
                Console.WriteLine();
                n++;
            }

        }
    }
}