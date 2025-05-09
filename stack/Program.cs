using System;
using System.Collections.Generic;

namespace MessageApp
{
    public class Stack<T>
    {
        private LinkedList<T> items;

        public Stack()
        {
            items = new LinkedList<T>();
        }

        public void Push(T item)
        {
            items.AddFirst(item);
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Mesaj yok.");

            T value = items.First.Value;
            items.RemoveFirst();
            return value;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Mesaj yok.");

            return items.First.Value;
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }

        public int Count()
        {
            return items.Count;
        }
    }
}