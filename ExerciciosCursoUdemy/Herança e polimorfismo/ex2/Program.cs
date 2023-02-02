using ex2.Entities;
class Program
{
    public static void Main()
    {
        System.Console.Write("Enter the number of products: ");
        int products = int.Parse(System.Console.ReadLine());
        List<Product> productList = new List<Product>();

        for(int index = 0; index < products; index++){
            System.Console.WriteLine($"Product #{index} data: ");
            System.Console.Write("Common, used or imported (c/u/i) ?: ");
            char type = char.Parse(System.Console.ReadLine());
            System.Console.Write("Name: ");
            string name = System.Console.ReadLine();
            System.Console.Write("Price: ");
            double price = double.Parse(System.Console.ReadLine());
            Product product;
            if(type == 'i'){
                System.Console.Write("Customs fee: ");
                double fee = double.Parse(System.Console.ReadLine());
                product = new ImportedProduct(name, price, fee);                
                product = (ImportedProduct)product;
            }
            else if(type == 'u'){
                System.Console.Write("Manufacture date (DD/MM/YYYY): ");
                DateTime manufacture = DateTime.Parse(System.Console.ReadLine());
                product = new UsedProduct(name, price, manufacture);
                product = (UsedProduct)product;
            }
            else{
                product = new Product(name, price);
            }
            productList.Add(product);
        }
        System.Console.WriteLine("PRICE TAGS: ");
        foreach(Product item in productList)
        {
            System.Console.WriteLine(item.priceTag());
        }
    }
}
