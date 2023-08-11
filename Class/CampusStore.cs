namespace Persistencia_csharp.Class;

public class CampusStore
{
    private static List<Product> products = new List<Product>();
    private static List<Category> categories = new List<Category>();

    public List<Product> Products{
        get{ return products; }
        set{ products = value; }
    }
    public List<Category> Categories{
        get{ return categories; }
        set{ categories = value; }
    }

    public CampusStore()
    {
    }
}
