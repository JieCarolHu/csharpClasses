using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var minHeap = new MinHeap<int>(5);
            minHeap.Add(3);
            minHeap.Add(8);
            minHeap.Add(6);
            minHeap.Add(1);
            minHeap.Add(12);
            minHeap.Pop();
            minHeap.Add(5);

            
            while (minHeap.IsEmpty() == false)
            {
                Console.WriteLine(minHeap.Pop());
            }

            Console.Read();
        }
    }
}
