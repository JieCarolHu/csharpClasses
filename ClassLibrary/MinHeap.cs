using System;

namespace ClassLibrary
{
    public class MinHeap<T> : MinMaxHeap<T> where T : IComparable<T>
    {
        public MinHeap(int size) :
             base(size)
        {
        }

        protected override void ReCalculateDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                var smallerIndex = GetLeftChildIndex(index);
                if (HasRightChild(index)
                    && GetRightChild(index).CompareTo(GetLeftChild(index)) < 0)
                //&& GetRightChild(index) < GetLeftChild(index))
                {
                    smallerIndex = GetRightChildIndex(index);
                }

                if (_elements[smallerIndex].CompareTo(_elements[index]) >= 0)
                //  if (_elements[smallerIndex] >= _elements[index])
                {
                    break;
                }

                Swap(smallerIndex, index);
                index = smallerIndex;
            }
        }

        protected override void ReCalculateUp()
        {
            var index = _size - 1;
            while (!IsRoot(index)
                && _elements[index].CompareTo(GetParent(index)) < 0)
            // && _elements[index] < GetParent(index))
            {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }
    }
}
