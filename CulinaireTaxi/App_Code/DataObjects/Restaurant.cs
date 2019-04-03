﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CulinaireTaxi.App_Data.DataObjects
{
    public class Restaurant
    {
        public int Id { get; private set; }
        public string OwnerId { get; private set; }
        public string RestaurantName { get; private set; }
        public string PostalCode { get; private set; }
        public int HouseNumber { get; private set; }
        public string HouseNumberPrefix { get; private set; }
        public string City { get; private set; }

        public Restaurant(int Id, string OwnerId, string RestaurantName, string PostalCode, int HouseNumber, string HouseNumberPrefix, string City)
        {
            this.Id = Id;
            this.OwnerId = OwnerId;
            this.RestaurantName = RestaurantName;
            this.PostalCode = PostalCode;
            this.HouseNumber = HouseNumber;
            this.HouseNumberPrefix = HouseNumberPrefix;
            this.City = City;
        }
    }
}