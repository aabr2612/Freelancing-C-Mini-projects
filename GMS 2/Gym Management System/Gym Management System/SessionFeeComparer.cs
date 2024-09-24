using System;
using System.Collections.Generic;

namespace Gym_Management_System
{
    internal class SessionFeeComparer : IComparer<PersonelTrainer>
    {
        public int Compare(PersonelTrainer x, PersonelTrainer y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentException("Cannot compare null values");
            }
            return x.GetSessionFee().CompareTo(y.GetSessionFee());
        }
    }
}
