using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class SessionPriceComparer : IComparer<Trainer>
    {
        public int Compare(Trainer x, Trainer y)
        {
            try
            {
                if (x == null || y == null)
                    throw new ArgumentNullException("Trainers being compared cannot be null.");
                return x.GetSessionPrice().CompareTo(y.GetSessionPrice());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error comparing session prices: {ex.Message}");
                return 0;
            }
        }
    }

    public class RegistrationNumberComparer : IComparer<Trainer>
    {
        public int Compare(Trainer x, Trainer y)
        {
            try
            {
                if (x == null || y == null)
                    throw new ArgumentNullException("Trainers being compared cannot be null.");
                return string.Compare(x.GetRegistrationNumber(), y.GetRegistrationNumber(), StringComparison.Ordinal);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error comparing registration numbers: {ex.Message}");
                return 0;
            }
        }
    }

    public class NameComparer : IComparer<Trainer>
    {
        public int Compare(Trainer x, Trainer y)
        {
            try
            {
                if (x == null || y == null)
                    throw new ArgumentNullException("Trainers being compared cannot be null.");
                return string.Compare(x.GetName(), y.GetName(), StringComparison.Ordinal);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error comparing names: {ex.Message}");
                return 0;
            }
        }
    }

    public class ExperienceComparer : IComparer<Trainer>
    {
        public int Compare(Trainer x, Trainer y)
        {
            try
            {
                if (x == null || y == null)
                    throw new ArgumentNullException("Trainers being compared cannot be null.");
                return y.GetExperience().CompareTo(x.GetExperience());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error comparing experience: {ex.Message}");
                return 0;
            }
        }
    }
}
