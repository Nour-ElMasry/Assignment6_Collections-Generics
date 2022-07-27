using Vehicles;

namespace GenericInterface
{
    internal interface IGenericArray<T>
    {
        void AddItem(T item);
        T GetItem(int index);
        int GetLength();
        void SetItem(int index, T item);
        void SwapItems(int indexFirstElement, int indexSecondElement);
        void Print();
    }
}
