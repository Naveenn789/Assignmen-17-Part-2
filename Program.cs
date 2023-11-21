using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment17P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HerbalProduct herbalProduct = new HerbalProduct();

            Console.Write("Enter Product ID: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Enter Product Name: ");
            string productName = Console.ReadLine();

            Console.Write("Enter Product Price: ");
            double productPrice = double.Parse(Console.ReadLine());

            herbalProduct.SetInformation(productId, productName, productPrice);

            Console.WriteLine("\nProduct Details:");
            herbalProduct.ShowDetails();

            Console.ReadKey();

        }
    }
}
