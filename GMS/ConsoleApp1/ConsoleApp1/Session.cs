namespace ConsoleApp1
{
    public class Session
    {
        private string sessionId;
        private string member;
        private Trainer trainer;
        private string timeslot;
        private GymSite site;

        public Session(string sessionId, string member, Trainer trainer, string timeslot, GymSite site)
        {
            this.sessionId = sessionId;
            this.member = member;
            this.trainer = trainer;
            this.timeslot = timeslot;
            this.site = site;
        }
        public Session(Session session)
        {
            sessionId = session.sessionId;
            member =session.member;
            trainer =session.trainer;
            timeslot = session.timeslot;
            site = session.site;
        }

        public string GetSessionId()
        {
            return sessionId;
        }
        public void SetSessionId(string sessionId)
        {
            this.sessionId = sessionId;
        }
        public string GetMember()
        {
            return member;
        }
        public void SetMember(string member)
        {
            this.member = member;
        }
        public Trainer GetTrainer()
        {
            return trainer;
        }
        public void SetTrainer(Trainer trainer)
        {
            this.trainer = trainer;
        }
        public string GetTimeslot()
        {
            return this.timeslot;
        }
        public void SetTimeslot(string timeslot)
        {
            this.timeslot = timeslot;
        }
        public GymSite GetSite()
        {
            return this.site;
        }
        public void SetSite(GymSite site)
        {
            this.site = site;
        }
    }
}
