using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment_Flightss.Controllers;

namespace Assignment_Flightss
{
    public class CitiesService
    {
        FlightdbEntities airportdbEntities = new FlightdbEntities();

        public IList<Citiesdb> GetCitiesdbs()
        {
            return airportdbEntities.Citiesdbs.ToList();

        }
    }
}