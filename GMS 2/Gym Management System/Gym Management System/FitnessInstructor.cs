namespace Gym_Management_System
{
    internal class FitnessInstructor : PersonelTrainer
    {
        public FitnessInstructor(string regNo, string fullName, int experience, string certificates, string trainingStyles, double sessionFee)
            : base(regNo, fullName, experience, certificates, trainingStyles, sessionFee)
        {
        }
    }
}
