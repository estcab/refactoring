using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.ComposingMethods.InlineMethod
{
    public class After
    {
        private readonly decimal _numberOfLateDeliveries;

        public After(decimal numberOfLateDeliveries)
        {
            _numberOfLateDeliveries = numberOfLateDeliveries;
        }

        public int GetRating()
        {
            return _numberOfLateDeliveries > 5 ? 2 : 1;
        }
    }
}
