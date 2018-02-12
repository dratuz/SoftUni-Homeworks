namespace BashSoft.DataStructures
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    using BashSoft.Contracts;

    public class SimpleSortedList<T> : ISimpleOrderedBag<T> where T : IComparable<T>
    {
        private const int DefaultSize = 16;

        private T[] innerCollection;
        private int size;
        private IComparer<T> comparison;

        public SimpleSortedList(IComparer<T> comparer, int capacity)
        {
            this.comparison = comparer;
            this.InitializeInnerCollection(capacity);
        }

        public SimpleSortedList(int capacity)
            : this(Comparer<T>.Create((x, y) => x.CompareTo(y)), capacity)
        {
        }

        public SimpleSortedList(IComparer<T> comparer)
            : this(comparer, DefaultSize)
        {
        }

        public int Size
        {
            get { return this.size; }
        }

        public void Add(T element)
        {
            if (this.innerCollection.Length == this.size)
            {
                this.Resize();
            }

            this.innerCollection[this.Size] = element;
            this.size++;
            Array.Sort(this.innerCollection, 0, this.Size, this.comparison);
        }

        public void AddAll(ICollection<T> collection)
        {
            if (this.Size + collection.Count >= this.innerCollection.Length)
            {
                this.MultiResize(collection);
            }

            foreach (var element in collection)
            {
                this.innerCollection[this.Size] = element;
                this.size++;
            }

            Array.Sort(this.innerCollection, 0, this.size, this.comparison);
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Size; i++)
            {
                yield return this.innerCollection[i];
            }
        }

        public string JoinWith(string joiner)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var element in this)
            {
                sb.Append(element);
                sb.Append(joiner);
            }

            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void InitializeInnerCollection(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentException("Capacity cannot be negative!");
            }

            this.innerCollection = new T[capacity];
        }

        private void Resize()
        {
            var newCollection = new T[this.Size * 2];
            Array.Copy(this.innerCollection, newCollection, this.Size);
            this.innerCollection = newCollection;
        }

        private void MultiResize(ICollection<T> collection)
        {
            var newSize = this.innerCollection.Length * 2;
            while (this.Size + collection.Count >= newSize)
            {
                newSize *= 2;
            }

            var newCollection = new T[newSize];
            Array.Copy(this.innerCollection, newCollection, this.size);
            this.innerCollection = newCollection;
        }
    }
}
