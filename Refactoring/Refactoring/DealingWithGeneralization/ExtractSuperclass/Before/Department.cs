using System.Collections.Generic;
using System.Linq;

namespace Refactoring.DealingWithGeneralization.ExtractSuperclass.Before
{
    public class Department
    {
        private readonly string _name;
        private readonly List<Employee> _staff = new List<Employee>();

        public Department(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public int GetTotalAnnualCost()
        {
            return _staff.Sum(employee => employee.AnnualCost);
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
