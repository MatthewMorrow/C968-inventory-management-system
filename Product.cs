using InventorySystem;
using System.ComponentModel;
using System.Linq;

public class Product
{
    public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();
    public int ProductID { get; set; }    
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int InStock { get; set; }
    public int Min { get; set; }
    public int Max { get; set; }

    public void AddAssociatedPart(Part part)
    {
        AssociatedParts.Add(part);
    }

    public bool RemoveAssociatedPart(int partId)
    {
        var part = LookupAssociatedPart(partId);
        if (part != null)
        {
            return AssociatedParts.Remove(part);
        }
        return false;
    }

    public Part LookupAssociatedPart(int partId)
    {
        return AssociatedParts.FirstOrDefault(p => p.PartID == partId);
    }
}