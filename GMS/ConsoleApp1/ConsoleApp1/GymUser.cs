using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class GymUser : IGymUser
    {
        private List<Trainer> trainers;

        public GymUser(List<Trainer> trainers)
        {
            this.trainers = trainers;
        }
        public List<Trainer> GetTrainers()
        {
            return trainers;
        }
        public void SetTrainers(List<Trainer> trainers)
        {
            this.trainers = trainers;
        }

        public List<Trainer> ListAvailableTrainers(string timeslot)
        {
            List<Trainer> availableTrainers = new List<Trainer>();
            foreach (Trainer trainer in trainers)
            {
                bool isAvailable = true;
                foreach (Session session in trainer.GetTrainingSessions())
                {
                    if (session.GetTimeslot() == timeslot)
                    {
                        isAvailable = false;
                        break;
                    }
                }
                if (isAvailable)
                {
                    availableTrainers.Add(trainer);
                }
            }
            availableTrainers.Sort(new SessionPriceComparer());
            return availableTrainers;
        }

        public List<Trainer> ListTrainersByTypeAndTimeslot(Type trainerType, string timeslot)
        {
            List<Trainer> filteredTrainers = new List<Trainer>();
            foreach (Trainer trainer in trainers)
            {
                if (trainer.GetType() == trainerType)
                {
                    bool isAvailable = true;
                    foreach (Session session in trainer.GetTrainingSessions())
                    {
                        if (session.GetTimeslot() == timeslot)
                        {
                            isAvailable = false;
                            break;
                        }
                    }
                    if (isAvailable)
                    {
                        filteredTrainers.Add(trainer);
                    }
                }
            }
            filteredTrainers.Sort(new RegistrationNumberComparer());
            return filteredTrainers;
        }

        public string BookSession(Session session)
        {
            IGymManager gymManager = new GymManager();
            GymSite site = gymManager.CheckGymSites(session.GetSite().GetSiteId());
            if (site == null)
            {
                return "Site not found!";
            }

            Trainer trainer = null;
            foreach (Trainer t in trainers)
            {
                if (t.GetRegistrationNumber() == session.GetTrainer().GetRegistrationNumber())
                {
                    trainer = t;
                    break;
                }
            }

            if (trainer != null)
            {
                session.SetSite(site);
                session.SetTrainer(trainer);
                bool sessionExists = false;
                foreach (Session s in trainer.GetTrainingSessions())
                {
                    if (s.GetSessionId() == session.GetSessionId())
                    {
                        sessionExists = true;
                        break;
                    }
                }
                if (sessionExists)
                {
                    return "Session booking failed. A session with the same ID already exists.";
                }

                bool isTrainerAvailable = true;
                foreach (Session s in trainer.GetTrainingSessions())
                {
                    if (s.GetTimeslot() == session.GetTimeslot())
                    {
                        isTrainerAvailable = false;
                        break;
                    }
                }
                if (isTrainerAvailable)
                {
                    trainer.GetTrainingSessions().Add(new Session(session));
                    return "Session booked successfully.";
                }
                else
                {
                    return "Session booking failed. Trainer might be already booked.";
                }
            }

            return "Session booking failed. Trainer not found.";
        }

        public string CancelSession(string sessionId)
        {
            foreach (Trainer trainer in trainers)
            {
                Session session = null;
                foreach (Session s in trainer.GetTrainingSessions())
                {
                    if (s.GetSessionId() == sessionId)
                    {
                        session = s;
                        break;
                    }
                }

                if (session != null)
                {
                    trainer.GetTrainingSessions().Remove(session);
                    return "Session cancelled successfully.";
                }
            }
            return "Session not found.";
        }
    }
}
