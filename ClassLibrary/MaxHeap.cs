using System;

namespace ClassLibrary
{
    public class MaxHeap<T> : MinMaxHeap<T> where T : IComparable<T>
    {
        public MaxHeap(int size) :
             base(size)
        {
        }

        protected override void ReCalculateDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                var biggerIndex = GetLeftChildIndex(index);
                if (HasRightChild(index)
                    && GetRightChild(index).CompareTo(GetLeftChild(index)) > 0)
                //&& GetRightChild(index) > GetLeftChild(index))
                {
                    biggerIndex = GetRightChildIndex(index);
                }

                if (_elements[biggerIndex].CompareTo(_elements[index]) < 0)
                //if (_elements[biggerIndex] < _elements[index])
                {
                    break;
                }

                Swap(biggerIndex, index);
                index = biggerIndex;
            }
        }

        protected override void ReCalculateUp()
        {
            var index = _size - 1;
            while (!IsRoot(index)
                && _elements[index].CompareTo(GetParent(index)) > 0)
            //&& _elements[index] > GetParent(index))
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }
    }
}
