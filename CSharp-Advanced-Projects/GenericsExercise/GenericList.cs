using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExercise
{
    public class GenericList<T>
    {
        private T[] _items;
        private int _count { get; set; }

        public GenericList()
        {
            _items =new T[10];
            _count = 0;
        }

        public void Add(T item)
        {
            if(_count == _items.Length)
            {
                throw new InvalidOperationException("List is full");
            }
            _items[_count] = item;
            _count++;
        }

        public T Get(int index)
        {
            if(index < 0 || index >= _count)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }
            return _items[index];
        }

        
    }
}
