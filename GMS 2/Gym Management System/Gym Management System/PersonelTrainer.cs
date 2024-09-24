using System.Collections.Generic;

namespace Gym_Management_System
{
    internal abstract class PersonelTrainer
    {
        protected string regNo;
        protected string fullName;
        protected int experience;
        protected string certificates;
        protected string trainingStyles;
        protected double sessionFee;
        protected List<TrainingSession> trainingSessions;
        public PersonelTrainer(string regNo, string fullName, int experience, string certificates, string trainingStyles, double sessionFee)
        {
            this.regNo = regNo;
            this.fullName = fullName;
            this.experience = experience;
            this.certificates= certificates;
            this.trainingStyles = trainingStyles;
            this.sessionFee = sessionFee;
            trainingSessions = new List<TrainingSession>();
        }
        public PersonelTrainer(string regNo)
        {
            this.regNo=regNo;
        }
        public string GetRegNo()
        {
            return regNo;
        }
        public void SetRegNo(string regNo)
        {
            this.regNo = regNo;
        }
        public string GetTrainerName()
        {
            return fullName;
        }
        public void SetTrainerName(string fullName)
        {
            this.fullName = fullName;
        }
        public int GetExperience()
        {
            return experience;
        }
        public void SetExperience(int experience)
        {
            this.experience = experience;
        }
        public string GetCertificates()
        {
            return certificates;
        }
        public void SetCertificates(string certificates)
        {
            this.certificates = certificates;
        }
        public string GetTrainingStyles()
        {
            return trainingStyles;
        }
        public void SetTrainingStyles(string trainingStyles)
        {
            this.trainingStyles = trainingStyles;
        }
        public double GetSessionFee()
        {
            return sessionFee;
        }
        public void SetSessionFee(double sessionFee)
        {
            this.sessionFee = sessionFee;
        }
        public List<TrainingSession> GetTrainingSessions()
        {
            return trainingSessions;
        }
        public void SetTrainingSessions(List<TrainingSession> trainingSessions)
        {
            this.trainingSessions = trainingSessions;
        }
        public void AddTrainingSession(TrainingSession session)
        {
            trainingSessions.Add(new TrainingSession(session));
        }
        public void RemoveTrainingSession(TrainingSession session)
        {
            trainingSessions.Remove(session);
        }
    }
}
