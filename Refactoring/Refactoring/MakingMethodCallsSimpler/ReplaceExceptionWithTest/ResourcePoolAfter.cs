using System.Collections;
using System.Collections.Generic;

namespace Refactoring.MakingMethodCallsSimpler.ReplaceExceptionWithTest
{
    public class ResourcePoolAfter
    {
        readonly Stack<Resource> _available;
        readonly Stack<Resource> _allocated;

        public ResourcePoolAfter()
        {
            _allocated = new Stack<Resource>();
            _available = new Stack<Resource>();
        }

        public Resource GetResource()
        {
            var result = _available.Count == 0 ? new Resource() : _available.Pop();

            _allocated.Push(result);
            return result;

        }
    }
}
