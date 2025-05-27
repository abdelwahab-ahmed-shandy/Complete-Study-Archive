using Bikestore_task_11.Data;
using Bikestore_task_11.Models;
using System.Text.RegularExpressions;

namespace Bikestore_task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Using Linq & C# on BikeStoreDB:
             * 
             * In this project we will start with the Database First method :
             * 
             *1 Retrieve all categories from the production.categories table.
             * 
             *2 Retrieve the first product from the production.products table.
             * 
             *3 Retrieve a specific product from the production.products table by ID.
             * 
             *4 Retrieve all products from the production.products table with a certain model year.
             * 
             *5 Retrieve a specific customer from the sales.customers table by ID.
             * 
             *6 Retrieve a list of product names and their corresponding brand names.
             * 
             *7 Count the number of products in a specific category.
             * 
             *8 Calculate the total list price of all products in a specific category.
             * 
             *9 Calculate the average list price of products.
             * 
             *10 Retrieve orders that are completed.
             * 
             */

            //
            BikeStoreDbContext dbContext = new BikeStoreDbContext();

            #region Retrieve all categories from the production.categories table
            // Retrieve all categories from the production.categories table :


            Console.WriteLine("The Categories");

            var categories = dbContext.Categories.Select(e => new { e.CategoryId, e.CategoryName })
                                      .ToList();
            foreach (var item in categories)
            {
                Console.WriteLine($"ID: {item.CategoryId}, Name: {item.CategoryName}");
            }

            // The Result :

            /*The Categories
              ID: 1, Name: Children Bicycles
              ID: 2, Name: Comfort Bicycles
              ID: 3, Name: Cruisers Bicycles
              ID: 4, Name: Cyclocross Bicycles
              ID: 5, Name: Electric Bikes
              ID: 6, Name: Mountain Bikes
              ID: 7, Name: Road Bikes
            */
            #endregion

            #region Retrieve the first product from the production.products table.
            // Retrieve the first product from the production.products table :

            Console.WriteLine("\nThe FirestProdouct : ");

            var FirestProdouct = dbContext.Products.First(e => e.ProductId == 1);
            if (FirestProdouct != null)
            {
                Console.WriteLine($"The Firest Product is => ID: {FirestProdouct.ProductId}, Name: {FirestProdouct.ProductName}");
            }
            else
            {
                Console.WriteLine("Not Found.");
            }

            // The Result :

            /*
             The FirestProdouct :
             The Firest Product is => The First Proguct => ID: 1, Name: Trek 820 - 2016
            */
            #endregion

            #region Retrieve a specific product from the production.products table by ID.
            // Retrieve a specific product from the production.products table by ID :

            Console.WriteLine("\nThe products table by ID : ");

            var productsWhithID = dbContext.Products.Find(5);
            Console.WriteLine($"products table by ID , is ID = {productsWhithID.ProductId} , the Name = {productsWhithID.ProductName} ");

            // The Result :

            /*
             The products table by ID :
             products table by ID , is ID = 5 , the Name = Heller Shagamaw Frame - 2016
            */
            #endregion


            #region Retrieve all products from the production.products table with a certain model year.
            // Retrieve all products from the production.products table with a certain model year:

            Console.WriteLine("\nThe products With Model Year : ");
            Console.WriteLine("Enter is the required year?");
            int EnterMdelYear = Convert.ToInt32(Console.ReadLine());

            var productsWhithYear = dbContext.Products.Where(P => P.ModelYear == EnterMdelYear).ToList();

            if (productsWhithYear.Any())
            {
                foreach (var product in productsWhithYear)
                {
                    Console.WriteLine($"ID: {product.ProductId}, Name: {product.ProductName} , ModelYear {product.ModelYear}");
                }
            }
            else
            {
                Console.WriteLine("Not Found.");
            }

            // The Result :

            /*
             The products With Model Year :
             Enter is the required year?
             2016
             ID: 1, Name: Trek 820 - 2016 , ModelYear 2016
             ID: 2, Name: Ritchey Timberwolf Frameset - 2016 , ModelYear 2016
             ID: 3, Name: Surly Wednesday Frameset - 2016 , ModelYear 2016
             ID: 4, Name: Trek Fuel EX 8 29 - 2016 , ModelYear 2016
             ID: 5, Name: Heller Shagamaw Frame - 2016 , ModelYear 2016
             ID: 6, Name: Surly Ice Cream Truck Frameset - 2016 , ModelYear 2016
             ID: 7, Name: Trek Slash 8 27.5 - 2016 , ModelYear 2016
             ID: 8, Name: Trek Remedy 29 Carbon Frameset - 2016 , ModelYear 2016
             ID: 9, Name: Trek Conduit+ - 2016 , ModelYear 2016
             ID: 10, Name: Surly Straggler - 2016 , ModelYear 2016
             ID: 11, Name: Surly Straggler 650b - 2016 , ModelYear 2016
             ID: 12, Name: Electra Townie Original 21D - 2016 , ModelYear 2016
             ID: 13, Name: Electra Cruiser 1 (24-Inch) - 2016 , ModelYear 2016
             ID: 14, Name: Electra Girl's Hawaii 1 (16-inch) - 2015/2016 , ModelYear 2016
             ID: 15, Name: Electra Moto 1 - 2016 , ModelYear 2016
             ID: 16, Name: Electra Townie Original 7D EQ - 2016 , ModelYear 2016
             ID: 17, Name: Pure Cycles Vine 8-Speed - 2016 , ModelYear 2016
             ID: 18, Name: Pure Cycles Western 3-Speed - Women's - 2015/2016 , ModelYear 2016
             ID: 19, Name: Pure Cycles William 3-Speed - 2016 , ModelYear 2016
             ID: 20, Name: Electra Townie Original 7D EQ - Women's - 2016 , ModelYear 2016
             ID: 21, Name: Electra Cruiser 1 (24-Inch) - 2016 , ModelYear 2016
             ID: 22, Name: Electra Girl's Hawaii 1 (16-inch) - 2015/2016 , ModelYear 2016
             ID: 23, Name: Electra Girl's Hawaii 1 (20-inch) - 2015/2016 , ModelYear 2016
             ID: 24, Name: Electra Townie Original 21D - 2016 , ModelYear 2016
             ID: 25, Name: Electra Townie Original 7D - 2015/2016 , ModelYear 2016
             ID: 26, Name: Electra Townie Original 7D EQ - 2016 , ModelYear 2016

            */
            #endregion

            #region Retrieve a specific customer from the sales.customers table by ID.
            //Retrieve a specific customer from the sales.customers table by ID.

            Console.WriteLine("\nRetrieve a specific customer from the sales.customers table by ID. : ");
            Console.WriteLine("Enter is the customers ID?");
            int EnterCustId = Convert.ToInt32(Console.ReadLine());

            var CustomerWithId = dbContext.Customers.Find(EnterCustId);

            if (CustomerWithId != null)
            {
                Console.WriteLine($"ID: {CustomerWithId.CustomerId}, Name: {CustomerWithId.FirstName} {CustomerWithId.LastName}");
            }
            else
            {
                Console.WriteLine("Not Found.");
            }
            //The Resukt :
            /*
             Retrieve a specific customer from the sales.customers table by ID. :
             Enter is the customers ID?
             4
             ID: 4, Name: Daryl Spence
             */

            #endregion

            #region Retrieve a list of product names and their corresponding brand names.
            Console.WriteLine("Retrieve a list of product names and their corresponding brand names : ");

            var ProductBrand = dbContext.Products.Select(p => new { p.ProductName, p.Brand.BrandName });

            foreach (var item in ProductBrand)
            {
                Console.WriteLine($"Product Name Is :{item.ProductName} \n Brand Name: {item.BrandName}");
            }
            //the result :

            /*
             Retrieve a list of product names and their corresponding brand names :
Product Name Is :Trek 820 - 2016
 Brand Name: Trek
Product Name Is :Ritchey Timberwolf Frameset - 2016
 Brand Name: Ritchey
Product Name Is :Surly Wednesday Frameset - 2016
 Brand Name: Surly
Product Name Is :Trek Fuel EX 8 29 - 2016
 Brand Name: Trek
Product Name Is :Heller Shagamaw Frame - 2016
 Brand Name: Heller
Product Name Is :Surly Ice Cream Truck Frameset - 2016
 Brand Name: Surly
Product Name Is :Trek Slash 8 27.5 - 2016
 Brand Name: Trek
Product Name Is :Trek Remedy 29 Carbon Frameset - 2016
 Brand Name: Trek
Product Name Is :Trek Conduit+ - 2016
 Brand Name: Trek
Product Name Is :Surly Straggler - 2016
 Brand Name: Surly
Product Name Is :Surly Straggler 650b - 2016
 Brand Name: Surly
Product Name Is :Electra Townie Original 21D - 2016
 Brand Name: Electra
Product Name Is :Electra Cruiser 1 (24-Inch) - 2016
 Brand Name: Electra
Product Name Is :Electra Girl's Hawaii 1 (16-inch) - 2015/2016
 Brand Name: Electra
Product Name Is :Electra Moto 1 - 2016
 Brand Name: Electra
Product Name Is :Electra Townie Original 7D EQ - 2016
 Brand Name: Electra
Product Name Is :Pure Cycles Vine 8-Speed - 2016
 Brand Name: Pure Cycles
Product Name Is :Pure Cycles Western 3-Speed - Women's - 2015/2016
 Brand Name: Pure Cycles
Product Name Is :Pure Cycles William 3-Speed - 2016
 Brand Name: Pure Cycles
Product Name Is :Electra Townie Original 7D EQ - Women's - 2016
 Brand Name: Electra
Product Name Is :Electra Cruiser 1 (24-Inch) - 2016
 Brand Name: Electra
Product Name Is :Electra Girl's Hawaii 1 (16-inch) - 2015/2016
 Brand Name: Electra
Product Name Is :Electra Girl's Hawaii 1 (20-inch) - 2015/2016
 Brand Name: Electra
Product Name Is :Electra Townie Original 21D - 2016
 Brand Name: Electra
Product Name Is :Electra Townie Original 7D - 2015/2016
 Brand Name: Electra
Product Name Is :Electra Townie Original 7D EQ - 2016
 Brand Name: Electra
Product Name Is :Surly Big Dummy Frameset - 2017
 Brand Name: Surly
Product Name Is :Surly Karate Monkey 27.5+ Frameset - 2017
 Brand Name: Surly
Product Name Is :Trek X-Caliber 8 - 2017
 Brand Name: Trek
Product Name Is :Surly Ice Cream Truck Frameset - 2017
 Brand Name: Surly
Product Name Is :Surly Wednesday - 2017
 Brand Name: Surly
Product Name Is :Trek Farley Alloy Frameset - 2017
 Brand Name: Trek
Product Name Is :Surly Wednesday Frameset - 2017
 Brand Name: Surly
Product Name Is :Trek Session DH 27.5 Carbon Frameset - 2017
 Brand Name: Trek
Product Name Is :Sun Bicycles Spider 3i - 2017
 Brand Name: Sun Bicycles
Product Name Is :Surly Troll Frameset - 2017
 Brand Name: Surly
Product Name Is :Haro Flightline One ST - 2017
 Brand Name: Haro
Product Name Is :Haro Flightline Two 26 Plus - 2017
 Brand Name: Haro
Product Name Is :Trek Stache 5 - 2017
 Brand Name: Trek
Product Name Is :Trek Fuel EX 9.8 29 - 2017
 Brand Name: Trek
Product Name Is :Haro Shift R3 - 2017
 Brand Name: Haro
Product Name Is :Trek Fuel EX 5 27.5 Plus - 2017
 Brand Name: Trek
Product Name Is :Trek Fuel EX 9.8 27.5 Plus - 2017
 Brand Name: Trek
Product Name Is :Haro SR 1.1 - 2017
 Brand Name: Haro
Product Name Is :Haro SR 1.2 - 2017
 Brand Name: Haro
Product Name Is :Haro SR 1.3 - 2017
 Brand Name: Haro
Product Name Is :Trek Remedy 9.8 - 2017
 Brand Name: Trek
Product Name Is :Trek Emonda S 4 - 2017
 Brand Name: Trek
Product Name Is :Trek Domane SL 6 - 2017
 Brand Name: Trek
Product Name Is :Trek Silque SLR 7 Women's - 2017
 Brand Name: Trek
Product Name Is :Trek Silque SLR 8 Women's - 2017
 Brand Name: Trek
Product Name Is :Surly Steamroller - 2017
 Brand Name: Surly
Product Name Is :Surly Ogre Frameset - 2017
 Brand Name: Surly
Product Name Is :Trek Domane SL Disc Frameset - 2017
 Brand Name: Trek
Product Name Is :Trek Domane S 6 - 2017
 Brand Name: Trek
Product Name Is :Trek Domane SLR 6 Disc - 2017
 Brand Name: Trek
Product Name Is :Trek Emonda S 5 - 2017
 Brand Name: Trek
Product Name Is :Trek Madone 9.2 - 2017
 Brand Name: Trek
Product Name Is :Trek Domane S 5 Disc - 2017
 Brand Name: Trek
Product Name Is :Sun Bicycles ElectroLite - 2017
 Brand Name: Sun Bicycles
Product Name Is :Trek Powerfly 8 FS Plus - 2017
 Brand Name: Trek
Product Name Is :Trek Boone 7 - 2017
 Brand Name: Trek
Product Name Is :Trek Boone Race Shop Limited - 2017
 Brand Name: Trek
Product Name Is :Electra Townie Original 7D - 2017
 Brand Name: Electra
Product Name Is :Sun Bicycles Lil Bolt Type-R - 2017
 Brand Name: Sun Bicycles
Product Name Is :Sun Bicycles Revolutions 24 - 2017
 Brand Name: Sun Bicycles
Product Name Is :Sun Bicycles Revolutions 24 - Girl's - 2017
 Brand Name: Sun Bicycles
Product Name Is :Sun Bicycles Cruz 3 - 2017
 Brand Name: Sun Bicycles
Product Name Is :Sun Bicycles Cruz 7 - 2017
 Brand Name: Sun Bicycles
Product Name Is :Electra Amsterdam Original 3i - 2015/2017
 Brand Name: Electra
Product Name Is :Sun Bicycles Atlas X-Type - 2017
 Brand Name: Sun Bicycles
Product Name Is :Sun Bicycles Biscayne Tandem 7 - 2017
 Brand Name: Sun Bicycles
Product Name Is :Sun Bicycles Brickell Tandem 7 - 2017
 Brand Name: Sun Bicycles
Product Name Is :Electra Cruiser Lux 1 - 2017
 Brand Name: Electra
Product Name Is :Electra Cruiser Lux Fat Tire 1 Ladies - 2017
 Brand Name: Electra
Product Name Is :Electra Girl's Hawaii 1 16" - 2017
 Brand Name: Electra
Product Name Is :Electra Glam Punk 3i Ladies' - 2017
 Brand Name: Electra
Product Name Is :Sun Bicycles Biscayne Tandem CB - 2017
 Brand Name: Sun Bicycles
Product Name Is :Sun Bicycles Boardwalk (24-inch Wheels) - 2017
 Brand Name: Sun Bicycles
Product Name Is :Sun Bicycles Brickell Tandem CB - 2017
 Brand Name: Sun Bicycles
Product Name Is :Electra Amsterdam Fashion 7i Ladies' - 2017
 Brand Name: Electra
Product Name Is :Electra Amsterdam Original 3i Ladies' - 2017
 Brand Name: Electra
Product Name Is :Trek Boy's Kickster - 2015/2017
 Brand Name: Trek
Product Name Is :Sun Bicycles Lil Kitt'n - 2017
 Brand Name: Sun Bicycles
Product Name Is :Haro Downtown 16 - 2017
 Brand Name: Haro
Product Name Is :Trek Girl's Kickster - 2017
 Brand Name: Trek
Product Name Is :Trek Precaliber 12 Boys - 2017
 Brand Name: Trek
Product Name Is :Trek Precaliber 12 Girls - 2017
 Brand Name: Trek
Product Name Is :Trek Precaliber 16 Boys - 2017
 Brand Name: Trek
Product Name Is :Trek Precaliber 16 Girls - 2017
 Brand Name: Trek
Product Name Is :Trek Precaliber 24 (21-Speed) - Girls - 2017
 Brand Name: Trek
Product Name Is :Haro Shredder 20 - 2017
 Brand Name: Haro
Product Name Is :Haro Shredder 20 Girls - 2017
 Brand Name: Haro
Product Name Is :Haro Shredder Pro 20 - 2017
 Brand Name: Haro
Product Name Is :Electra Girl's Hawaii 1 16" - 2017
 Brand Name: Electra
Product Name Is :Electra Moto 3i (20-inch) - Boy's - 2017
 Brand Name: Electra
Product Name Is :Electra Savannah 3i (20-inch) - Girl's - 2017
 Brand Name: Electra
Product Name Is :Electra Straight 8 3i (20-inch) - Boy's - 2017
 Brand Name: Electra
Product Name Is :Electra Sugar Skulls 1 (20-inch) - Girl's - 2017
 Brand Name: Electra
Product Name Is :Electra Townie 3i EQ (20-inch) - Boys' - 2017
 Brand Name: Electra
Product Name Is :Electra Townie 7D (20-inch) - Boys' - 2017
 Brand Name: Electra
Product Name Is :Electra Townie Original 7D - 2017
 Brand Name: Electra
Product Name Is :Sun Bicycles Streamway 3 - 2017
 Brand Name: Sun Bicycles
Product Name Is :Sun Bicycles Streamway - 2017
 Brand Name: Sun Bicycles
Product Name Is :Sun Bicycles Streamway 7 - 2017
 Brand Name: Sun Bicycles
Product Name Is :Sun Bicycles Cruz 3 - 2017
 Brand Name: Sun Bicycles
Product Name Is :Sun Bicycles Cruz 7 - 2017
 Brand Name: Sun Bicycles
Product Name Is :Sun Bicycles Cruz 3 - Women's - 2017
 Brand Name: Sun Bicycles
Product Name Is :Sun Bicycles Cruz 7 - Women's - 2017
 Brand Name: Sun Bicycles
Product Name Is :Sun Bicycles Drifter 7 - 2017
 Brand Name: Sun Bicycles
Product Name Is :Sun Bicycles Drifter 7 - Women's - 2017
 Brand Name: Sun Bicycles
Product Name Is :Trek 820 - 2018
 Brand Name: Trek
Product Name Is :Trek Marlin 5 - 2018
 Brand Name: Trek
Product Name Is :Trek Marlin 6 - 2018
 Brand Name: Trek
Product Name Is :Trek Fuel EX 8 29 - 2018
 Brand Name: Trek
Product Name Is :Trek Marlin 7 - 2017/2018
 Brand Name: Trek
Product Name Is :Trek Ticket S Frame - 2018
 Brand Name: Trek
Product Name Is :Trek X-Caliber 8 - 2018
 Brand Name: Trek
Product Name Is :Trek Kids' Neko - 2018
 Brand Name: Trek
Product Name Is :Trek Fuel EX 7 29 - 2018
 Brand Name: Trek
Product Name Is :Surly Krampus Frameset - 2018
 Brand Name: Surly
Product Name Is :Surly Troll Frameset - 2018
 Brand Name: Surly
Product Name Is :Trek Farley Carbon Frameset - 2018
 Brand Name: Trek
Product Name Is :Surly Krampus - 2018
 Brand Name: Surly
Product Name Is :Trek Kids' Dual Sport - 2018
 Brand Name: Trek
Product Name Is :Surly Big Fat Dummy Frameset - 2018
 Brand Name: Surly
Product Name Is :Surly Pack Rat Frameset - 2018
 Brand Name: Surly
Product Name Is :Surly ECR 27.5 - 2018
 Brand Name: Surly
Product Name Is :Trek X-Caliber 7 - 2018
 Brand Name: Trek
Product Name Is :Trek Stache Carbon Frameset - 2018
 Brand Name: Trek
Product Name Is :Heller Bloodhound Trail - 2018
 Brand Name: Heller
Product Name Is :Trek Procal AL Frameset - 2018
 Brand Name: Trek
Product Name Is :Trek Procaliber Frameset - 2018
 Brand Name: Trek
Product Name Is :Trek Remedy 27.5 C Frameset - 2018
 Brand Name: Trek
Product Name Is :Trek X-Caliber Frameset - 2018
 Brand Name: Trek
Product Name Is :Trek Procaliber 6 - 2018
 Brand Name: Trek
Product Name Is :Heller Shagamaw GX1 - 2018
 Brand Name: Heller
Product Name Is :Trek Fuel EX 5 Plus - 2018
 Brand Name: Trek
Product Name Is :Trek Remedy 7 27.5 - 2018
 Brand Name: Trek
Product Name Is :Trek Remedy 9.8 27.5 - 2018
 Brand Name: Trek
Product Name Is :Trek Stache 5 - 2018
 Brand Name: Trek
Product Name Is :Trek Fuel EX 8 29 XT - 2018
 Brand Name: Trek
Product Name Is :Trek Domane ALR 3 - 2018
 Brand Name: Trek
Product Name Is :Trek Domane ALR 4 Disc - 2018
 Brand Name: Trek
Product Name Is :Trek Domane ALR 5 Disc - 2018
 Brand Name: Trek
Product Name Is :Trek Domane SLR 6 - 2018
 Brand Name: Trek
Product Name Is :Trek Domane ALR 5 Gravel - 2018
 Brand Name: Trek
Product Name Is :Trek Domane SL 8 Disc - 2018
 Brand Name: Trek
Product Name Is :Trek Domane SLR 8 Disc - 2018
 Brand Name: Trek
Product Name Is :Trek Emonda SL 7 - 2018
 Brand Name: Trek
Product Name Is :Trek Domane ALR 4 Disc Women's - 2018
 Brand Name: Trek
Product Name Is :Trek Domane SL 5 Disc Women's - 2018
 Brand Name: Trek
Product Name Is :Trek Domane SL 7 Women's - 2018
 Brand Name: Trek
Product Name Is :Trek Domane SLR 6 Disc Women's - 2018
 Brand Name: Trek
Product Name Is :Trek Domane SLR 9 Disc - 2018
 Brand Name: Trek
Product Name Is :Trek Domane SL Frameset - 2018
 Brand Name: Trek
Product Name Is :Trek Domane SL Frameset Women's - 2018
 Brand Name: Trek
Product Name Is :Trek CrossRip 1 - 2018
 Brand Name: Trek
Product Name Is :Trek Emonda ALR 6 - 2018
 Brand Name: Trek
Product Name Is :Trek Emonda SLR 6 - 2018
 Brand Name: Trek
Product Name Is :Surly ECR - 2018
 Brand Name: Surly
Product Name Is :Trek Emonda SL 6 Disc - 2018
 Brand Name: Trek
Product Name Is :Surly Pack Rat - 2018
 Brand Name: Surly
Product Name Is :Surly Straggler 650b - 2018
 Brand Name: Surly
Product Name Is :Trek 1120 - 2018
 Brand Name: Trek
Product Name Is :Trek Domane AL 2 Women's - 2018
 Brand Name: Trek
Product Name Is :Surly ECR Frameset - 2018
 Brand Name: Surly
Product Name Is :Surly Straggler - 2018
 Brand Name: Surly
Product Name Is :Trek Emonda SLR 8 - 2018
 Brand Name: Trek
Product Name Is :Trek CrossRip 2 - 2018
 Brand Name: Trek
Product Name Is :Trek Domane SL 6 - 2018
 Brand Name: Trek
Product Name Is :Trek Domane ALR Disc Frameset - 2018
 Brand Name: Trek
Product Name Is :Trek Domane ALR Frameset - 2018
 Brand Name: Trek
Product Name Is :Trek Domane SLR Disc Frameset - 2018
 Brand Name: Trek
Product Name Is :Trek Domane SLR Frameset - 2018
 Brand Name: Trek
Product Name Is :Trek Madone 9 Frameset - 2018
 Brand Name: Trek
Product Name Is :Trek Domane SLR 6 Disc - 2018
 Brand Name: Trek
Product Name Is :Trek Domane AL 2 - 2018
 Brand Name: Trek
Product Name Is :Trek Domane AL 3 - 2018
 Brand Name: Trek
Product Name Is :Trek Domane AL 3 Women's - 2018
 Brand Name: Trek
Product Name Is :Trek Domane SL 5 - 2018
 Brand Name: Trek
Product Name Is :Trek Domane SL 5 Disc - 2018
 Brand Name: Trek
Product Name Is :Trek Domane SL 5 Women's - 2018
 Brand Name: Trek
Product Name Is :Trek Domane SL 6 Disc - 2018
 Brand Name: Trek
Product Name Is :Trek Conduit+ - 2018
 Brand Name: Trek
Product Name Is :Trek CrossRip+ - 2018
 Brand Name: Trek
Product Name Is :Trek Neko+ - 2018
 Brand Name: Trek
Product Name Is :Trek XM700+ Lowstep - 2018
 Brand Name: Trek
Product Name Is :Trek Lift+ Lowstep - 2018
 Brand Name: Trek
Product Name Is :Trek Dual Sport+ - 2018
 Brand Name: Trek
Product Name Is :Electra Loft Go! 8i - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Go! 8i - 2017/2018
 Brand Name: Electra
Product Name Is :Trek Lift+ - 2018
 Brand Name: Trek
Product Name Is :Trek XM700+ - 2018
 Brand Name: Trek
Product Name Is :Electra Townie Go! 8i Ladies' - 2018
 Brand Name: Electra
Product Name Is :Trek Verve+ - 2018
 Brand Name: Trek
Product Name Is :Trek Verve+ Lowstep - 2018
 Brand Name: Trek
Product Name Is :Electra Townie Commute Go! - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Commute Go! Ladies' - 2018
 Brand Name: Electra
Product Name Is :Trek Powerfly 5 - 2018
 Brand Name: Trek
Product Name Is :Trek Powerfly 5 FS - 2018
 Brand Name: Trek
Product Name Is :Trek Powerfly 5 Women's - 2018
 Brand Name: Trek
Product Name Is :Trek Powerfly 7 FS - 2018
 Brand Name: Trek
Product Name Is :Trek Super Commuter+ 7 - 2018
 Brand Name: Trek
Product Name Is :Trek Super Commuter+ 8S - 2018
 Brand Name: Trek
Product Name Is :Trek Boone 5 Disc - 2018
 Brand Name: Trek
Product Name Is :Trek Boone 7 Disc - 2018
 Brand Name: Trek
Product Name Is :Trek Crockett 5 Disc - 2018
 Brand Name: Trek
Product Name Is :Trek Crockett 7 Disc - 2018
 Brand Name: Trek
Product Name Is :Surly Straggler - 2018
 Brand Name: Surly
Product Name Is :Surly Straggler 650b - 2018
 Brand Name: Surly
Product Name Is :Electra Townie Original 21D - 2018
 Brand Name: Electra
Product Name Is :Electra Cruiser 1 - 2016/2017/2018
 Brand Name: Electra
Product Name Is :Electra Tiger Shark 3i - 2018
 Brand Name: Electra
Product Name Is :Electra Queen of Hearts 3i - 2018
 Brand Name: Electra
Product Name Is :Electra Super Moto 8i - 2018
 Brand Name: Electra
Product Name Is :Electra Straight 8 3i - 2018
 Brand Name: Electra
Product Name Is :Electra Cruiser 7D - 2016/2017/2018
 Brand Name: Electra
Product Name Is :Electra Moto 3i - 2018
 Brand Name: Electra
Product Name Is :Electra Cruiser 1 Ladies' - 2018
 Brand Name: Electra
Product Name Is :Electra Cruiser 7D Ladies' - 2016/2018
 Brand Name: Electra
Product Name Is :Electra Cruiser 1 Tall - 2016/2018
 Brand Name: Electra
Product Name Is :Electra Cruiser Lux 3i - 2018
 Brand Name: Electra
Product Name Is :Electra Cruiser Lux 7D - 2018
 Brand Name: Electra
Product Name Is :Electra Delivery 3i - 2016/2017/2018
 Brand Name: Electra
Product Name Is :Electra Townie Original 21D EQ - 2017/2018
 Brand Name: Electra
Product Name Is :Electra Cruiser 7D (24-Inch) Ladies' - 2016/2018
 Brand Name: Electra
Product Name Is :Electra Cruiser 7D Tall - 2016/2018
 Brand Name: Electra
Product Name Is :Electra Cruiser Lux 1 - 2016/2018
 Brand Name: Electra
Product Name Is :Electra Cruiser Lux 1 Ladies' - 2018
 Brand Name: Electra
Product Name Is :Electra Cruiser Lux 3i Ladies' - 2018
 Brand Name: Electra
Product Name Is :Electra Cruiser Lux 7D Ladies' - 2018
 Brand Name: Electra
Product Name Is :Electra Cruiser Lux Fat Tire 7D - 2018
 Brand Name: Electra
Product Name Is :Electra Daydreamer 3i Ladies' - 2018
 Brand Name: Electra
Product Name Is :Electra Koa 3i Ladies' - 2018
 Brand Name: Electra
Product Name Is :Electra Morningstar 3i Ladies' - 2018
 Brand Name: Electra
Product Name Is :Electra Relic 3i - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Balloon 8D EQ - 2016/2017/2018
 Brand Name: Electra
Product Name Is :Electra Townie Balloon 8D EQ Ladies' - 2016/2017/2018
 Brand Name: Electra
Product Name Is :Electra Townie Commute 27D Ladies - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Commute 8D - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Commute 8D Ladies' - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Original 21D EQ Ladies' - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Original 21D Ladies' - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Original 3i EQ - 2017/2018
 Brand Name: Electra
Product Name Is :Electra Townie Original 3i EQ Ladies' - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Original 7D EQ - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Original 7D EQ Ladies' - 2017/2018
 Brand Name: Electra
Product Name Is :Electra White Water 3i - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Go! 8i - 2017/2018
 Brand Name: Electra
Product Name Is :Electra Townie Commute Go! - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Commute Go! Ladies' - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Go! 8i Ladies' - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Balloon 3i EQ - 2017/2018
 Brand Name: Electra
Product Name Is :Electra Townie Balloon 7i EQ Ladies' - 2017/2018
 Brand Name: Electra
Product Name Is :Electra Townie Commute 27D - 2018
 Brand Name: Electra
Product Name Is :Electra Amsterdam Fashion 3i Ladies' - 2017/2018
 Brand Name: Electra
Product Name Is :Electra Amsterdam Royal 8i - 2017/2018
 Brand Name: Electra
Product Name Is :Electra Amsterdam Royal 8i Ladies - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Balloon 3i EQ Ladies' - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Balloon 7i EQ - 2018
 Brand Name: Electra
Product Name Is :Trek MT 201 - 2018
 Brand Name: Trek
Product Name Is :Strider Classic 12 Balance Bike - 2018
 Brand Name: Strider
Product Name Is :Strider Sport 16 - 2018
 Brand Name: Strider
Product Name Is :Strider Strider 20 Sport - 2018
 Brand Name: Strider
Product Name Is :Trek Superfly 20 - 2018
 Brand Name: Trek
Product Name Is :Trek Precaliber 12 Girl's - 2018
 Brand Name: Trek
Product Name Is :Trek Kickster - 2018
 Brand Name: Trek
Product Name Is :Trek Precaliber 12 Boy's - 2018
 Brand Name: Trek
Product Name Is :Trek Precaliber 16 Boy's - 2018
 Brand Name: Trek
Product Name Is :Trek Precaliber 16 Girl's - 2018
 Brand Name: Trek
Product Name Is :Trek Precaliber 20 6-speed Boy's - 2018
 Brand Name: Trek
Product Name Is :Trek Precaliber 20 6-speed Girl's - 2018
 Brand Name: Trek
Product Name Is :Trek Precaliber 20 Boy's - 2018
 Brand Name: Trek
Product Name Is :Trek Precaliber 20 Girl's - 2018
 Brand Name: Trek
Product Name Is :Trek Precaliber 24 (7-Speed) - Boys - 2018
 Brand Name: Trek
Product Name Is :Trek Precaliber 24 21-speed Boy's - 2018
 Brand Name: Trek
Product Name Is :Trek Precaliber 24 21-speed Girl's - 2018
 Brand Name: Trek
Product Name Is :Trek Precaliber 24 7-speed Girl's - 2018
 Brand Name: Trek
Product Name Is :Trek Superfly 24 - 2017/2018
 Brand Name: Trek
Product Name Is :Electra Cruiser 7D (24-Inch) Ladies' - 2016/2018
 Brand Name: Electra
Product Name Is :Electra Cyclosaurus 1 (16-inch) - Boy's - 2018
 Brand Name: Electra
Product Name Is :Electra Heartchya 1 (20-inch) - Girl's - 2018
 Brand Name: Electra
Product Name Is :Electra Savannah 1 (20-inch) - Girl's - 2018
 Brand Name: Electra
Product Name Is :Electra Soft Serve 1 (16-inch) - Girl's - 2018
 Brand Name: Electra
Product Name Is :Electra Starship 1 16" - 2018
 Brand Name: Electra
Product Name Is :Electra Straight 8 1 (16-inch) - Boy's - 2018
 Brand Name: Electra
Product Name Is :Electra Straight 8 1 (20-inch) - Boy's - 2018
 Brand Name: Electra
Product Name Is :Electra Superbolt 1 20" - 2018
 Brand Name: Electra
Product Name Is :Electra Superbolt 3i 20" - 2018
 Brand Name: Electra
Product Name Is :Electra Sweet Ride 1 (20-inch) - Girl's - 2018
 Brand Name: Electra
Product Name Is :Electra Sweet Ride 3i (20-inch) - Girls' - 2018
 Brand Name: Electra
Product Name Is :Electra Tiger Shark 1 (20-inch) - Boys' - 2018
 Brand Name: Electra
Product Name Is :Electra Tiger Shark 3i (20-inch) - Boys' - 2018
 Brand Name: Electra
Product Name Is :Electra Treasure 1 20" - 2018
 Brand Name: Electra
Product Name Is :Electra Treasure 3i 20" - 2018
 Brand Name: Electra
Product Name Is :Electra Under-The-Sea 1 16" - 2018
 Brand Name: Electra
Product Name Is :Electra Water Lily 1 (16-inch) - Girl's - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Original 21D - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Balloon 3i EQ Ladies' - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Balloon 7i EQ - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Original 1 - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Go! 8i - 2017/2018
 Brand Name: Electra
Product Name Is :Electra Townie Original 21D EQ - 2017/2018
 Brand Name: Electra
Product Name Is :Electra Townie Balloon 3i EQ - 2017/2018
 Brand Name: Electra
Product Name Is :Electra Townie Balloon 7i EQ Ladies' - 2017/2018
 Brand Name: Electra
Product Name Is :Electra Townie Balloon 8D EQ - 2016/2017/2018
 Brand Name: Electra
Product Name Is :Electra Townie Balloon 8D EQ Ladies' - 2016/2017/2018
 Brand Name: Electra
Product Name Is :Electra Townie Commute 27D - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Commute 27D Ladies - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Commute 8D - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Commute 8D Ladies' - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Original 1 Ladies' - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Original 21D EQ Ladies' - 2018
 Brand Name: Electra
Product Name Is :Electra Townie Original 21D Ladies' - 2018
 Brand Name: Electra
Product Name Is :Trek Checkpoint ALR 4 Women's - 2019
 Brand Name: Trek
Product Name Is :Trek Checkpoint ALR 5 - 2019
 Brand Name: Trek
Product Name Is :Trek Checkpoint ALR 5 Women's - 2019
 Brand Name: Trek
Product Name Is :Trek Checkpoint SL 5 Women's - 2019
 Brand Name: Trek
Product Name Is :Trek Checkpoint SL 6 - 2019
 Brand Name: Trek
Product Name Is :Trek Checkpoint ALR Frameset - 2019
 Brand Name: Trek
             */
            #endregion

            #region Count the number of products in a specific category.
            Console.WriteLine("\n\nCount the number of products in a specific category.");

            Console.WriteLine("Enter the Category ID : ");
            int categoryId = Convert.ToInt32(Console.ReadLine());

            var CountProductInCategory = dbContext.Products.Where(p => p.CategoryId == categoryId).Count();

            Console.WriteLine($"Count of products in category {categoryId} is => {CountProductInCategory}");

            /*
             Count the number of products in a specific category.
             Enter the Category ID :
             4
             Count of products in category 4 is => 10
             */
            #endregion

            // note : ChatGPT helped me solve it
            #region Calculate the total list price of all products in a specific category
            Console.WriteLine("\n\nCalculate the total list price of all products in a specific category");

            var categoryPrices = dbContext.Products.GroupBy(p => p.CategoryId).Select(e => new
            { CategoryName = e.FirstOrDefault().Category.CategoryName, TotalPrice = e.Sum(p => p.ListPrice) }).ToList();

            foreach (var category in categoryPrices)
            {
                Console.WriteLine($"The Category: {category.CategoryName}, Total Price: {category.TotalPrice}");
            }

            /*
             the result :

                Calculate the total list price of all products in a specific category
The Category: Children Bicycles, Total Price: 16979.41
The Category: Comfort Bicycles, Total Price: 20463.70
The Category: Cruisers Bicycles, Total Price: 56972.16
The Category: Cyclocross Bicycles, Total Price: 25427.93
The Category: Electric Bikes, Total Price: 78759.76
The Category: Mountain Bikes, Total Price: 98985.44
The Category: Road Bikes, Total Price: 190521.44
             */

            #endregion


            #region Retrieve orders that are completed.
            Console.WriteLine("Retrieve orders that are completed.");

            var OrderComplet = dbContext.Orders.Where(o => o.OrderStatus == 2).ToList();

            foreach (var item in OrderComplet)
            {
                Console.WriteLine($"The Order completed is {item.OrderId} , {item.CustomerId} , {item.OrderStatus}");
            }

            /*
             Retrieve orders that are completed.
The Order completed is 1479 , 23 , 2
The Order completed is 1480 , 27 , 2
The Order completed is 1484 , 35 , 2
The Order completed is 1485 , 51 , 2
The Order completed is 1486 , 84 , 2
The Order completed is 1488 , 181 , 2
The Order completed is 1490 , 217 , 2
The Order completed is 1493 , 64 , 2
The Order completed is 1494 , 69 , 2
The Order completed is 1495 , 86 , 2
The Order completed is 1497 , 31 , 2
The Order completed is 1499 , 120 , 2
The Order completed is 1500 , 151 , 2
The Order completed is 1502 , 83 , 2
The Order completed is 1503 , 208 , 2
The Order completed is 1504 , 237 , 2
The Order completed is 1507 , 85 , 2
The Order completed is 1508 , 92 , 2
The Order completed is 1510 , 16 , 2
The Order completed is 1513 , 32 , 2
The Order completed is 1514 , 87 , 2
The Order completed is 1516 , 47 , 2
The Order completed is 1519 , 26 , 2
The Order completed is 1520 , 66 , 2
The Order completed is 1525 , 38 , 2
The Order completed is 1526 , 59 , 2
The Order completed is 1527 , 13 , 2
The Order completed is 1532 , 7 , 2
The Order completed is 1533 , 28 , 2
The Order completed is 1534 , 18 , 2
The Order completed is 1535 , 19 , 2
The Order completed is 1536 , 34 , 2
The Order completed is 1538 , 79 , 2
The Order completed is 1541 , 10 , 2
The Order completed is 1542 , 58 , 2
The Order completed is 1546 , 91 , 2
The Order completed is 1553 , 30 , 2
The Order completed is 1556 , 4 , 2
The Order completed is 1557 , 121 , 2
The Order completed is 1559 , 42 , 2
The Order completed is 1561 , 65 , 2
The Order completed is 1563 , 77 , 2
The Order completed is 1565 , 60 , 2
The Order completed is 1567 , 89 , 2
The Order completed is 1568 , 192 , 2
The Order completed is 1569 , 29 , 2
The Order completed is 1570 , 54 , 2
The Order completed is 1573 , 24 , 2
The Order completed is 1575 , 224 , 2
The Order completed is 1576 , 12 , 2
The Order completed is 1578 , 93 , 2
The Order completed is 1579 , 104 , 2
The Order completed is 1580 , 191 , 2
The Order completed is 1581 , 188 , 2
The Order completed is 1584 , 109 , 2
The Order completed is 1587 , 231 , 2
The Order completed is 1589 , 40 , 2
The Order completed is 1591 , 165 , 2
The Order completed is 1592 , 6 , 2
The Order completed is 1595 , 71 , 2
The Order completed is 1596 , 21 , 2
The Order completed is 1598 , 239 , 2
The Order completed is 1603 , 74 , 2
             */
            #endregion
        }
    }
}
