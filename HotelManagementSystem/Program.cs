namespace HotelManagementSystem
{
    class Room
    {
        public int roomNumber { get; }
        public string roomType;
        public double pricePerNight;
        public bool isAvailable;

        public Room(int roomNumber, string roomType, double pricePerNight, bool isAvailable)
        {
            this.roomNumber = roomNumber;
            this.roomType = roomType;
            this.pricePerNight = pricePerNight;
            this.isAvailable = isAvailable;
        }

        public void displayRoom()
        {
            Console.WriteLine($"Room Number   : {roomNumber}");
            Console.WriteLine($"Room Type     : {roomType}");
            Console.WriteLine($"Price / Night : OMR {pricePerNight}");
            Console.WriteLine($"Status        : {(isAvailable ? "Available" : "Booked")}");
        } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
