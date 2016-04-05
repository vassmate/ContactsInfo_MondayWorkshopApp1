namespace WorkshopApp1
{
    // Creating struct for Person object
    public struct Person
    {
        // Parameters of Person object
        public string _name;
        public string _address;
        public int _age;
        public int _mobilenumber;
        public Type _type;

        // Type enum for representing phonenumber types
        public enum Type
        {
            Home, Workplace, Mobile
        }

        // Override ToString method for numerous good reasons
        public override string ToString()
        {
            return $"Name: {_name}, Age: {_age}, Address: {_address}, Phone: {_mobilenumber}, Phone type: {_type}";
        }
    }
}