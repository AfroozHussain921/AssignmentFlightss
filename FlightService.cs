using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment_Flightss.Controllers;

namespace Assignment_Flightss
{
    public class FlightService
    {
        FlightdbEntities airportdbEntities = new FlightdbEntities();
        public IList<Flightdb> GetFlightdbs()
        {
           
            return airportdbEntities.Flightdbs.ToList();    

        }
    }
}