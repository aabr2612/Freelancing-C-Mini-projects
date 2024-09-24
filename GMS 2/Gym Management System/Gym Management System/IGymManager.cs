using System.Collections.Generic;
namespace Gym_Management_System
{
    internal interface IGymManager
    {
        string AddGymLocation(GymLocation site);
        List<PersonelTrainer> ViewTrainersByExperience();
        string AddPersonelTrainer(PersonelTrainer trainer);
        string RemovePersonelTrainer(string regNo);
        string GenerateSessionBookingsReport(string bookingDate);
        List<PersonelTrainer> ViewTrainersAlphabetically();
    }
}
