using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models{
    public class Seller {
        
        public int id { get; private set; }
        public string name { get; private set; }
        public string email { get; private set; }
        public DateTime birthDate { get;private  set; }
        public double baseSalary { get; private set; }
        public Department department { get; private set; }
        public ICollection<SalesRecord> sales { get; set; } = new List<SalesRecord>();

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.birthDate = birthDate;
            this.baseSalary = baseSalary;
            this.department = department;
        }

        public Seller()
        {
        }
        public void addSales(SalesRecord sr)
        {
            sales.Add(sr);
        }
        public void removeSales(SalesRecord sr)
        {
            sales.Remove(sr);
        }
        public double totalSales(DateTime initial, DateTime final)
        {
            return sales.Where(sr => sr.date >= initial && sr.date <= final).Sum(sr => sr.amount);
        }
        internal void removedepartment() {
            department = null;
        }
    }
}
