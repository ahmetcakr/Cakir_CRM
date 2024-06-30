namespace CRM.Domain.Entities;

public class Companies 
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public int TypeId { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Website { get; set; }
    public virtual CompanyTypes CompanyTypes { get; set; }

    public Companies()
    {
        Id = 0;
        CompanyName = string.Empty;
        TypeId = 0;
        Address = string.Empty;
        Phone = string.Empty;
        Email = string.Empty;
        Website = string.Empty;
    }

    public Companies(int id, string companyName, int typeId, string address, string phone, string email, string website)
    {
        Id = id;
        CompanyName = companyName;
        TypeId = typeId;
        Address = address;
        Phone = phone;
        Email = email;
        Website = website;
    }


}
