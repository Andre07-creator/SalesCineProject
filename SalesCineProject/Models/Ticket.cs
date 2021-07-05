using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesCineProject.Models.Enums;

namespace SalesCineProject.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public PaymentForm Payment { get; set; }
        public ICollection<Movie> Movies { get; set; } = new List<Movie>();

        public Ticket()
        {
        }

        public Ticket(int id, string client, double price, DateTime date, PaymentForm payment)
        {
            Id = id;
            Client = client;
            Price = price;
            Date = date;
            Payment = payment;
        }
    }
}
