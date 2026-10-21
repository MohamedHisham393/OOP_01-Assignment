namespace OOP____01_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 01 : Theoretical Questions

            //Q1
            // a) nothing happens to the original value because they will be two blocks in stack and they are independent
            // b) changes in copied variable will appear in the original because they refer to the same addres in heap

            //============================================================

            //Q2
            // a) 1- No validation on weight so if the user make weight = -10 it willnot prevent this
            //    2- user can reach fields and modify on it using shipment.DeliveryFee
            //    3- 

            // b) using propeties --> (set) and make validation 

            //---------------------------------------------------------------------------------------------------

            //Part 02 : Practical

            DeliveryAddress D01 = new DeliveryAddress("Maadi", "Maged", 44);
            DeliveryAddress D02 = new DeliveryAddress("Nasr City", "Abbas", 50);
            DeliveryAddress D03 = new DeliveryAddress("Narges", "khaled", 60);
            //Console.WriteLine(D01.GetFullAddress());

            //DeliveryAddress D02 = D01;
            //Console.WriteLine(D02.GetFullAddress());

            //D02.City = "Nasr City";
            //D02.Street = "Abbas";
            //Console.WriteLine(D02.GetFullAddress());

            Shipment sh01 = new Shipment("estdd", "laptop", 50.5, 95, D01);
            Shipment sh02 = new Shipment("kaah966", "mobile", 10.5, 95, D02);
            Shipment sh03 = new Shipment("ehh50", "cahrger", 20.5, 95, D03);

            //sh01.PrintShipment();


            //center.AddShipment(sh01);
            //center.AddShipment(sh02);
            //center.AddShipment(sh03);


            //center[2] = sh03;

            //Shipment trying = center["kaah966"];
            //trying.PrintShipment();

            DeliveryCenter center = new DeliveryCenter();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"--- Shipment {i} ---");
                Console.Write("Tracking Code: ");
                string code = Console.ReadLine();
                Console.Write("Description: ");
                string desc = Console.ReadLine();
                Console.Write("Weight: ");
                double weight = double.Parse(Console.ReadLine());
                Console.Write("Delivery Fee: ");
                decimal fee = decimal.Parse(Console.ReadLine());
                Console.Write("City: ");
                string city = Console.ReadLine();
                Console.Write("Street: ");
                string street = Console.ReadLine();
                Console.Write("Building Number: ");
                int building = int.Parse(Console.ReadLine());

                DeliveryAddress address = new DeliveryAddress(city, street, building);
                Shipment shipment = new Shipment(code, desc, weight, fee, address);
                center.AddShipment(shipment);
            }

            Console.WriteLine("\n===== All Shipments =====");
            for (int i = 0; i < 3; i++)
            {
                center[i].PrintShipment();
                Console.WriteLine();
            }

            Console.Write("Enter tracking code to search: ");
            string search = Console.ReadLine();
            Shipment found = center[search];

            if (found.TrackingCode == null)
                Console.WriteLine("Shipment not found.");
            else
                found.PrintShipment();

            
            Console.WriteLine("\n===== Struct Copy =====");
            DeliveryAddress address01 = new DeliveryAddress("Maadi", "Maged", 44);
            DeliveryAddress address02 = address01;
            address02.City = "Nasr City";
            address02.Street = "Abbas";
            Console.WriteLine(address01.GetFullAddress());
            Console.WriteLine(address02.GetFullAddress());



        }
    }
}
