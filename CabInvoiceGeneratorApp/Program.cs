namespace CabInvoiceGeneratorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CabInvoiceGenerator cabInvoiceGenerator = new CabInvoiceGenerator();  //UC1
            double fare = cabInvoiceGenerator.CalculatFare(2.0, 4.0);
            Console.WriteLine("The Total Fare For The Journey : " + fare);

            Ride[] ride = { new Ride(1, 2), new Ride(3, 4) };                               //UC2
            double getMultiple = cabInvoiceGenerator.GetMultipleRideFare(ride);
            Console.WriteLine("\nThe Aggregate Total For All : " + getMultiple);
        }
    }
}