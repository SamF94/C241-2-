using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfectSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(int i in perfectSquare())
            {
                Console.WriteLine(i);
                
            }
            Console.Read();
        }

        public static IEnumerable<int> perfectSquare()
        {
            int i = 1;
            int square;
            int sum = 0;
            while(true)
            {
                if (sum >= 10000) break;
                square = i * i;
                sum += square;
                i++;
                yield return sum;
            }
        }
    }
}
