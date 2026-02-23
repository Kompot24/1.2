using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mass = [5, 5, 5, 5, 3, 4 ,3 ,3 ,4, 5, 2, 2, 2, 3, 4, 4, 5, 5, 5, 4, 3, 3, 3, 3, 3, 4, 4];
            int count5 = 0;
            int count4 = 0;
            int count3 = 0;
            int count2 = 0;
            for(int i = 0; i < mass.Length; i++)
            {
                if(mass[i] == 5)
                {
                    count5++;
                }else if(mass[i] == 4)
                {
                    count4++;
                }else if(mass[i] == 3)
                {
                    count3++;
                }
                else
                {
                    count2++;
                }
            }
            Console.WriteLine($"Кол-во 5: {count5}");
            Console.WriteLine($"Кол-во 4: {count4}");
            Console.WriteLine($"Кол-во 3: {count3}");
            Console.WriteLine($"Кол-во 2: {count2}");
        }
    }
}
