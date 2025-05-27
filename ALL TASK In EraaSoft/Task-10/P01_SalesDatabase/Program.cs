namespace P01_SalesDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Constraints, Using Fluent API
                Your namespaces should be:
                    •	P01_SalesDatabase – Project Name
                    •	Data – (New folder named Data) for your DbContext
                    •	Models – (New folder named Models) for your classes
                Your classes should be:
                    •	ApplicationDbContext  – your DbContext
                Product:
                    •	ProductId
                    •	Name (up to 50 characters, unicode)
                    •	Quantity (real number)
                    •	Price
                    •	Sales
                Customer:
                    •	CustomerId
                    •	Name (up to 100 characters, unicode)
                    •	Email (up to 80 characters, not unicode)
                    •	CreaditCardNumber (string)
                    •	Sales
                Store:
                    •	StoreId
                    •	Name (up to 80 characters, unicode)
                    •	Sales
                Sale:
                    •	SaleId
                    •	Product
                    •	Customer
                    •	Store
                  

                Migration :
                    Add new migration. The migration should be named: "InitialCreate" and run the project.
                Products Migration :
                    For table Products add string column Description, The migration should be named: "ProductsAddColumnDescription".
                
                // Important note: When I built the sales table from the beginning,
                I had added a coulom Date, so I deleted it first and then created it.
                Sales Migration :
                For table Sales Add Date column, Name the migration “SalesAddDateDefault”.
                
                Upload Projects : 
                Use GitHub to upload your project.

             */

        }
    }
}
