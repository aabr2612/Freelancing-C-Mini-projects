using System.Collections.Generic;

namespace ConsoleApp1
{
    public class FitnessTrainer : Trainer
    {
        public FitnessTrainer(string registrationNumber, string name, int experience, List<string> certifications, List<string> styles, decimal sessionPrice)
            : base(registrationNumber, name, experience, certifications, styles, sessionPrice) { }
    }
}