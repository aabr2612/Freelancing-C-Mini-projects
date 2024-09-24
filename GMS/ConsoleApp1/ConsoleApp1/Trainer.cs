using System.Collections.Generic;

namespace ConsoleApp1
{
    public abstract class Trainer
    {
        protected string registrationNumber;
        protected string name;
        protected int experience;
        protected List<string> certifications;
        protected List<string> styles;
        protected decimal sessionPrice;
        protected List<Session> trainingSessions;
        public Trainer(string registrationNumber, string name, int experience, List<string> certifications, List<string> styles, decimal sessionPrice)
        {
            this.registrationNumber = registrationNumber;
            this.name = name;
            this.experience = experience;
            this.certifications = certifications;
            this.styles = styles;
            this.sessionPrice = sessionPrice;
            this.trainingSessions = new List<Session>();
        }
        public string GetRegistrationNumber()
        {
            return registrationNumber;
        }
        public void SetRegistrationNumber(string registrationNumber)
        {
            this.registrationNumber = registrationNumber;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public int GetExperience()
        {
            return experience;
        }
        public void SetExperience(int experience)
        {
            this.experience = experience;
        }
        public List<string> GetCertifications()
        {
            return certifications;
        }
        public void SetCertifications(List<string> certifications)
        {
            this.certifications = certifications;
        }
        public List<string> GetStyles()
        {
            return styles;
        }
        public void SetStyles(List<string> styles)
        {
            this.styles = styles;
        }
        public decimal GetSessionPrice()
        {
            return sessionPrice;
        }
        public void SetSessionPrice(decimal sessionPrice)
        {
            this.sessionPrice = sessionPrice;
        }
        public List<Session> GetTrainingSessions()
        {
            return trainingSessions;
        }
        public void SetTrainingSessions(List<Session> trainingSessions)
        {
            this.trainingSessions = trainingSessions;
        }
    }
}
