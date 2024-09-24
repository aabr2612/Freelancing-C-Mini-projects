using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    public class GymManager : IGymManager
    {
        private static List<GymSite> gymSites = new List<GymSite>();
        private static List<Trainer> trainers = new List<Trainer>();

        public GymManager() { }

        public List<Trainer> GetTrainers()
        {
            return trainers;
        }
        public GymSite CheckGymSites(string id)
        {
            foreach (GymSite site in gymSites)
            {
                if (site.GetSiteId() == id)
                {
                    return site;
                }
            }
            return null;
        }
        public string AddGymSite(GymSite site)
        {
            foreach (GymSite existingSite in gymSites)
            {
                if (existingSite.GetSiteId() == site.GetSiteId())
                {
                    return "Gym site already exists.";
                }
            }
            gymSites.Add(new GymSite(site));
            return "Gym site added successfully.";
        }

        public string AddTrainer(Trainer trainer)
        {
            foreach (Trainer existingTrainer in trainers)
            {
                if (existingTrainer.GetRegistrationNumber() == trainer.GetRegistrationNumber())
                {
                    return "A trainer with this registration number already exists.";
                }
            }
            trainers.Add(trainer);
            return "Trainer added successfully.";
        }

        public string DeleteTrainer(string registrationNumber)
        {
            for (int i = 0; i < trainers.Count; i++)
            {
                if (trainers[i].GetRegistrationNumber() == registrationNumber)
                {
                    trainers.RemoveAt(i);
                    return "Trainer deleted successfully.";
                }
            }
            return "Trainer not found.";
        }

        public List<Trainer> ListTrainersAlphabetically()
        {
            trainers.Sort(new NameComparer());
            return new List<Trainer>(trainers);
        }

        public List<Trainer> ListTrainersByExperience()
        {
            trainers.Sort(new ExperienceComparer());
            return new List<Trainer>(trainers);
        }

        public string GenerateSessionBookings(string date)
        {
            try
            {
                List<Session> sessions = new List<Session>();
                foreach (Trainer trainer in trainers)
                {
                    foreach (Session session in trainer.GetTrainingSessions())
                    {
                        if (session.GetTimeslot().Contains(date))
                        {
                            sessions.Add(session);
                        }
                    }
                }
                using (StreamWriter sw = new StreamWriter("session_bookings.txt"))
                {
                    foreach (Session session in sessions)
                    {
                        sw.WriteLine($"{session.GetSessionId()}, {session.GetMember()}, {session.GetTrainer().GetName()}, {session.GetTimeslot()}, {session.GetSite().GetLocation()}");
                    }
                }
                return "Session bookings generated successfully.";
            }
            catch (Exception ex)
            {
                return $"An error occurred while generating session bookings: {ex.Message}";
            }
        }
    }
}
