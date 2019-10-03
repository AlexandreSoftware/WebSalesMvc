using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models.Enums;
namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int id { get;    private set; }
        public DateTime date { get; private set; }
        public double amount { get; private set; }
        public SaleStatus status { get; private set; }
        public Seller seller{ get; private set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            this.id = id;
            this.date = date;
            this.amount = amount;
            this.status = status;
            this.seller = seller;
        }

        public void cancelSale()
        {
            status = SaleStatus.Canceled;
        }
        public void confirmSale()
        {
            status = SaleStatus.Billed;
        }
    }
}
