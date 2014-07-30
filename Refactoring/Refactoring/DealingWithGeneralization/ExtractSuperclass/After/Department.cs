using System.Collections.Generic;
using System.Linq;

namespace Refactoring.DealingWithGeneralization.ExtractSuperclass.After
{
    public class Department : Party
    {
        private readonly List<Employee> _staff = new List<Employee>();

        public Department(string name)
            : base(name)
        {
        }

        public override int GetAnnualCost()
        {
            return _staff.Sum(employee => employee.GetAnnualCost());
        }

        public int GetHeadCount()
        {
            return _staff.Count;
        }

        public IEnumerable<Employee> GetStaff()
        {
            return _staff;
        }

        public void AddStaff(Employee arg)
        {
            _staff.Add(arg);
        }

    }
}
