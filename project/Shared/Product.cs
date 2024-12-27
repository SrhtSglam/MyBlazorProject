namespace project.Shared;

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public List<ProductCategory> ProductCategories {get;set;}

}
