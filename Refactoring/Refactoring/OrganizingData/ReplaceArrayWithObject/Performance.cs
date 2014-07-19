using System;

namespace Refactoring.OrganizingData.ReplaceArrayWithObject
{
    public class Performance
    {
        private string _name;
        private string _wins;

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public int GetWins()
        {
            return Convert.ToInt32(_wins);
        }

        public void SetWins(string wins)
        {
            _wins = wins;
        }
    }
}