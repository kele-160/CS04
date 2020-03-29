using System.Linq;

namespace Lx4.txt2
{
    delegate void TotalC(int[] a);

    class Program
    {
        static void Main(string[] args)
        {
            TotalC cb = delegate (int[] x)

            { 
                Console.WriteLine($"最大值：{x.Max()}");
            };
            cb += delegate (int[] x)
            {
                Console.WriteLine($"最小值：{x.Min()}");
            };
            cb(new[] {78,88,52,66,91});

        }
    }
}
