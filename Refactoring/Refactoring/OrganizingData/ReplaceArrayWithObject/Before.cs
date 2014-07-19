using System;

namespace Refactoring.OrganizingData.ReplaceArrayWithObject
{
    public class Before
    {
        readonly String[] _row = new String[3];

        public void SetExample()
        {
            _row[0] = "Liverpool";
            _row[1] = "15";
        }

        public void GetExample()
        {
            string name = _row[0];
            int wins = Convert.ToInt32(_row[1]);
            
            // ..
        }

    }
}
