using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty
{
    public delegate int Arifmetic(int first, int second, int third);
    internal class Program
    {
        static void Main(string[] args)
        {
            Arifmetic SredneeArifm = delegate (int first, int second, int third)
            {
                return (first + second + third) / 3;
            };

            Calculate calculate = new Calculate();
            calculate.LetsGo = SredneeArifm;

            int result = calculate.LetsGo( 18, 5, 16);
            Console.WriteLine(result);

            Console.ReadKey();
        }


        class Calculate
        {
            public Arifmetic LetsGo { get; set; }
        }
    }
}
