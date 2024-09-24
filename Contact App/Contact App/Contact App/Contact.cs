
namespace Contact_App
{
    public class Contact
    {
        private string contactName;
        private string phoneNumber;
        private string email;
        private string address;
        public Contact(string contactName, string phoneNumber, string email, string address)
        {
            this.contactName=contactName;
            this.phoneNumber=phoneNumber;
            this.email=email;
            this.address=address;
        }
        public string ContactName { get => contactName; set => contactName=value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber=value; }
        public string Email { get => email; set => email=value; }
        public string Address { get => address; set => address=value; }
        public override string ToString ()
        {
            return $"{contactName},{phoneNumber},{email},{address}";
        }
           
    }
}
