using InterfacePracticeModel;
using InterfacePracticeModel.Interfaces;
using System;
using System.Collections.Generic;

namespace InterfacePracticeUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProductModel> cart = addData();
            var customer = GetCustomer();

            foreach (IProductModel product in cart)
            {
                product.ShipItems(customer);
                if (product is IDigitalProductModel digitalProduct)
                {
                    Console.WriteLine($"You have {digitalProduct.DownloadsLeft} " +
                        $"downloads LEFT! for {digitalProduct.Name}");
                }
            }
            Console.ReadLine();
        }

        private static List<IProductModel> addData()
        {
            return new List<IProductModel>()
            {
                new PhysicalProductModel("Xbox Game", 59.90),
                new PhysicalProductModel("Hard Drive", 149.90),
                new PhysicalProductModel("Xbox Console", 499.90),
                new DigitalProductModel("C# Online Course", 19.90)     ,
                new CourseProductModel("DotNet Course Start to Finish", 99.90)
            };
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Letícia",
                LastName = "Pichotano",
                CellphoneNumber = "19-99475-4839",
                PhoneNumber = null,
                Email = "leticiapichotano@hotmail.com",
                Address = new CustomerAddressModel("Rua", "Paschoal Pisani", 285, "Jd Santa Clara",
                        "Mococa", "São Paulo", 13735250)
            };
        }
    }
}
