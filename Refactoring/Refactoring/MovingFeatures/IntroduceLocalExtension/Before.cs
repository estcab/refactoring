﻿using System;

namespace Refactoring.MovingFeatures.IntroduceLocalExtension
{
    public class Before
    {
        public void Example(DateTime previousEnd)
        {
            // ...

            var newStart = new DateTime(previousEnd.Year, 
                previousEnd.Month, previousEnd.Day + 1);

            
            // ...
        }
    }
}
