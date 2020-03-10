using System;
using System.Collections.Generic;

namespace Parcel.Models
{
    public class Package
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
        public int Volume { get; set; }
        public string To { get; set; }
        public string From { get; set; }

        private static List<Package> _Packages = new List<Package> {};

        public Package (int height, int width, int weight, string to, string from)
        {
            Height = height;
            Width = width;
            Height = height;
            Weight = weight;
            To = to;
            From = from;
            _Packages.Add(this);
        }

        public static List<Package> GetAll()
        {
            return _Packages;
        }

        public static void ClearAll()
        {
            _Packages.Clear();
        }

        public  int GetVolume(Package package)
        {
        Volume = (Height * Width);
        return Volume;
        }

        public  int CostToShip(Package package)
        {
        Price = (Volume * Weight);
        return Price;
        }
    }
}