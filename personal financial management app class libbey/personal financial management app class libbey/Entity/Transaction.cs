using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personal_financial_management_app_class_libbey
{
    public class Transaction
    {
        private Double? amount; 
        private string? description;
        private Catagory? catagory;
        private DateTime? date;


        public Double? Amount { get; set; }
        public string? Description { get; set; }
        public Catagory? Catagory { get; set; }
        public DateTime? Date { get; set; }

        public Transaction()
        {
        }

        public Transaction(Double? amount, string? description, Catagory? catagory, DateTime? dateOnly)
        {
            this.amount = amount;
            this.description = description;
            this.catagory = catagory;
            this.Date = dateOnly;
        }


    }
}
