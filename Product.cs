using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment17P2
{
    public class Product
    {

         int pid;
         string pname;
         double pprice;

        // Method to show details
        public virtual void ShowDetails()
        {
            Console.WriteLine($"Product ID: {pid}");
            Console.WriteLine($"Product Name: {pname}");
            Console.WriteLine($"Product Price: {pprice:C}");
        }

        // Method to set information
        public virtual void SetInformation(int id, string name, double price)
        {
            pid = id;
            pname = name;
            pprice = price;
        }

    }
}
