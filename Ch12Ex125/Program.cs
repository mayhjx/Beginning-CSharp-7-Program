using System;
using System.Collections;
using System.Collections.Generic;

namespace Ch12Ex125
{
    class Program
    {
        static void Main(string[] args)
        {
            ShortList<int> shortList = new ShortList<int>();

            for (int i = 0; i < 10; i++)
            {
                shortList.Add(i);
            }

            foreach (var item in shortList)
            {
                Console.WriteLine(item);
            }
        }
    }

    /// <summary>
    /// Create a generic class called ShortList<T> that implements IList<T> and consists of a
    /// collection of items with a maximum size.This maximum size should be an integer that can
    /// be supplied to the constructor of ShortList<T> or defaults to 10. The constructor should
    /// also be able to take an initial list of items via an IEnumerable<T> parameter.The class should
    /// function exactly like List<T> but throw an exception of type IndexOutOfRangeException
    /// if an attempt is made to add too many items to the collection, or if the IEnumerable<T>
    /// passed to the constructor contains too many items.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ShortList<T> : IList<T>
    {
        private IList<T> innerCollection;
        private int maxSize = 10;

        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ShortList() : this(10)
        {
        }
        public ShortList(int size)
        {
            maxSize = size;
            innerCollection = new List<T>();
        }
        public ShortList(IEnumerable<T> list) : this(10, list)
        {
        }
        public ShortList(int size, IEnumerable<T> list)
        {
            maxSize = 10;
            innerCollection = new List<T>(list);
            if (Count > maxSize)
            {
                ThrowTooManyItemsException();
            }
        }

        protected void ThrowTooManyItemsException()
        {
            throw new IndexOutOfRangeException(
                "Unable to add any more items, maxium size is " + maxSize.ToString() +
                " items");
        }

        #region IList<T> Members
        public int IndexOf(T item) => innerCollection.IndexOf(item);

        public void Insert(int index, T item)
        {
            if (Count < maxSize)
            {
                innerCollection.Insert(index, item);
            }
            else
            {
                ThrowTooManyItemsException();
            }
        }
        public void RemoveAt(int index)
        {
            innerCollection.RemoveAt(index);
        }
        #endregion

        #region ICollection<T> Members
        public void Add(T item)
        {
            if (Count < maxSize)
            {
                innerCollection.Add(item);
            }
            else
            {
                ThrowTooManyItemsException();
            }
        }
        public void Clear()
        {
            innerCollection.Clear();
        }

        public bool Contains(T item) => innerCollection.Contains(item);

        public void CopyTo(T[] array, int arrayIndex)
        {
            innerCollection.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item) => innerCollection.Remove(item);

        public int Count => innerCollection.Count;

        public bool IsReadOnly => innerCollection.IsReadOnly;
        #endregion

        #region IEnumerator<T> Members
        public IEnumerator<T> GetEnumerator() =>
            innerCollection.GetEnumerator();
        #endregion

        #region IEnumerable Members
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}
