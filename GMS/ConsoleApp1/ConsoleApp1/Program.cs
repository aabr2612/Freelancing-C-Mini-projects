using ConsoleApp1;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        IGymManager gymManager = new GymManager();
        IGymUser gymUser = new GymUser(gymManager.GetTrainers());
        while (true)
        {
            Console.Clear();
            Console.WriteLine("          Welcome to GYM Management System!\n\n");
            Console.WriteLine("               1. Admin Menu");
            Console.WriteLine("               2. User Menu");
            Console.WriteLine("               3. Exit");
            Console.Write("               Select an option: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                AdminMenu(gymManager);
            }
            else if (choice == "2")
            {
                UserMenu(gymUser, gymManager.GetTrainers());
            }
            else if (choice == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("               Invalid option. Please enter again.");
                Console.Write("               Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
    static void AdminMenu(IGymManager gymManager)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("                       Admin Menu\n\n");
            Console.WriteLine("               1. Add Gym Site");
            Console.WriteLine("               2. Add Trainer");
            Console.WriteLine("               3. Delete Trainer");
            Console.WriteLine("               4. List Trainers Alphabetically");
            Console.WriteLine("               5. List Trainers by Experience");
            Console.WriteLine("               6. Generate Session Bookings");
            Console.WriteLine("               7. Back to Main Menu");
            Console.Write("               Select an option: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Clear();
                Console.WriteLine("                       Add New GYM Site\n\n");
                Console.Write("               Enter site ID: ");
                string siteId = Console.ReadLine();
                Console.Write("               Enter location: ");
                string location = Console.ReadLine();
                GymSite site = new GymSite(siteId, location);
                Console.WriteLine("               "+gymManager.AddGymSite(site));
                Console.Write("               Press any key to continue...");
                Console.ReadKey();
            }
            else if (choice == "2")
            {
                Console.Clear();
                Console.WriteLine("                       Add New Trainer\n\n");
                Console.Write("               Enter trainer registration number: ");
                string regNum = Console.ReadLine();
                Console.Write("               Enter name: ");
                string name = Console.ReadLine();
                Console.Write("               Enter experience (years): ");
                if (!int.TryParse(Console.ReadLine(), out int experience) || experience < 0)
                {
                    Console.WriteLine("               Invalid experience. Please enter a positive number.");
                    Console.Write("               Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }
                Console.Write("               Enter certifications (comma-separated): ");
                List<string> certifications = new List<string>(Console.ReadLine().Split(','));
                Console.Write("               Enter styles (comma-separated): ");
                List<string> styles = new List<string>(Console.ReadLine().Split(','));
                Console.Write("               Enter session price: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal price) || price < 0)
                {
                    Console.WriteLine("               Invalid price. Please enter a positive number.");
                    Console.Write("               Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }
                Console.WriteLine("               Select trainer type:");
                Console.WriteLine("               1. Fitness Trainer");
                Console.WriteLine("               2. Yoga Trainer");
                Console.WriteLine("               3. Martial Arts Trainer");
                Console.Write("               Enter your choice: ");
                if (!int.TryParse(Console.ReadLine(), out int trainerTypeChoice) || trainerTypeChoice < 1 || trainerTypeChoice > 3)
                {
                    Console.WriteLine("               Invalid trainer type selected.");
                    Console.Write("               Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }
                Trainer trainer;
                if (trainerTypeChoice == 1)
                    trainer = new FitnessTrainer(regNum, name, experience, certifications, styles, price);
                else if (trainerTypeChoice == 2)
                    trainer = new YogaTrainer(regNum, name, experience, certifications, styles, price);
                else if (trainerTypeChoice == 3)
                    trainer = new MartialArtsTrainer(regNum, name, experience, certifications, styles, price);
                else
                    trainer = null;
                if (trainer != null)
                {
                    string message = gymManager.AddTrainer(trainer);
                    Console.WriteLine("               "+message);
                }
                Console.Write("               Press any key to continue...");
                Console.ReadKey();
            }
            else if (choice == "3")
            {
                Console.Clear();
                Console.WriteLine("                       Delete Trainer\n\n");
                Console.Write("               Enter trainer registration number to delete: ");
                string regNum = Console.ReadLine();
                Console.WriteLine("               " + gymManager.DeleteTrainer(regNum));
                Console.Write("               Press any key to continue...");
                Console.ReadKey();
            }
            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("                       View Trainers Alphabetically\n\n");
                List<Trainer> trainerList = gymManager.ListTrainersAlphabetically();
                if (trainerList.Count>0)
                {
                    int maxCertificationsLength = 0;
                    int maxStylesLength = 0;

                    foreach (Trainer trainer in trainerList)
                    {
                        string certifications = string.Join(", ", trainer.GetCertifications());
                        string styles = string.Join(", ", trainer.GetStyles());

                        if (certifications.Length > maxCertificationsLength)
                        {
                            maxCertificationsLength = certifications.Length;
                        }

                        if (styles.Length > maxStylesLength)
                        {
                            maxStylesLength = styles.Length;
                        }
                    }

                    int certificationsWidth = Math.Max(30, maxCertificationsLength);
                    int stylesWidth = Math.Max(20, maxStylesLength);
                    Console.WriteLine("{0,-20} {1,-15} {2,-15} {3,-15} {4,-" + certificationsWidth + "} {5,-" + stylesWidth + "}",
                        "Reg. No.", "Name", "Experience", "Price", "Certifications", "Styles");
                    foreach (Trainer trainer in trainerList)
                    {
                        Console.WriteLine("{0,-20} {1,-15} {2,-15} {3,-15:C} {4,-" + certificationsWidth + "} {5,-" + stylesWidth + "}",
                            trainer.GetRegistrationNumber(), trainer.GetName(), trainer.GetExperience(),
                            trainer.GetSessionPrice(), string.Join(", ", trainer.GetCertifications()),
                            string.Join(", ", trainer.GetStyles()));
                    }
                }
                Console.Write("\n               Press any key to continue...");
                Console.ReadKey();
            }
            else if (choice == "5")
            {
                Console.Clear();
                List<Trainer> trainerList = gymManager.ListTrainersByExperience();
                Console.WriteLine("                       Trainers Sorted by Experience\n\n");
                Console.WriteLine("{0,-20} {1,-15} {2,-25} {3,-15:C} {4,-20}",
                    "Reg. No.", "Name", "Experience (years)", "Price", "Certifications");
                foreach (Trainer trainer in trainerList)
                {
                    Console.WriteLine("{0,-20} {1,-15} {2,-25} {3,-15:C} {4,-20}",
                        trainer.GetRegistrationNumber(), trainer.GetName(), trainer.GetExperience(),
                        trainer.GetSessionPrice(), string.Join(", ", trainer.GetCertifications()));
                }
                Console.Write("\n               Press any key to continue...");
                Console.ReadKey();
            }
            else if (choice == "6")
            {
                Console.Clear();
                Console.WriteLine("                       Generate Session Report\n\n");
                Console.Write("               Enter date (YYYY-MM-DD): ");
                string date = Console.ReadLine();
                if (!DateTime.TryParseExact(date, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out _))
                {
                    Console.WriteLine("               Invalid date format. Please enter date in YYYY-MM-DD format.");
                    Console.Write("               Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }
                string result = gymManager.GenerateSessionBookings(date);
                Console.WriteLine("               "+result);
                Console.Write("               Press any key to continue...");
                Console.ReadKey();
            }
            else if (choice == "7")
            {
                break;
            }
            else
            {
                Console.WriteLine("               Invalid option. Please try again.");
                Console.Write("               Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
    static void UserMenu(IGymUser gymUser, List<Trainer> trainers)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("                       User Menu\n\n");
            Console.WriteLine("               1. List Available Trainers");
            Console.WriteLine("               2. List Trainers by Type and Timeslot");
            Console.WriteLine("               3. Book Session");
            Console.WriteLine("               4. Cancel Session");
            Console.WriteLine("               5. Back to Main Menu");
            Console.Write("               Select an option: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Clear();
                Console.WriteLine("                       List Available Trainers\n\n");
                Console.Write("               Enter timeslot (YYYY-MM-DD HH:MM): ");
                string timeslot = Console.ReadLine();
                if (!DateTime.TryParseExact(timeslot, "yyyy-MM-dd hh:mm", null, System.Globalization.DateTimeStyles.None, out _))
                {
                    Console.WriteLine("               Invalid date format. Please enter date in YYYY-MM-DD format.");
                    Console.Write("               Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }
                List<Trainer> availableTrainers = gymUser.ListAvailableTrainers(timeslot);
                Console.WriteLine("{0,-20} {1,-15} {2,-25} {3,-15:C} {4,-20}",
                    "Reg. No.", "Name", "Experience (years)", "Price", "Certifications");
                foreach (Trainer trainer in availableTrainers)
                {
                    Console.WriteLine("{0,-20} {1,-15} {2,-25} {3,-15:C} {4,-20}",
                        trainer.GetRegistrationNumber(), trainer.GetName(), trainer.GetExperience(),
                        trainer.GetSessionPrice(), string.Join(", ", trainer.GetCertifications()));
                }
                Console.Write("\n               Press any key to continue...");
                Console.ReadKey();
            }
            else if (choice == "2")
            {
                Console.Clear();
                Console.WriteLine("                       List Trainers by Type and Timeslot\n\n");
                Console.Write("               Enter timeslot (YYYY-MM-DD HH:MM): ");
                string timeslot = Console.ReadLine();
                if (!DateTime.TryParseExact(timeslot, "yyyy-MM-dd hh:mm", null, System.Globalization.DateTimeStyles.None, out _))
                {
                    Console.WriteLine("               Invalid date format. Please enter date in YYYY-MM-DD format.");
                    Console.Write("               Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }
                Console.WriteLine("               Select trainer type:");
                Console.WriteLine("               1. Fitness Trainer");
                Console.WriteLine("               2. Yoga Trainer");
                Console.WriteLine("               3. Martial Arts Trainer");
                if (!int.TryParse(Console.ReadLine(), out int trainerTypeChoice) || trainerTypeChoice < 1 || trainerTypeChoice > 3)
                {
                    Console.WriteLine("               Invalid trainer type selected.");
                    Console.Write("               Press any key to continue...");
                    Console.ReadKey();
                }
                Type trainerType;
                if (trainerTypeChoice == 1)
                    trainerType = typeof(FitnessTrainer);
                else if (trainerTypeChoice == 2)
                    trainerType = typeof(YogaTrainer);
                else if (trainerTypeChoice == 3)
                    trainerType = typeof(MartialArtsTrainer);
                else
                    trainerType = null;
                if (trainerType != null)
                {
                    List<Trainer> trainersByType = gymUser.ListTrainersByTypeAndTimeslot(trainerType, timeslot);
                    Console.WriteLine("{0,-20} {1,-15} {2,-25} {3,-15:C} {4,-20}",
                   "Reg. No.", "Name", "Experience (years)", "Price", "Certifications");
                    foreach (Trainer trainer in trainersByType)
                    {
                        Console.WriteLine("{0,-20} {1,-15} {2,-25} {3,-15:C} {4,-20}",
                            trainer.GetRegistrationNumber(), trainer.GetName(), trainer.GetExperience(),
                            trainer.GetSessionPrice(), string.Join(", ", trainer.GetCertifications()));
                    }
                    Console.Write("\n               Press any key to continue...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("               Invalid trainer type selected.");
                }
                Console.Write("               Press any key to continue...");
                Console.ReadKey();
            }
            else if (choice == "3")
            {
                Console.Clear();
                Console.WriteLine("                       Book Session\n\n");
                Console.Write("               Enter session ID: ");
                string sessionId = Console.ReadLine();
                Console.Write("               Enter member name: ");
                string member = Console.ReadLine();
                Console.Write("               Enter trainer registration number: ");
                string regNum = Console.ReadLine();
                Console.Write("               Enter timeslot (YYYY-MM-DD HH:MM): ");
                string timeslot = Console.ReadLine();
                if (!DateTime.TryParseExact(timeslot, "yyyy-MM-dd hh:mm", null, System.Globalization.DateTimeStyles.None, out _))
                {
                    Console.WriteLine("               Invalid date format. Please enter date in YYYY-MM-DD format.");
                    Console.Write("               Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }
                Console.Write("               Enter gym site ID: ");
                string siteId = Console.ReadLine();
                GymSite site = new GymSite(siteId, "");
                Trainer trainer = null;
                foreach(Trainer t in trainers)
                {
                    if(t.GetRegistrationNumber()==regNum)
                    {
                        trainer=t;
                        break;
                    }
                }
                if (trainer != null)
                {
                    Session session = new Session(sessionId, member, trainer, timeslot, site);
                    Console.WriteLine("               "+gymUser.BookSession(session));
                }
                else
                {
                    Console.WriteLine("               Trainer not found.");
                }
                Console.Write("               Press any key to continue...");
                Console.ReadKey();
            }
            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("                       Cancel Session\n\n");
                Console.Write("               Enter session ID to cancel: ");
                string sessionId = Console.ReadLine();
                Console.WriteLine("               "+gymUser.CancelSession(sessionId));
                Console.Write("               Press any key to continue...");
                Console.ReadKey();
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("               Invalid option. Please try again.");
                Console.Write("               Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
