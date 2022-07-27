using GenericInterface;
using Vehicles;

namespace GenericArray
{

    public class GenericArray<T> : IGenericArray<T>
    {
        private readonly T[] _array;
        private int _index = - 1;
        private readonly int _length;

        public GenericArray(int length)
        {
            _length = length;
            _array = new T[length];
        }

        public T GetItem(int i) 
        {
            if (i > _index)
                throw new IndexOutOfRangeException("Provided index is out of range");

            return _array[i];
        }

        public void AddItem(T item)
        {
            if(_index >= _length)
                throw new InvalidOperationException("Array is full");
            
            _array[++_index] = item;
        }

        public void SetItem(int index, T item)
        {
            if(index >= _length || index < 0)
                throw new IndexOutOfRangeException("Provided index is out of range or less than 0");
            
            _array[index] = item;
        }

        public void SwapItems(int indexFirstElement, int indexSecondElement)
        {
            if( indexFirstElement < 0 || indexFirstElement >= _length ||
                indexSecondElement < 0 || indexSecondElement >= _length)
                throw new IndexOutOfRangeException("Provided indexs are invalid! Please double check them!");

            T tmp = _array[indexFirstElement];
            _array[indexFirstElement] = _array[indexSecondElement];
            _array[indexSecondElement] = tmp;
        }

        public int GetLength() => _index + 1;

        public void Print()
        {
            if (_index < 0)
                throw new InvalidOperationException("Array is empty!");

            for (int i = 0; i <= _index; i++)
                Console.WriteLine($"Index {i}: {_array[i]}");
        }
    }
}