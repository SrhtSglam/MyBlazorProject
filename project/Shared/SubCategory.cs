namespace project.Shared;

public class SubCategory
{
    public int SubCategoryId { get; set; }
    public string Name { get; set; }
    public List<ProductCategory> ProductCategories {get;set;}
}
