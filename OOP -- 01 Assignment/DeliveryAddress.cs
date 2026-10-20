using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace OOP____01_Assignment
{
    internal struct DeliveryAddress
    {
        public string City;
        public string Street;
        public int BuildingNumber;

        public DeliveryAddress(string City, string Street, int BuildingNumber)
        {
            this.City = City;
            this.Street = Street;
            this.BuildingNumber = BuildingNumber;
        }

        public string GetFullAddress()
        {
            return $"{BuildingNumber} - {Street} Street - {City}";
        }

    }
}
