using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public class PropertyFilterCriteria
    {
        public string PropertyType { get; set; }
        public double MinAreaSquareMeters { get; set; }
        public double MaxAreaSquareMeters { get; set; }
        public int MinNumberOfRooms { get; set; }
        public int MaxNumberOfRooms { get; set; }
        public int MinFloor { get; set; }
        public int MaxFloor { get; set; }
        public int BuildingFloors { get; set; }
        public string HeatingType { get; set; }
        public decimal MinSalePrice { get; set; }
        public decimal MaxSalePrice { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Neighborhood { get; set; }
        public string StreetAddress { get; set; }
        public bool IsForSale { get; set; }
        public bool IsForRent { get; set; }
    }
}
