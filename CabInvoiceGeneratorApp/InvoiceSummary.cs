using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGeneratorApp
{
    public class InvoiceSummary    //UC3
    {
        public double totalFare;
        public double averageFare;
        public int noOfRides;
        public string usrtId;

        public InvoiceSummary(double totalFare, int noOfRides)
        {
            this.totalFare = totalFare;
            this.noOfRides = noOfRides;
            this.averageFare = this.totalFare / this.noOfRides;
        }
        public InvoiceSummary(string userID)       //UC4
        {
            this.usrtId = userID;
        }
    }
}
