using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "qeqe0808";
            int triesCount = 3;
            for (int i = 0; i < triesCount; i++)
            {
                Console.Write("Введите пароль: ");

                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Секретное сообщение");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный пароль");
                }
            }
        }
    }
}
