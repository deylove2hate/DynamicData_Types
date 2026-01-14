namespace DynamicData.Web.Config.After.Models;

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ProductNumber { get; set; } = string.Empty;
    public decimal StandardCost { get; set; }
    public decimal ListPrice { get; set; }
}