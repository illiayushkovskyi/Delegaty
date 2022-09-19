using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    
    internal class Program
    {
        public delegate int MyDelegat(int a, int b);

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введите действие +,-,*,/");
            string deystvie = Console.ReadLine();
            Console.WriteLine("Первое число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число");
            int y = Convert.ToInt32(Console.ReadLine());
            switch (deystvie)
            {
                case "+":
                    MyDelegat myDelegat = (c, b) => { return c + b; };
                    int add = myDelegat(x, y);
                    Console.WriteLine("Ответ:{0}", add);
                    break;
                case "-":
                    MyDelegat myDelegat1 = (c, b) => { return c - b; };
                    int sub = myDelegat1(x, y);
                    Console.WriteLine("Ответ:{0}", sub);
                    break;
                case "*":
                    MyDelegat myDelegat2 = (c, b) => { return c * b; };
                    int mul = myDelegat2(x, y);
                    Console.WriteLine("Ответ:{0}", mul);
                    break;
                case "/":
                    MyDelegat myDelegat3 = (c, b) => { return c / b; };
                    int div = myDelegat3(x, y);
                    Console.WriteLine("Ответ:{0}", div);
                    break;
                default:
                    Console.WriteLine("Ошибка. Выберите из : +,-,*,/");
                    break;
            }

            Console.ReadKey();
        }
    }
}
