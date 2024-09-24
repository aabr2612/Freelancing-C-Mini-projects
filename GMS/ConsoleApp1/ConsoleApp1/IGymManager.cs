using System.Collections.Generic;

namespace ConsoleApp1
{
    public interface IGymManager
    {
        string AddGymSite(GymSite site);
        string AddTrainer(Trainer trainer);
        List<Trainer> GetTrainers();
        GymSite CheckGymSites(string id);
        string DeleteTrainer(string registrationNumber);
        List<Trainer> ListTrainersAlphabetically();
        List<Trainer> ListTrainersByExperience();
        string GenerateSessionBookings(string date);
    }
}
