using System.Collections;

namespace Refactoring.MakingMethodCallsSimpler.ReplaceExceptionWithTest
{
    public class ResourcePoolBefore
    {
        readonly Stack _available;
        readonly Stack _allocated;

        public ResourcePoolBefore()
        {
            _allocated = new Stack();
            _available = new Stack();
        }

        public Resource GetResource()
        {
            Resource result;
            try
            {
                result = (Resource)_available.Pop();
                _allocated.Push(result);
                return result;
            }
            catch (EmptyStackException e)
            {
                result = new Resource();
                _allocated.Push(result);
                return result;
            }
        }
    }
}
