
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary.Tests
{
    [TestClass]
    public class MaxHeapTests
    {
        [TestMethod]
        public void HeapOfIntTest()
        {
            var maxHeap = new MaxHeap<int>(5);
            maxHeap.Add(3);
            Assert.AreEqual(3, maxHeap.Peek());

            maxHeap.Add(8);
            Assert.AreEqual(8, maxHeap.Peek());

            maxHeap.Add(6);
            maxHeap.Add(1);
            Assert.AreEqual(8, maxHeap.Peek());
            maxHeap.Add(12);
            Assert.AreEqual(12, maxHeap.Peek());

            maxHeap.Pop();
            Assert.AreEqual(8, maxHeap.Peek());

            maxHeap.Add(5);
            Assert.AreEqual(8, maxHeap.Peek());

            var expectPopValues = new int[] { 8, 6, 5, 3, 1 };
            foreach(var expected in expectPopValues)
            {
                var actual = maxHeap.Pop();
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
