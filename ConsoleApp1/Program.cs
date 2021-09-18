using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Randomiz
    {
        public int value;
        public int count;
        public Randomiz(int count)
        {
            this.count = count;
        }
        public void Game()
        {
            Random rand = new Random();
            value = rand.Next(0, 100);
            Console.WriteLine("У вас всего 5 попыток");
            Console.WriteLine(value);
            for (int i = 5; i <= count;)
            {
                int z = Convert.ToInt32(Console.ReadLine());
                if (z == value)
                {
                    i--;
                    int g = count - i;
                    Console.WriteLine($"Молодец, ты победил с {g} попытки "); ;
                    break;
                }
                else
                {
                    i--;
                    Console.WriteLine($"Осталось {i} попыток");
                    if (i == 0) {
                        Console.WriteLine("Вы проиграли");
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int c = 5;
            Randomiz one = new Randomiz(c);

            one.Game();

        }
    }
}
