﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesCineProject.Models.Enums;

namespace SalesCineProject.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public PaymentForm Payment { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, double price, DateTime date, PaymentForm payment)
        {
            id = Id;
            Price = price;
            Date = date;
            Payment = payment;
        }
    }
}
