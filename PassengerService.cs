using Assignment_Flightss.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment_Flightss.Controllers;
using Assignment_Flightss;



namespace Assignment_Flightss
{
    public class  PassengerService
    {
        FlightdbEntities airportdb = new FlightdbEntities();  

        public IList<Passangerdb> GetPassangerList()
        {
            return airportdb.Passangerdbs.ToList();
        }

        public  AirportModel PreparePassengerEdit(int passengerId)
        {
            AirportModel model = new AirportModel();

            if (passengerId > 0)
            {
                var SavedPassenger = airportdb.Passangerdbs.FirstOrDefault(x => x.passengerID == passengerId);

                if (SavedPassenger != null)
                {
                    model.passengerID = SavedPassenger.passengerID;
                    model.Nameofpassenger = SavedPassenger.Nameofpassenger;
                    model.Age = SavedPassenger.Age;
                    model.MobileNo = SavedPassenger.MobileNo;
                    model.Address = SavedPassenger.Address;
                    model.CitiesID = SavedPassenger.CitiesID;
                    model.FlightID = SavedPassenger.FlightID;
                }
            }
             return model;
        } 
        public void SavePassenger(AirportModel model)
        {
            Passangerdb passangerdb = new Passangerdb();
            if (model.passengerID > 0)
            {
                Passangerdb Savepassenger = airportdb.Passangerdbs.FirstOrDefault(x => x.passengerID == model.passengerID);
                passangerdb = Savepassenger;
            }
            passangerdb.passengerID = model.passengerID;
            passangerdb.Nameofpassenger = model.Nameofpassenger;
            passangerdb.Age = model.Age;
            passangerdb.MobileNo = model.MobileNo;
            passangerdb.Address = model.Address;
            passangerdb.CitiesID = model.CitiesID;
            passangerdb.FlightID = model.FlightID;

            if (model.passengerID == 0)
            {
                airportdb.Passangerdbs.Add(passangerdb);
            }
            airportdb.SaveChanges();
           
        }
        public bool DeletePassenger(int passengerId)
        {
            try
            {
                Passangerdb Savepassenger = airportdb.Passangerdbs.FirstOrDefault(x => x.passengerID == passengerId);

                airportdb.Passangerdbs.Remove(Savepassenger);

                airportdb.SaveChanges();

                return true;
            }
            catch(Exception ex) 
            {
                return false;
            }
        }
    }
}