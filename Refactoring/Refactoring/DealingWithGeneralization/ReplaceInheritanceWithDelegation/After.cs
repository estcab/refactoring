using System;
using System.Collections;

// ReSharper disable once CheckNamespace


namespace Refactoring.DealingWithGeneralization.ReplaceInheritanceWithDelegation.After
{
    public class MyStack
    {
        private readonly ArrayList _array;

        public MyStack()
        {
            this._array = new ArrayList();
        }

        public void Push(Object element)
        {
            _array.Insert(0, element);
        }

        public Object Pop()
        {
            var result = _array[0];
            _array.RemoveAt(0);
            return result;
        }

        public int Size()
        {
            return _array.Count;
        }

        public bool IsEmpty()
        {
            return _array.Count == 0;
        }
    }

}
