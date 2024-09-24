using System.Collections.Generic;

namespace ConsoleApp1
{
    public class YogaTrainer : Trainer
    {
        public YogaTrainer(string registrationNumber, string name, int experience, List<string> certifications, List<string> styles, decimal sessionPrice)
            : base(registrationNumber, name, experience, certifications, styles, sessionPrice) { }
    }
}
