using SampleBackend.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.log4net;

namespace SampleBackend.BusinessLayer
{
    public static class ComponentManager
    {
        private static UnityContainer _container = new UnityContainer();

        public static void Initialize()
        {
            _container.AddNewExtension<Log4NetExtension>();
            _container.RegisterType<IFlightService, FlightsService>();
            _container.RegisterType<IFlightRepository, FlightRepository>();
        }

        public static T GetInstance<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
