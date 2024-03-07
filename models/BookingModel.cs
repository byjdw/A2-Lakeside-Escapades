using System;

namespace Banbridge_Academy_SSD_Coursework.models
{
    public class BookingModel
    {
        int bookingId;
        int clientId;
        DateTime startDate;
        int length;
        decimal cost;
        decimal balance;
        bool provisional;
        DateTime bookingDate;

        public BookingModel()
        {

        }

        public BookingModel(int bookingId, int clientId, DateTime startDate, int length, decimal cost, decimal balance, bool provisional)
        {
            this.BookingId = bookingId;
            this.ClientId = clientId;
            this.StartDate = startDate;
            this.Length = length;
            this.Cost = cost;
            this.Balance = balance;
            this.provisional = provisional;
            this.bookingDate = DateTime.Now;
        }

        public int BookingId { get => bookingId; set => bookingId = value; }
        public int ClientId { get => clientId; set => clientId = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public int Length { get => length; set => length = value; }
        public decimal Cost { get => cost; set => cost = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public bool Provisional { get => provisional; set => provisional = value; }
        public DateTime BookingDate { get => bookingDate; set => bookingDate = value; }
    }
}
