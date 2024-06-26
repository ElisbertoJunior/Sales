﻿using System;

namespace SalesWeb.Models
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller sl)
        {
            Sellers.Add(sl);
        }

        public Double TotalSales(DateTime inital, DateTime final)
        {
            return Sellers.Sum(sl => sl.TotalSales(inital, final));
        }
    }
}
