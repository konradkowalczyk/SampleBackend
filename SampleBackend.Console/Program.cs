using SampleBackend.BusinessLayer;
using SampleBackend.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            ComponentManager.Initialize();

            var choice = PrompForChoice();
            while (!ValidateKeyPress(choice))
            {
                Console.WriteLine();
                choice = PrompForChoice();
            }

            var result = QueryForSelectedFlight(choice);
            DisplayFeedbackMessage(result);

            Console.ReadKey();
        }

        private static string PrompForChoice() {
            Console.WriteLine(
                string.Format(MessageResources.ChooseRouteMessageConsole,
                Environment.NewLine));
            return Console.ReadKey().KeyChar.ToString();
        }

        private static void DisplayFeedbackMessage(FlightDetailsResponse result)
        {
            if (result.Success)
                Console.WriteLine(string.Format(MessageResources.FeedbackMessageSuccessConsole,
            result.Distance, result.EstimatedLengthInHrs, Environment.NewLine, result.NearestFlightDate.ToShortDateString(), result.FreeSeatsCount));
            else
                Console.WriteLine(string.Format(MessageResources.FeedbackMessageFailConsole, Environment.NewLine));
        }

        private static FlightDetailsResponse QueryForSelectedFlight(string choice)
        {
            FlightDetailsResponse result = null;
            var flightsService = ComponentManager.GetInstance<IFlightService>();

            switch (choice)
            {
                case "1":
                    result = flightsService.GetFlightDetails("London", "Dublin");
                    break;
                case "2":
                    result = flightsService.GetFlightDetails("Los Angeles", "San Francisco");
                    break;
                case "3":
                    result = flightsService.GetFlightDetails("Melbourne", "Sydney");
                    break;
            }
            return result;
        }

        private static bool ValidateKeyPress(string key)
        {
            return (key.Equals("1") || key.Equals("2") || key.Equals("3"));
        }
    }
}
