using Banbridge_Academy_SSD_Coursework.models;
using System.Collections.Generic;

namespace Banbridge_Academy_SSD_Coursework.io.database.access
{
    internal class GeneralDBAccess
    {
        private Database db;

        public GeneralDBAccess(Database _db)
        {
            db = _db;
        }

        public void ExecuteCommand(string sqlCmd)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
        }

        public List<BookingModel> GetBookings()
        {
            List<BookingModel> bookings = new List<BookingModel>();
            ExecuteCommand("SELECT * FROM Booking");
            while (db.Rdr.Read())
            {
                BookingModel booking = new BookingModel();
                booking.BookingId = db.Rdr.GetInt32(0);
                booking.ClientId = db.Rdr.GetInt32(1);
                booking.StartDate = db.Rdr.GetDateTime(2);
                booking.Length = db.Rdr.GetInt32(3);
                booking.Cost = db.Rdr.GetDecimal(4);
                booking.Balance = db.Rdr.GetDecimal(5);
                booking.Provisional = db.Rdr.GetBoolean(6);
                bookings.Add(booking);
            }
            db.Rdr.Close();
            return bookings;
        }

        public List<BookingModel> GetBookingsFromClientId(int cid)
        {
            List<BookingModel> bookings = new List<BookingModel>();
            ExecuteCommand($"SELECT * FROM Booking WHERE ClientId = {cid}");
            while (db.Rdr.Read())
            {
                BookingModel booking = new BookingModel();
                booking.BookingId = db.Rdr.GetInt32(0);
                booking.ClientId = db.Rdr.GetInt32(1);
                booking.StartDate = db.Rdr.GetDateTime(2);
                booking.Length = db.Rdr.GetInt32(3);
                booking.Cost = db.Rdr.GetDecimal(4);
                booking.Balance = db.Rdr.GetDecimal(5);
                booking.Provisional = db.Rdr.GetBoolean(6);
                bookings.Add(booking);
            }
            db.Rdr.Close();
            return bookings;
        }

        public List<ClientModel> GetClients()
        {
            List<ClientModel> clients = new List<ClientModel>();
            ExecuteCommand("SELECT * FROM Client");
            while (db.Rdr.Read())
            {
                ClientModel client = new ClientModel();
                client.ClientId = db.Rdr.GetInt32(0);
                client.ClientForename = db.Rdr.GetString(1);
                client.ClientSurname = db.Rdr.GetString(2);
                client.ClientStreetAddress = db.Rdr.GetString(3);
                client.ClientCity = db.Rdr.GetString(4);
                client.ClientPostcode = db.Rdr.GetString(5);
                client.ClientPhoneNumber = db.Rdr.GetString(6);
                client.ClientEmail = db.Rdr.GetString(7);
                clients.Add(client);
            }
            db.Rdr.Close();
            return clients;
        }

        public List<PodModel> GetPods()
        {
            List<PodModel> pods = new List<PodModel>();
            ExecuteCommand("SELECT * FROM Pod");
            while (db.Rdr.Read())
            {
                PodModel pod = new PodModel();
                pod.PodId = db.Rdr.GetInt32(0);
                pod.PodCapacity = db.Rdr.GetInt32(1);
                pod.PodType = db.Rdr.GetString(2);
                pods.Add(pod);
            }
            db.Rdr.Close();
            return pods;
        }

        public List<GuestModel> GetGuests()
        {
            List<GuestModel> guests = new List<GuestModel>();
            ExecuteCommand("SELECT * FROM Guest");
            while (db.Rdr.Read())
            {
                GuestModel guest = new GuestModel();
                guest.GuestId = db.Rdr.GetInt32(0);
                guest.BookingId = db.Rdr.GetInt32(1);
                guest.Forename = db.Rdr.GetString(2);
                guest.Surname = db.Rdr.GetString(3);
                guest.PodId = db.Rdr.GetInt32(4);
                guests.Add(guest);
            }
            db.Rdr.Close();
            return guests;
        }

        public int AddBooking(BookingModel booking)
        {
            booking.BookingId = GetBookings().Count + 1;

            int provisionalValue = booking.Provisional ? 1 : 0;

            ExecuteCommand("INSERT INTO Booking (BookingId, ClientId, StartDate, Length, Cost, Balance, Provisional) VALUES (" +
                           booking.BookingId + ", " + booking.ClientId + ", '" + booking.StartDate.ToString("yyyy-MM-dd") + "', " +
                           booking.Length + ", " + booking.Cost + ", " + booking.Balance + ", " + provisionalValue + ")");
            db.Rdr.Close();
            return booking.BookingId;
        }


        public void UpdateBooking(BookingModel booking)
        {
            ExecuteCommand("UPDATE Booking SET ClientId = " + booking.ClientId + ", StartDate = '" + booking.StartDate.ToString("yyyy-MM-dd") + "', Length = " + booking.Length + ", Cost = " + booking.Cost + ", Balance = " + booking.Balance + ", Provisional = " + booking.Provisional + " WHERE BookingId = " + booking.BookingId);
            db.Rdr.Close();
        }

        public void RemoveBooking(BookingModel booking)
        {
            ExecuteCommand("DELETE FROM Booking WHERE BookingId = " + booking.BookingId);
            db.Rdr.Close();
        }

        public void AddClient(ClientModel client)
        {
            client.ClientId = GetClients().Count + 1;
            ExecuteCommand("INSERT INTO Client (ClientId, ClientForename, ClientSurname, ClientStreetAddress, ClientCity, ClientPostcode, ClientPhoneNumber, ClientEmail) VALUES ('" + client.ClientId + "', '" + client.ClientForename + "', '" + client.ClientSurname + "', '" + client.ClientStreetAddress + "', '" + client.ClientCity + "', '" + client.ClientPostcode + "', '" + client.ClientPhoneNumber + "', '" + client.ClientEmail + "')");
            db.Rdr.Close();
        }

        public void UpdateClient(ClientModel client)
        {
            ExecuteCommand("UPDATE Client SET ClientForename = '" + client.ClientForename + "', ClientSurname = '" + client.ClientSurname + "', ClientStreetAddress = '" + client.ClientStreetAddress + "', ClientCity = '" + client.ClientCity + "', ClientPostcode = '" + client.ClientPostcode + "', ClientPhoneNumber = '" + client.ClientPhoneNumber + "', ClientEmail = '" + client.ClientEmail + "' WHERE ClientId = " + client.ClientId);
            db.Rdr.Close();
        }

        public void RemoveClient(ClientModel client)
        {
            ExecuteCommand("DELETE FROM Client WHERE ClientId = " + client.ClientId);
            db.Rdr.Close();
        }

        public void AddGuest(GuestModel guest)
        {
            guest.GuestId = GetGuests().Count + 1;
            ExecuteCommand("INSERT INTO Guest (GuestId, BookingId, Forename, Surname, PodId) VALUES (" +
                           guest.GuestId + ", " + guest.BookingId + ", '" + guest.Forename + "', '" + guest.Surname + "', " + guest.PodId + ")");
            db.Rdr.Close();
        }

        public void RemoveGuestByGuestId(GuestModel guest)
        {
            ExecuteCommand("DELETE FROM Guest WHERE GuestId = " + guest.GuestId);
            db.Rdr.Close();
        }

        public void RemoveGuestByBookingId(GuestModel guest)
        {
            ExecuteCommand("DELETE FROM Guest WHERE PodId = " + guest.BookingId);
            db.Rdr.Close();
        }

        public BookingModel GetBookingById(int bookingId)
        {
            ExecuteCommand("SELECT * FROM Booking WHERE BookingId = " + bookingId);
            BookingModel booking = null;
            if (db.Rdr.Read())
            {
                booking = new BookingModel();
                booking.BookingId = db.Rdr.GetInt32(0);
                booking.ClientId = db.Rdr.GetInt32(1);
                booking.StartDate = db.Rdr.GetDateTime(2);
                booking.Length = db.Rdr.GetInt32(3);
                booking.Cost = db.Rdr.GetDecimal(4);
                booking.Balance = db.Rdr.GetDecimal(5);
                booking.Provisional = db.Rdr.GetBoolean(6);
            }
            db.Rdr.Close();
            return booking;
        }

        public ClientModel GetClientById(int clientId)
        {
            ExecuteCommand("SELECT * FROM Client WHERE ClientId = " + clientId);
            ClientModel client = null;
            if (db.Rdr.Read())
            {
                client = new ClientModel();
                client.ClientId = db.Rdr.GetInt32(0);
                client.ClientForename = db.Rdr.GetString(1);
                client.ClientSurname = db.Rdr.GetString(2);
                client.ClientStreetAddress = db.Rdr.GetString(3);
                client.ClientCity = db.Rdr.GetString(4);
                client.ClientPostcode = db.Rdr.GetString(5);
                client.ClientPhoneNumber = db.Rdr.GetString(6);
                client.ClientEmail = db.Rdr.GetString(7);
            }
            db.Rdr.Close();
            return client;
        }

        public PodModel GetPodById(int podId)
        {
            ExecuteCommand("SELECT * FROM Pod WHERE PodId = " + podId);
            PodModel pod = null;
            if (db.Rdr.Read())
            {
                pod = new PodModel();
                pod.PodId = db.Rdr.GetInt32(0);
                pod.PodCapacity = db.Rdr.GetInt32(1);
                pod.PodType = db.Rdr.GetString(2);
            }
            db.Rdr.Close();
            return pod;
        }

        public GuestModel GetGuestById(int guestId)
        {
            ExecuteCommand("SELECT * FROM Guest WHERE GuestId = " + guestId);
            GuestModel guest = null;
            if (db.Rdr.Read())
            {
                guest = new GuestModel();
                guest.GuestId = db.Rdr.GetInt32(0);
                guest.BookingId = db.Rdr.GetInt32(1);
                guest.Forename = db.Rdr.GetString(2);
                guest.Surname = db.Rdr.GetString(3);
                guest.PodId = db.Rdr.GetInt32(4);
            }

            db.Rdr.Close();
            return guest;
        }

        public int CalculatePodSpaces()
        {
            return 0;
        }
    }
}
