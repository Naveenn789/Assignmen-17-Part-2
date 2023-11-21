using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment17P2
{
    internal class HerbalProduct : Product
    {
        
             string herbsUsed;
             DateTime mfDate;
             DateTime expDate;

            // Override methods to add details of Herbal Product fields
            public override void ShowDetails()
            {
                base.ShowDetails(); // Call base class method first
                Console.WriteLine($"Herbs Used: {herbsUsed}");
                Console.WriteLine($"Manufacturing Date: {mfDate.ToShortDateString()}");
                Console.WriteLine($"Expiry Date: {expDate.ToShortDateString()}");
            }

            public override void SetInformation(int id, string name, double price)
            {
                base.SetInformation(id, name, price); // Call base class method first
                Console.Write("Enter Herbs Used: ");
                herbsUsed = Console.ReadLine();
                Console.Write("Enter Manufacturing Date (yyyy-MM-dd): ");
                mfDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter Expiry Date (yyyy-MM-dd): ");
                expDate = DateTime.Parse(Console.ReadLine());
            }

        }
    }
