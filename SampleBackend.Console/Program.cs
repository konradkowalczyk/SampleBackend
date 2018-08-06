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
            ComponentManager.Initialize();

            Console.WriteLine(
                string.Format(MessageResources.ChooseRouteMessageConsole,
                Environment.NewLine));

            var result = QueryForSelectedFlight(Console.ReadKey().KeyChar.ToString());
            DisplayFeedbackMessage(result);

            Console.ReadKey();
        }

        private static void DisplayFeedbackMessage(FlightDetailsResponse result)
        {
            if (result.Success)
                Console.WriteLine(string.Format(MessageResources.FeedbackMessageSuccessConsole,
            result.Distance, result.EstimatedLengthInHrs, Environment.NewLine, result.NearestFlightDate.ToShortDateString(), result.FreeSeatsCount));
            else
                Console.WriteLine(MessageResources.FeedbackMessageFailConsole);
        }

        private static FlightDetailsResponse QueryForSelectedFlight(string choice)
        {
            var flightsService = ComponentManager.GetInstance<IFlightService>();
            FlightDetailsResponse result = null;

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
    }
}
