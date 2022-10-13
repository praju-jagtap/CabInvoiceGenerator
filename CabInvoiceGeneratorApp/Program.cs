namespace CabInvoiceGeneratorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CabInvoiceGenerator cabInvoiceGenerator = new CabInvoiceGenerator();  //UC1
            double fare = cabInvoiceGenerator.CalculatFare(2.0, 4.0);
            Console.WriteLine("The Total Fare For The Journey : " + fare);
        }
    }
}