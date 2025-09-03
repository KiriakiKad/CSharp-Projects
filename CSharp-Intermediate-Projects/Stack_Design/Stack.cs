using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Design
{
    public class Stack
    {
        private List<object> _stack;

        public Stack()
        {
            _stack = new List<object>();
        }

        public void Push(object obj)
        {

            if (obj == null)
                throw new InvalidOperationException("obj cannot be null");

            _stack.Add(obj);
            Console.WriteLine("ADDED: " + obj.ToString());
        }

        public object Pop()
        {

            if (_stack.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            var obj = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1);
            Console.WriteLine("POPPED: " + obj.ToString());
            return obj;
        }

        public void Clear()
        {

            _stack.Clear();
        }
    }
}
