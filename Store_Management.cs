/* 
MSSV: 218802**
Nhập môn lập trình K2-2022-2023 (12/2022-04/2023)
*/
// Hàm Search Item sử dụng LINQ
static void SearchItem()
{
    Console.WriteLine("Search for a product by code, name, or manufacturing company:");

    string searchTerm = Console.ReadLine().ToLower();

    var matchingProducts = products.Where(p =>
        p.code.ToString().Contains(searchTerm) ||
        p.name.ToLower().Contains(searchTerm) ||
        p.manufacturingCompany.ToLower().Contains(searchTerm)
    );

    if (matchingProducts.Any())
    {
        Console.WriteLine("Found {0} product(s):", matchingProducts.Count());

        foreach (var product in matchingProducts)
        {
            Console.WriteLine("Code: {0}", product.code);
            Console.WriteLine("Name: {0}", product.name);
            Console.WriteLine("Expiry date: {0}", product.expiryDate.ToString("dd/MM/yyyy"));
            Console.WriteLine("Manufacturing company: {0}", product.manufacturingCompany);
            Console.WriteLine("Production year: {0}", product.productionYear);
            Console.WriteLine("Product type: {0}", product.productType);
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("No products found.");
    }
}

// Hàm Search Item không sử dụng LINQ
static void SearchItem()
{
    Console.WriteLine("Search for a product by code, name, or manufacturing company:");
    string searchTerm = Console.ReadLine().ToLower();
    bool foundMatch = false;

    foreach (var product in products)
    {
        if (product.code.ToString().Contains(searchTerm) ||
            product.name.ToLower().Contains(searchTerm) ||
            product.manufacturingCompany.ToLower().Contains(searchTerm))
        {
            Console.WriteLine("Code: {0}", product.code);
            Console.WriteLine("Name: {0}", product.name);
            Console.WriteLine("Expiry date: {0}", product.expiryDate.ToString("dd/MM/yyyy"));
            Console.WriteLine("Manufacturing company: {0}", product.manufacturingCompany);
            Console.WriteLine("Production year: {0}", product.productionYear);
            Console.WriteLine("Product type: {0}", product.productType);
            Console.WriteLine();
            foundMatch = true;
        }
    }

    if (!foundMatch)
    {
        Console.WriteLine("No products found.");
    }
}
