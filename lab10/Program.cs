using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.SqlClient;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwndDataContext context = new NorthwndDataContext();

            //var query = from p in context.Products
            //            select p;

            //var query = from p in context.Products
            //            where p.Categories.CategoryName == "Beverages"
            //            select p;

            //var query = from p in context.Products
            //            where p.UnitPrice < 20
            //            select p;

            //Listado de productos cuyo nombre incluye la palabra queso
            //var query = from p in context.Products
            //            where SqlMethods.Like(p.ProductName, "%Queso%")
            //            select p;

            //Listado de productos cuya presentacion sea "pkg" o "pkgs"
            //var query = from p in context.Products
            //            where SqlMethods.Like(p.QuantityPerUnit, "%pkg%") ||
            //                  SqlMethods.Like(p.QuantityPerUnit, "%pkgs%")
            //            select p;

            //Lista de productos que empiezen con A
            //var query = from p in context.Products
            //            where p.ProductName.StartsWith("A")
            //            select p;

            //Lista de productos sin stock
            //var query = from p in context.Products
            //            where p.UnitsInStock == 0
            //            select p;

            //Listar productos descontinuados
            //var query = from p in context.Products
            //            where p.Discontinued == true
            //            select p;

            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Name={1}", prod.ProductID, prod.ProductName);
            //    Console.WriteLine("ID={0} \t Price={1} \t Name={2}", prod.ProductID, prod.UnitPrice, prod.ProductName);
            //    Console.WriteLine("ID={0} \t Name={1} \t Presentacion={2}", prod.ProductID, prod.ProductName, prod.QuantityPerUnit);
            //    Console.WriteLine("ID={0} \t Name={1} \t Stok={2}", prod.ProductID, prod.ProductName, prod.UnitsInStock);
            //    Console.WriteLine("ID={0} \t Name={1} \t Descontinuado={2}", prod.ProductID, prod.ProductName, prod.Discontinued);
            //}

            //Insertar datos
            //Products p = new Products();
            //p.ProductName = "Peruvian Coffe";
            //p.SupplierID = 20;
            //p.SupplierID = 20;
            //p.CategoryID = 1;
            //p.QuantityPerUnit = "10 pkgs";
            //p.UnitPrice = 25;

            //context.Products.InsertOnSubmit(p);
            //context.SubmitChanges();


            //var query = from pr in context.Products
            //            where pr.CategoryID == 1
            //            select pr;

            //foreach (var prod in query)
            //{
            //    Console.WriteLine("ID={0} \t Name={1}", prod.ProductID, prod.ProductName);
            //}

            //Insertar registro en la tabla Categories
            //Categories c = new Categories();
            //c.CategoryName = "Nueva Categoria";
            //c.Description = "Esta categoria es de prueba";

            //context.Categories.InsertOnSubmit(c);
            //context.SubmitChanges();

            //var query = from ca in context.Categories
            //            select ca;

            //foreach (var cat in query)
            //{
            //    Console.WriteLine("ID={0} \t Name={1}", cat.CategoryID, cat.CategoryName);
            //}


            //Edicion de datos
            var query = from p in context.Products
                        where p.ProductName == "Tofu"
                        select p;

            foreach (var prod in query)
            {
                Console.WriteLine("ID={0} \t Name={1} \t Price={2} \t Stok={3} \t Descontinuado={4}", prod.ProductID, prod.ProductName, prod.UnitPrice, prod.UnitsInStock, prod.Discontinued);
            }

            var product = (from p in context.Products
                           where p.ProductName == "Tofu"
                           select p).FirstOrDefault();

            product.UnitPrice = 100;
            product.UnitsInStock = 15;
            product.Discontinued = true;

            context.SubmitChanges();

            var query2 = from p2 in context.Products
                        where p2.ProductName == "Tofu"
                        select p2;

            foreach (var prod2 in query2)
            {
                Console.WriteLine("ID={0} \t Name={1} \t Price={2} \t Stok={3} \t Descontinuado={4}", prod2.ProductID, prod2.ProductName, prod2.UnitPrice, prod2.UnitsInStock, prod2.Discontinued);
            }

            //Eliminacion de datos
            var productEliminar = (from pr3 in context.Products
                           where pr3.ProductID == 78
                           select pr3).FirstOrDefault();

            context.Products.DeleteOnSubmit(productEliminar);
            context.SubmitChanges();

            var queryEliminar = from pr4 in context.Products
                        where pr4.CategoryID == 1
                        select pr4;

            foreach (var prod4 in query)
            {
                Console.WriteLine("ID={0} \t Name={1}", prod4.ProductID, prod4.ProductName);
            }

            Console.ReadKey();
        }
    }
}
