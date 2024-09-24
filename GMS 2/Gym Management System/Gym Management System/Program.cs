using System;
using System.Collections.Generic;
namespace Gym_Management_System
{
    class Program
    {
        static IGymManager gymManager = new GymManager();
        static IGymUser gymUser = new GymManager();
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("      Gym Management System      ");
                Console.WriteLine("=================================\n");
                Console.WriteLine("Enter 1 for Admin Menu\nEnter 2 for User Menu\nEnter 3 to Exit\n");
                Console.Write("Enter your choice... ");
                string choice = Console.ReadLine();
                if (choice== "1")
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("========================================");
                        Console.WriteLine("              Admin Menu                ");
                        Console.WriteLine("========================================\n");
                        Console.WriteLine("Enter 1 to Add Gym Location\nEnter 2 to Add Personel Trainer\nEnter 3 to Delete Personel Trainer\nEnter 4 to View Personel Trainers Alphabetically\nEnter 5 to View Personel Trainers by Experience\nEnter 6 to Generate Training Session Bookings\nEnter 7 to return to main menu");
                        Console.Write("Enter your choice... ");
                        choice = Console.ReadLine();
                        if (choice=="1")
                        {
                            Console.WriteLine("============================================");
                            Console.WriteLine("           Add New Gym Location             ");
                            Console.WriteLine("============================================\n");
                            Console.Write("Enter site number: ");
                            string siteId = Console.ReadLine();
                            Console.Write("Enter site location: ");
                            string location = Console.ReadLine();
                            GymLocation site = new GymLocation(siteId, location);
                            string message = gymManager.AddGymLocation(site);
                            Console.WriteLine("\n" + message);
                            PressAnyKeyToContinue();
                        }
                        else if (choice== "2")
                        {
                            Console.WriteLine("===========================================");
                            Console.WriteLine("            Add Personel Trainer           ");
                            Console.WriteLine("===========================================\n");
                            Console.Write("Enter trainer reg no.: ");
                            string regNum = Console.ReadLine();
                            Console.Write("Enter full name: ");
                            string name = Console.ReadLine();
                            int experience;
                            while (true)
                            {
                                Console.Write("Enter experience in years: ");
                                string exp = Console.ReadLine();
                                if (!int.TryParse(exp, out experience) || experience < 0)
                                {
                                    Console.WriteLine("Enter a valid positive number!");
                                }
                                else
                                {
                                    break;
                                }
                            }
                            Console.Write("Enter trainer certificates: ");
                            string certifications = Console.ReadLine();
                            Console.Write("Enter training styles: ");
                            string styles = Console.ReadLine();
                            double fee;
                            while (true)
                            {
                                Console.Write("Enter session fee: ");
                                string sessionFee = Console.ReadLine();
                                if (!double.TryParse(sessionFee, out fee) || fee < 0)
                                {
                                    Console.WriteLine("Enter a valid fee!");
                                }
                                else
                                {
                                    break;
                                }
                            }
                            Console.WriteLine("\n          Trainer type");
                            Console.WriteLine("1. Fitness Instructor  2. Relaxation Specialist  3. Karate Instructor");
                            int trainerTypeChoice;
                            while (true)
                            {
                                Console.Write("Enter your choice: ");
                                string trainerType = Console.ReadLine();
                                if (!int.TryParse(trainerType, out trainerTypeChoice) || trainerTypeChoice < 0 || trainerTypeChoice>3)
                                {
                                    Console.WriteLine("Wrong trainer type!");
                                }
                                else
                                {
                                    break;
                                }
                            }
                            PersonelTrainer trainer;
                            if (trainerTypeChoice == 1)
                            {
                                trainer = new FitnessInstructor(regNum, name, experience, certifications, styles, fee);
                            }
                            else if (trainerTypeChoice == 2)
                            {
                                trainer = new RelaxationSpecialist(regNum, name, experience, certifications, styles, fee);
                            }
                            else if (trainerTypeChoice == 3)
                            {
                                trainer = new KarateInstructor(regNum, name, experience, certifications, styles, fee);
                            }
                            else
                            {
                                trainer = null;
                            }
                            if (trainer != null)
                            {
                                string message = gymManager.AddPersonelTrainer(trainer);
                                Console.WriteLine("\n" + message);
                            }
                            PressAnyKeyToContinue();
                        }
                        else if (choice== "3")
                        {
                            Console.WriteLine("==================================================");
                            Console.WriteLine("             Delete Personel Trainer              ");
                            Console.WriteLine("==================================================\n");
                            Console.Write("Enter trainer reg no. to delete: ");
                            string regNo = Console.ReadLine();
                            Console.WriteLine("\n" + gymManager.RemovePersonelTrainer(regNo));
                            PressAnyKeyToContinue();
                        }
                        else if (choice== "4")
                        {
                            Console.WriteLine("============================================");
                            Console.WriteLine("     View Trainers Sorted Alphabetically    ");
                            Console.WriteLine("============================================\n");
                            List<PersonelTrainer> trainerList = gymManager.ViewTrainersAlphabetically();
                            Console.WriteLine("{0,-20} {1,-15} {2,-15} {3,-15} {4,-30} {5,-30}",
                                "Reg. No.", "Name", "Experience", "Price", "Certifications", "Styles");
                            foreach (PersonelTrainer t in trainerList)
                            {
                                Console.WriteLine("{0,-20} {1,-15} {2,-15} {3,-15:C} {4,-30} {5,-30}",
                                    t.GetRegNo(), t.GetTrainerName(), t.GetExperience(),
                                    t.GetSessionFee(), t.GetCertificates(),
                                    t.GetTrainingStyles());
                            }
                            PressAnyKeyToContinue();
                        }
                        else if (choice == "5")
                        {
                            Console.WriteLine("===========================================");
                            Console.WriteLine("    View Trainers Sorted by Experience     ");
                            Console.WriteLine("===========================================\n");
                            List<PersonelTrainer> trainersList = gymManager.ViewTrainersByExperience();
                            Console.WriteLine("{0,-20} {1,-15} {2,-15} {3,-15} {4,-30} {5,-30}",
                                "Reg. No.", "Name", "Experience", "Price", "Certifications", "Styles");
                            foreach (PersonelTrainer t in trainersList)
                            {
                                Console.WriteLine("{0,-20} {1,-15} {2,-15} {3,-15:C} {4,-30} {5,-30}",
                                    t.GetRegNo(), t.GetTrainerName(), t.GetExperience(),
                                    t.GetSessionFee(), t.GetCertificates(),
                                    t.GetTrainingStyles());
                            }
                            PressAnyKeyToContinue();
                        }
                        else if (choice == "6")
                        {
                            Console.WriteLine("========================================");
                            Console.WriteLine("      Generate Session Report           ");
                            Console.WriteLine("========================================\n");
                            Console.Write("Enter session date in (YYYY-MM-DD) format: ");
                            string date = Console.ReadLine();
                            if (!DateTime.TryParseExact(date, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out _))
                            {
                                Console.WriteLine("Invalid date format! File not generated!");
                                PressAnyKeyToContinue();
                                continue;
                            }
                            string result = gymManager.GenerateSessionBookingsReport(date);
                            Console.WriteLine("\n" + result);
                            PressAnyKeyToContinue();
                        }
                        else if (choice == "7")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nWrong user choice!");
                            PressAnyKeyToContinue();
                        }
                    }
                }
                else if (choice== "2")
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("========================================");
                        Console.WriteLine("              User Menu                  ");
                        Console.WriteLine("========================================\n");
                        Console.WriteLine("Enter 1 to View Available Trainers\nEnter 2 to View Trainers by Type and Timeslot\nEnter 3 to Book Session\nEnter 4 to Cancel Session\nEnter 5 to return to Main Menu\n");
                        Console.Write("Enter your choice... ");
                        choice = Console.ReadLine();
                        if (choice=="1")
                        {
                            Console.WriteLine("======================================");
                            Console.WriteLine("       View Available Trainers        ");
                            Console.WriteLine("======================================\n");
                            Console.Write("Enter sessiontime in (YYYY-MM-DD HH:MM) format: ");
                            string sessionTime = Console.ReadLine();
                            if (!DateTime.TryParseExact(sessionTime, "yyyy-MM-dd HH:mm", null, System.Globalization.DateTimeStyles.None, out _))
                            {
                                Console.WriteLine("Enter sessiontime in YYYY-MM-DD HH:mm format!");
                                PressAnyKeyToContinue();
                                continue;
                            }
                            List<PersonelTrainer> availableTrainers = gymUser.ViewAvailableTrainers(sessionTime);
                            DisplayTrainersList(availableTrainers);
                        }
                        else if (choice== "2")
                        {
                            Console.WriteLine("============================================");
                            Console.WriteLine("    View Trainers by Type and SessionTime   ");
                            Console.WriteLine("============================================\n");
                            Console.Write("Enter sessiontime in (YYYY-MM-DD HH:MM) format: ");
                            string sessionTime = Console.ReadLine();
                            if (!DateTime.TryParseExact(sessionTime, "yyyy-MM-dd HH:mm", null, System.Globalization.DateTimeStyles.None, out _))
                            {
                                Console.Write("Enter sessiontime in (YYYY-MM-DD HH:MM) format: ");
                                PressAnyKeyToContinue();
                                continue;
                            }
                            Console.WriteLine("\n          Trainer type");
                            Console.WriteLine("1. Fitness Instructor  2. Relaxation Specialist  3. Karate Instructor");
                            int trainerTypeChoice;
                            while (true)
                            {
                                Console.Write("Enter your choice: ");
                                string type = Console.ReadLine();
                                if (!int.TryParse(type, out trainerTypeChoice) || trainerTypeChoice < 0 || trainerTypeChoice>3)
                                {
                                    Console.WriteLine("Enter a valid choice!");
                                }
                                else
                                {
                                    break;
                                }
                            }
                            Type trainerType;
                            if (trainerTypeChoice == 1)
                            {
                                trainerType = typeof(FitnessInstructor);
                            }
                            else if (trainerTypeChoice == 2)
                            {
                                trainerType = typeof(RelaxationSpecialist);
                            }
                            else if (trainerTypeChoice == 3)
                            {
                                trainerType = typeof(KarateInstructor);
                            }
                            else
                            {
                                trainerType = null;
                            }

                            if (trainerType != null)
                            {
                                List<PersonelTrainer> trainersByType = gymUser.ViewTrainersByTypeAndTimeslot(trainerType, sessionTime);
                                DisplayTrainersList(trainersByType);
                            }
                            else
                            {
                                Console.WriteLine("Wrong Trainer type choice!");
                                PressAnyKeyToContinue();
                            }
                        }
                        else if (choice== "3")
                        {
                            Console.WriteLine("========================================");
                            Console.WriteLine("             Book Session                ");
                            Console.WriteLine("========================================\n");
                            Console.Write("Enter session code: ");
                            string sessionCode = Console.ReadLine();
                            Console.Write("Enter member name: ");
                            string member = Console.ReadLine();
                            Console.Write("Enter trainer reg no.: ");
                            string regNo = Console.ReadLine();
                            Console.Write("Enter sessiontime in (YYYY-MM-DD HH:MM) format: ");
                            string sessionTime = Console.ReadLine();
                            if (!DateTime.TryParseExact(sessionTime, "yyyy-MM-dd HH:mm", null, System.Globalization.DateTimeStyles.None, out _))
                            {
                                Console.Write("Invalid sessionTime format!");
                                PressAnyKeyToContinue();
                                continue;
                            }
                            Console.Write("Enter gym site number: ");
                            string siteId = Console.ReadLine();
                            GymLocation site = new GymLocation(siteId, "");
                            PersonelTrainer trainer = gymUser.GetPersonelTrainerByRegNo(regNo);
                            TrainingSession session = new TrainingSession(sessionCode, member, trainer, sessionTime, site);
                            Console.WriteLine("\n" + gymUser.BookNewTrainingSession(session));
                            PressAnyKeyToContinue();
                        }
                        else if (choice== "4")
                        {
                            Console.WriteLine("========================================");
                            Console.WriteLine("           Cancel Session                ");
                            Console.WriteLine("========================================\n");
                            Console.Write("Enter session code to cancel: ");
                            string sessionCode = Console.ReadLine();
                            Console.WriteLine("\n" + gymUser.CancelTrainingSession(sessionCode));
                            PressAnyKeyToContinue();
                        }
                        else if (choice== "5")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nWrong user choice!");
                            PressAnyKeyToContinue();
                        }
                    }
                }
                else if (choice== "3")
                {
                    Environment.Exit(0);
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong user choice!");
                    PressAnyKeyToContinue();
                }
            }
        }
        static void DisplayTrainersList(List<PersonelTrainer> trainers)
        {
            Console.WriteLine("{0,-20} {1,-15} {2,-25} {3,-15:C} {4,-20}",
                "Reg. No.", "Name", "Experience (years)", "Price", "Certifications");
            foreach (PersonelTrainer trainer in trainers)
            {
                Console.WriteLine("{0,-20} {1,-15} {2,-25} {3,-15:C} {4,-20}",
                    trainer.GetRegNo(), trainer.GetTrainerName(), trainer.GetExperience(),
                    trainer.GetSessionFee(), string.Join(", ", trainer.GetCertificates()));
            }
            PressAnyKeyToContinue();
        }
        static void PressAnyKeyToContinue()
        {
            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}