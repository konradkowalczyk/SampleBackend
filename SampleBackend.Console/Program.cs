using SampleBackend.BusinessLayer;
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
            Console.WriteLine(
                string.Format("Please press key to select route: {0}1 for London-Dublin{0}2 for Los Angeles-San Francisco{0}3 for Melbourne-Sydney{0}",
                Environment.NewLine));
            var result = QueryForSelected(Console.ReadKey().KeyChar.ToString());
            Console.WriteLine();
            DisplayMessage(result);
            Console.ReadKey();
        }

        private static void DisplayMessage(FlightCalculationResult result)
        {
            if (result.Success)
                Console.WriteLine(string.Format(
            "Distance for this flight is: {0} km {2}Estimated time for the trip: {1} hour(s)",
            result.Distance, result.EstimatedLengthInHrs, Environment.NewLine));
            else
            {
                Console.WriteLine("Calculation failed - no such route available");
            }

        }

        private static FlightCalculationResult QueryForSelected(string choice)
        {
            var calculationService = new FlightCalculationService();
            FlightCalculationResult result = null;

            switch (choice)
                {
                case "1":
                    result = calculationService.CalculateFlight("London", "Dublin");
                    break;
                case "2":
                    result = calculationService.CalculateFlight("Los Angeles", "San Francisco");
                    break;
                case "3":
                    result = calculationService.CalculateFlight("Melbourne", "Sydney");
                    break;
            }
            return result;
        }
    }
}
