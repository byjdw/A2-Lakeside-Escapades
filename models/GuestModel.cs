namespace Banbridge_Academy_SSD_Coursework.models
{
    internal class GuestModel
    {
        int guestId;
        int bookingId;
        string forename;
        string surname;
        int podId;

        public GuestModel()
        {

        }

        public GuestModel(int guestId, int bookingId, string forename, string surname, int podId)
        {
            this.GuestId = guestId;
            this.BookingId = bookingId;
            this.Forename = forename;
            this.Surname = surname;
            this.PodId = podId;
        }

        public int GuestId { get => guestId; set => guestId = value; }
        public int BookingId { get => bookingId; set => bookingId = value; }
        public string Forename { get => forename; set => forename = value; }
        public string Surname { get => surname; set => surname = value; }
        public int PodId { get => podId; set => podId = value; }
    }
}
