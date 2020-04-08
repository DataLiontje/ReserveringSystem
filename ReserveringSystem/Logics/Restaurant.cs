using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserveringSystem.Logics
{
    class Restaurant
    {

        private static List<Restaurant> restaurants = new List<Restaurant>();

        private string Name { get; set; }
        private int AvailableInside { get; set; }
        private int AvailableOutside { get; set; }

        public List<Reservering> reserveringen = new List<Reservering>();


        public Restaurant(String name, int limitInside = 20, int limitOutside = 20)
        {
            Name = name;
            AvailableInside = limitInside;
            AvailableOutside = limitOutside;
            restaurants.Add(this);
        }




        public static Restaurant GetRestaurantByName(string searchName)
        {
            Restaurant returnRestaurant = null;
            restaurants.ForEach((Restaurant restaurant) =>
            {
                if (restaurant.GetName().ToLower().Equals(searchName.ToLower())) returnRestaurant = restaurant;
            });
            return returnRestaurant;
        }

        public Reservering GetReserveringByName(string searchName)
        {
            Reservering returnReservering = null;

            reserveringen.ForEach((Reservering reservering) =>
            {
                if (reservering.GetName().ToLower().Equals(searchName.ToLower())) returnReservering = reservering;
            });

            return returnReservering;
        }

        public bool CanGetGetTables(bool inside, int amount)
        {
            if (inside)
            {
                if (CalculateInside() >= amount) {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if(CalculateOutside() >= amount)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public int GetNextAvailableTableNum()
        {
            int totalTables = AvailableOutside + AvailableInside;
            totalTables -= AvailableInside - CalculateInside();
            totalTables -= AvailableOutside - CalculateOutside();

            return totalTables;
        }




        public String GetName()
        {
            return Name;
        }



        public int CalculateOutside()
        {
            int available = AvailableOutside;
            reserveringen.ForEach((Reservering reservering) => {
                if(!reservering.IsBinnen()) available -= (int) Math.Ceiling((Double)reservering.GetPersonAmount() / 6);
            });
            return available;

        }

        public int CalculateInside()
        {

            int available = AvailableInside;
            reserveringen.ForEach((Reservering reservering) => {
                if(reservering.IsBinnen()) available -= (int) Math.Ceiling((Double)reservering.GetPersonAmount() / 6);
            });
            return available;

        }



    }
}
