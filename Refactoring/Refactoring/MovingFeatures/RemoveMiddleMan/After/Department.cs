using System;

namespace Refactoring.MovingFeatures.RemoveMiddleMan.After
{
    public class Department
    {
        private String _chargeCode;
        private readonly Person _manager;

        public Department(Person manager, string chargeCode)
        {
            _manager = manager;
            _chargeCode = chargeCode;
        }

        public Person GetManager()
        {
            return _manager;
        }

    }
}
