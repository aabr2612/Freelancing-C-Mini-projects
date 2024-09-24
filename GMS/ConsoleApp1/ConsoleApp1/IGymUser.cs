using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public interface IGymUser
    {
        List<Trainer> ListAvailableTrainers(string timeslot);
        List<Trainer> ListTrainersByTypeAndTimeslot(Type trainerType, string timeslot);
        string BookSession(Session session);
        string CancelSession(string sessionId);
    }

}
