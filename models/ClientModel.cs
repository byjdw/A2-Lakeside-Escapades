namespace Banbridge_Academy_SSD_Coursework.models
{
    internal class ClientModel
    {
        int clientId;
        string clientForename;
        string clientSurname;
        string clientStreetAddress;
        string clientCity;
        string clientPostcode;
        string clientPhoneNumber;
        string clientEmail;

        public ClientModel() { }

        public ClientModel(int clientId, string clientForename, string clientSurname, string clientStreetAddress, string clientCity, string clientPostcode, string clientPhoneNumber, string clientEmail)
        {
            this.clientId = clientId;
            this.clientForename = clientForename;
            this.clientSurname = clientSurname;
            this.clientStreetAddress = clientStreetAddress;
            this.clientCity = clientCity;
            this.clientPostcode = clientPostcode;
            this.clientPhoneNumber = clientPhoneNumber;
            this.clientEmail = clientEmail;
        }

        public int ClientId { get => clientId; set => clientId = value; }
        public string ClientForename { get => clientForename; set => clientForename = value; }
        public string ClientSurname { get => clientSurname; set => clientSurname = value; }
        public string ClientStreetAddress { get => clientStreetAddress; set => clientStreetAddress = value; }
        public string ClientCity { get => clientCity; set => clientCity = value; }
        public string ClientPostcode { get => clientPostcode; set => clientPostcode = value; }
        public string ClientPhoneNumber { get => clientPhoneNumber; set => clientPhoneNumber = value; }
        public string ClientEmail { get => clientEmail; set => clientEmail = value; }
    }
}
