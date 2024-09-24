namespace Gym_Management_System
{
    internal class KarateInstructor : PersonelTrainer
    {
        public KarateInstructor(string regNo, string fullName, int experience, string certificates, string trainingStyles, double sessionFee)
            : base(regNo, fullName, experience, certificates, trainingStyles, sessionFee)
        {
        }
       
    }
}