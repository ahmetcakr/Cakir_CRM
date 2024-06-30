namespace CRM.Domain.Entities;

public class CompanyTypes
{
    public int Id { get; set; }
    public string TypeName { get; set; }
    public string Description { get; set; }

    public CompanyTypes()
    {
        Id = 0;
        TypeName = string.Empty;
    }

    public CompanyTypes(int id, string typeName, string description)
    {
        Id = id;
        TypeName = typeName;
        Description = description;
    }
}
