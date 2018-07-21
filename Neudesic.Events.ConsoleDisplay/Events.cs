using Neudesic.Events.Model;
using System;
using System.Collections.Generic;

namespace Neudesic.Events.ConsoleDisplay
{
    public class Events
    {     
        static void Main(string[] args)
        {
            Events eventsObject = new Events();
            List<EventDetails> details = new List<EventDetails>();
            string optionNumber = "";
            bool continueInMenuOption = true;
            bool exitMenuOption = true;
            while (exitMenuOption)
            {
                continueInMenuOption = true;

                while (continueInMenuOption)
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1) Create Event");
                    Console.WriteLine("2) Show Events");
                    Console.WriteLine();
                    Console.Write("Enter the Option: ");
                    optionNumber = Console.ReadLine();
                    switch (optionNumber)
                    {
                        case "1":
                            details.Add(eventsObject.EnterDetails());                    
                            Console.Write("\nDo you want to create Another event (y/n)? ");
                            string continueInMenuOptionInput = Console.ReadLine();
                            if(continueInMenuOptionInput == "n" || continueInMenuOptionInput == "N" )
                            {
                                continueInMenuOption = false;
                                break;
                            }
                            Console.Write("\nDo you want to go to Menu (y/n)? ");
                            string  exitMenuOptionInput = Console.ReadLine();
                            if (exitMenuOptionInput == "n" || exitMenuOptionInput == "N")
                            {
                                exitMenuOption = false;
                            }
                            break;
                        case "2":
                            eventsObject.ShowEvents(details);
                            Console.Write("\nDo you want to go to Menu? (y/n)");
                            exitMenuOptionInput = Console.ReadLine();
                            if (exitMenuOptionInput == "n" || exitMenuOptionInput == "N")
                            {
                                continueInMenuOption = false;
                                exitMenuOption = false;
                            }
                            break;
                    }
                }
            }
        }

        public EventDetails EnterDetails()
        {

            EventDetails eventDetailsObject = new EventDetails();
            Console.Write("Enter the Name of the Event: ");
            eventDetailsObject.EventName = Console.ReadLine();
            Console.Write("Enter the registration Start Date: ");
            eventDetailsObject.StartDate = Console.ReadLine();
            Console.Write("Enter the registration End Date: ");
            eventDetailsObject.EndDate = Console.ReadLine();
            Console.Write("Enter the Duration of the event: ");
            eventDetailsObject.Duration = Console.ReadLine();

            return eventDetailsObject;
        }

        public void ShowEvents(List<EventDetails> details)
        {            
            Console.WriteLine("Event Name\tStart Date\tEnd Date\tDuration\t");
            for (int index = 0; index < details.Count; index++)
            {
                Console.Write("\t");
                Console.Write(details[index].EventName + "\t");
                Console.Write(details[index].StartDate + "\t");
                Console.Write(details[index].EndDate + "\t");
                Console.Write(details[index].Duration + "\t");
                Console.Write("\n");
            }
        }
    }
}
