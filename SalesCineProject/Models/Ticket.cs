using System;
using System.Collections.Generic;
using SalesCineProject.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace SalesCineProject.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Client { get; set; }
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double Price { get; set; }
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyy}")]
        public DateTime Date { get; set; } = DateTime.Now;
        public PaymentForm Payment { get; set; }
        [Display(Name ="Select movie")]
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
