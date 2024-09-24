namespace Gym_Management_System
{
    internal class TrainingSession
    {
        private string sessionCode;
        private string memberName;
        private PersonelTrainer coach;
        private string sessionTime;
        private GymLocation location;
        public TrainingSession(string sessionCode, string memberName, PersonelTrainer coach, string sessionTime, GymLocation location)
        {
            this.sessionCode = sessionCode;
            this.memberName = memberName;
            this.coach = coach;
            this.sessionTime = sessionTime;
            this.location = location;
        }
        public TrainingSession(TrainingSession session)
        {
            this.sessionCode = session.sessionCode;
            this.memberName = session.memberName;
            this.coach = session.coach;
            this.sessionTime = session.sessionTime;
            this.location = session.location;
        }
        public string GetSessionCode()
        {
            return sessionCode;
        }
        public void SetSessionCode(string sessionCode)
        {
            this.sessionCode = sessionCode;
        }
        public string GetMemberName()
        {
            return memberName;
        }
        public void SetMemberName(string memberName)
        {
            this.memberName = memberName;
        }
        public PersonelTrainer GetCoach()
        {
            return coach;
        }
        public void SetCoach(PersonelTrainer coach)
        {
            this.coach = coach;
        }
        public string GetSessionTime()
        {
            return sessionTime;
        }
        public void SetSessionTime(string sessionTime)
        {
            this.sessionTime = sessionTime;
        }
        public GymLocation GetLocation()
        {
            return location;
        }
        public void SetLocation(GymLocation location)
        {
            this.location = location;
        }
    }
}
