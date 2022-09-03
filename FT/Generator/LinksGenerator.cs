namespace FT.Generator;

public class LinksGenerator
{
    private static readonly List<Link> Links = new()
    {
        new Link {Product = 1, ParentProduct = 0, Quantity = 1},
        new Link {Product = 7, ParentProduct = 0, Quantity = 1},

        new Link {Product = 2, ParentProduct = 1, Quantity = 11},
        new Link {Product = 3, ParentProduct = 1, Quantity = 3},
        new Link {Product = 4, ParentProduct = 1, Quantity = 12},

        new Link {Product = 4, ParentProduct = 3, Quantity = 8},

        new Link {Product = 2, ParentProduct = 4, Quantity = 16},
        new Link {Product = 6, ParentProduct = 4, Quantity = 14},

        new Link {Product = 8, ParentProduct = 7, Quantity = 10},
        new Link {Product = 3, ParentProduct = 7, Quantity = 3},
    };

    // В данный метод можно вставить любоую логику получения данных о продукте
    // К примеру из базы данных и ef
    public static IEnumerable<Link> Create()
    {
        return Links;
    }

}