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
            //Console.WriteLine(D01.GetFullAddress());

            //DeliveryAddress D02 = D01;
            //Console.WriteLine(D02.GetFullAddress());

            //D02.City = "Nasr City";
            //D02.Street = "Abbas";
            //Console.WriteLine(D02.GetFullAddress());

            Shipment sh01 = new Shipment("est77", "laptop", 50.5, 95, D01);

            sh01.PrintShipment();



        }
    }
}
