using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
             ProductTest();
            //CategoryTest();
            


        }

        private static void CategoryTest()
        {
            // kategorileri listeler
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }

            Console.ReadLine();
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            //foreach (var product in productManager.GetAll())
            //foreach (var product in productManager.GetAllByCategoryId(2))
            //foreach (var product in productManager.GetProductDetails().Data)

            var result = productManager.GetProductDetails();
           
            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " / " + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
                
            
            Console.ReadLine();
        }
    }
}
