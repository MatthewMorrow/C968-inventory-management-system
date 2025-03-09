using System.ComponentModel;
using System.Linq;

public class Inventory
{
    public BindingList<Product> Products { get; set; } = new BindingList<Product>();
    public BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public bool RemoveProduct(int id)
    {
        Product productToRemove = LookupProduct(id);
        if (productToRemove != null)
        {
            return Products.Remove(productToRemove);
        }
        return false;
    }

    public Product LookupProduct(int id)
    {
        return Products.FirstOrDefault(p => p.ProductID == id);
    }

    public void UpdateProduct(int id, Product product)
    {
        var index = Products.IndexOf(Products.FirstOrDefault(p => p.ProductID == id));
        if (index >= 0)
        {
            Products[index] = product;
        }
    }

    public void AddPart(Part part)
    {
        AllParts.Add(part);
    }

    public bool DeletePart(Part part)
    {
        return AllParts.Remove(part);
    }

    public Part LookupPart(int id)
    {
        return AllParts.FirstOrDefault(p => p.PartID == id);
    }

    public void UpdatePart(int id, Part part)
    {
        var index = AllParts.IndexOf(AllParts.FirstOrDefault(p => p.PartID == id));
        if (index >= 0)
        {
            AllParts[index] = part;
        }
    }
}