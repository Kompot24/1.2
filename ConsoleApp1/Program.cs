using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    public class Logic
    {
        public static string Compare(int[] mass)
        {
            string outMessage = "";
            int count5 = 0;
            int count4 = 0;
            int count3 = 0;
            int count2 = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] == 5)
                {
                    count5++;
                }
                else if (mass[i] == 4)
                {
                    count4++;
                }
                else if (mass[i] == 3)
                {
                    count3++;
                }
                else
                {
                    count2++;
                }
            }
            outMessage = $"Кол-во 5: {count5} 4: {count4} 3: {count3} 2: {count2}";
            return outMessage;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[10];
            int number;
            for(int i  = 0; i < mass.Length; i++)
            {
                Console.WriteLine("Введите оценки учеников");
                number = int.Parse(Console.ReadLine());
                mass[i] = number; 
            }

            string outMessage = Logic.Compare(mass);
            Console.WriteLine(outMessage);
        }
    }
}
