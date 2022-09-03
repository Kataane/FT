namespace FT.Generator;

public static class ProductGenerator
{
    private static readonly List<Product> Products = new()
    {
        new Product { Id = 1, Name = "Product 1", Price = 10 },
        new Product { Id = 2, Name = "Product 2", Price = 20 },
        new Product { Id = 3, Name = "Product 3", Price = 30 },
        new Product { Id = 4, Name = "Product 4", Price = 40 },
        new Product { Id = 5, Name = "Product 5", Price = 50 },
        new Product { Id = 6, Name = "Product 6", Price = 60 },
        new Product { Id = 7, Name = "Product 7", Price = 70 },
        new Product { Id = 8, Name = "Product 8", Price = 80 },
    };

    // В данный метод можно вставить любоую логику получения данных о продукте
    // К примеру из базы данных и ef
    public static IEnumerable<Product> Create()
    {
        return Products;
    }
}