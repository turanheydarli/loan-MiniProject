namespace Loan.DataAccess.Models;

public class Address : BaseEntity
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
}