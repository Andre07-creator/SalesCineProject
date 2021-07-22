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
        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
        //public Movie Movie { get; set; }

        public Ticket()
        {
        }

        public Ticket(int id, string client, double price,PaymentForm payment)
        {
            Id = id;
            Client = client;
            Price = price;
           // Date = DateTime.Now;
            Payment = payment;
        }

        public void AddMovie(Movie mv)
        {
            Movies.Add(mv);
        }

        public void RemoveMovie(Movie mv)
        {
            Movies.Remove(mv);
        }

    }
}
