
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary.Tests
{
    [TestClass]
    public class MinHeapTests
    {
        [TestMethod]
        public void HeapOfIntTest()
        {
            var minHeap = new MinHeap<int>(5);
            minHeap.Add(3);
            Assert.AreEqual(3, minHeap.Peek());

            minHeap.Add(8);
            Assert.AreEqual(3, minHeap.Peek());

            minHeap.Add(6);
            minHeap.Add(1);
            minHeap.Add(12);
            Assert.AreEqual(1, minHeap.Peek());

            minHeap.Pop();
            Assert.AreEqual(3, minHeap.Peek());

            minHeap.Add(5);
            Assert.AreEqual(3, minHeap.Peek());

            var expectPopValues = new int[] { 3, 5, 6, 8, 12 };
            foreach(var expected in expectPopValues)
            {
                var actual = minHeap.Pop();
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
