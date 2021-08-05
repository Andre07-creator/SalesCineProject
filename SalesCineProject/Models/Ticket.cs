using System;
using System.Collections.Generic;
using SalesCineProject.Models.Enums;

namespace SalesCineProject.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public PaymentForm Payment { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public Ticket()
        {
        }

        public Ticket(int id, string client, double price,PaymentForm payment, Movie movie)
        {
            Id = id;
            Client = client;
            Price = price;
            Payment = payment;
            Movie = movie;
        }
    }
}
