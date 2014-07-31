using System;
using System.Collections;

// ReSharper disable once CheckNamespace


namespace Refactoring.DealingWithGeneralization.ReplaceInheritanceWithDelegation.Before
{
    public class MyStack : ArrayList
    {
        public void Push(Object element)
        {
            Insert(0, element);
        }

        public Object Pop()
        {
            var result = this[0];
            RemoveAt(0);
            return result;
        }
    }

}
