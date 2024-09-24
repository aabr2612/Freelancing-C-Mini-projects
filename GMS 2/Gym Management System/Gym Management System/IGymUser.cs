using System;
using System.Collections.Generic;
namespace Gym_Management_System
{
    internal interface IGymUser
    {
        string BookNewTrainingSession(TrainingSession session);
        PersonelTrainer GetPersonelTrainerByRegNo(string regNo);
        string CancelTrainingSession(string sessionCode);
        List<PersonelTrainer> ViewAvailableTrainers(string sessionTime);
        List<PersonelTrainer> ViewTrainersByTypeAndTimeslot(Type trainerType, string sessionTime);
    }
}
