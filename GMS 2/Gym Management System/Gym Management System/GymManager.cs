using System;
using System.Collections.Generic;
using System.IO;

namespace Gym_Management_System
{
    internal class GymManager : IGymManager, IGymUser
    {
        private static List<GymLocation> gymLocations = new List<GymLocation>();
        private static List<PersonelTrainer> personalTrainers = new List<PersonelTrainer>();
        public GymManager()
        { }
        public string AddGymLocation(GymLocation location)
        {
            foreach (GymLocation existingLocation in gymLocations)
            {
                if (existingLocation.GetSiteNumber() == location.GetSiteNumber())
                {
                    return "Failed to add gym location: Gym location data already exists.";
                }
            }
            gymLocations.Add(location);
            return "Gym location added successfully.";
        }
        public string AddPersonelTrainer(PersonelTrainer trainer)
        {
            foreach (PersonelTrainer existingTrainer in personalTrainers)
            {
                if (existingTrainer.GetRegNo() == trainer.GetRegNo())
                {
                    return "Failed to add trainer: Trainer data already exists.";
                }
            }
            personalTrainers.Add(trainer);
            return "Trainer added successfully.";
        }
        public string RemovePersonelTrainer(string regNo)
        {
            for (int i = 0; i < personalTrainers.Count; i++)
            {
                if (personalTrainers[i].GetRegNo() == regNo)
                {
                    personalTrainers.RemoveAt(i);
                    return "Trainer deleted successfully.";
                }
            }
            return "Trainer not found.";
        }
        public PersonelTrainer GetPersonelTrainerByRegNo(string regNo)
        {
            foreach(PersonelTrainer t in  personalTrainers)
            {
                if(t.GetRegNo()==regNo)
                {
                    return t;
                }
            }
            return null;
        }
        public string BookNewTrainingSession(TrainingSession session)
        {
            bool gymLocationExists = false;
            foreach (GymLocation location in gymLocations)
            {
                if (location.GetSiteNumber() == session.GetLocation().GetSiteNumber())
                {
                    session.SetLocation(location);
                    gymLocationExists = true;
                    break;
                }
            }
            if (!gymLocationExists)
            {
                return "Failed to book session: Gym location does not exist.";
            }

            if (session.GetCoach()==null)
            {
                return "Failed to book session: Trainer not found.";
            }
            bool sessionExists = false;
            PersonelTrainer trainer = session.GetCoach();
            foreach (TrainingSession s in trainer.GetTrainingSessions())
            {
                if (s.GetSessionCode() == session.GetSessionCode())
                {
                    sessionExists = true;
                    break;
                }
            }
            if (sessionExists)
            {
                return "Failed to book session: Session already booked with this ID.";
            }
            bool isTrainerAvailable = true;
            foreach (TrainingSession s in trainer.GetTrainingSessions())
            {
                if (s.GetSessionTime() == session.GetSessionTime())
                {
                    isTrainerAvailable = false;
                    break;
                }
            }
            if (!isTrainerAvailable)
            {
                return "Failed to book session: Trainer not available at the specified timeslot.";
            }
            trainer.AddTrainingSession(session);
            return "Session booked successfully.";
        }
        public string GenerateSessionBookingsReport(string sessionDate)
        {
            try
            {
                List<TrainingSession> sessions = new List<TrainingSession>();
                foreach (PersonelTrainer trainer in personalTrainers)
                {
                    foreach (TrainingSession session in trainer.GetTrainingSessions())
                    {
                        if (session.GetSessionTime().Contains(sessionDate))
                        {
                            sessions.Add(session);
                        }
                    }
                }
                sessions.Sort((s1, s2) => s1.GetSessionCode().CompareTo(s2.GetSessionCode()));
                using (StreamWriter sw = new StreamWriter(sessionDate+".txt"))
                {
                    foreach (TrainingSession session in sessions)
                    {
                        sw.WriteLine($"{session.GetSessionCode()}, {session.GetMemberName()}, {session.GetCoach().GetTrainerName()}, {session.GetSessionTime()}, {session.GetLocation().GetSiteLocation()}");
                    }
                }
                return "Session bookings file generated successfully.";
            }
            catch (Exception ex)
            {
                return $"Failed to generate session bookings file: {ex.Message}";
            }
        }
        public string CancelTrainingSession(string sessionCode)
        {
            foreach (PersonelTrainer trainer in personalTrainers)
            {
                foreach (TrainingSession session in trainer.GetTrainingSessions())
                {
                    if (session.GetSessionCode() == sessionCode)
                    {
                        trainer.RemoveTrainingSession(session);
                        return "Session cancelled successfully.";
                    }
                }
            }
            return "Session not found.";
        }
        public List<PersonelTrainer> ViewTrainersByTypeAndTimeslot(Type trainerType, string timeslot)
        {
            List<PersonelTrainer> filteredTrainers = new List<PersonelTrainer>();
            foreach (PersonelTrainer trainer in personalTrainers)
            {
                if (trainer.GetType() == trainerType)
                {
                    bool isAvailable = true;
                    foreach (TrainingSession session in trainer.GetTrainingSessions())
                    {
                        if (session.GetSessionTime() == timeslot)
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
            filteredTrainers.Sort(new AlphabeticalComparer());
            return filteredTrainers;
        }
        public List<PersonelTrainer> ViewAvailableTrainers(string timeslot)
        {
            List<PersonelTrainer> availableTrainers = new List<PersonelTrainer>();
            foreach (PersonelTrainer trainer in personalTrainers)
            {
                bool isAvailable = true;
                foreach (TrainingSession session in trainer.GetTrainingSessions())
                {
                    if (session.GetSessionTime() == timeslot)
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
            availableTrainers.Sort(new SessionFeeComparer());
            return availableTrainers;
        }
        public List<PersonelTrainer> ViewTrainersAlphabetically()
        {
            List<PersonelTrainer> sortedTrainers = new List<PersonelTrainer>(personalTrainers);
            sortedTrainers.Sort(new AlphabeticalComparer());
            return sortedTrainers;
        }
        public List<PersonelTrainer> ViewTrainersByExperience()
        {
            List<PersonelTrainer> sortedTrainers = new List<PersonelTrainer>(personalTrainers);
            sortedTrainers.Sort(new ExperienceComparer());
            return sortedTrainers;
        }
    }
}
