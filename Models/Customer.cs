using System.ComponentModel.DataAnnotations;

namespace apbd12_cw6.Models;

public class Customer
{
    [Key]
    public int CustomerId { get; set; }
    
    [Required, StringLength(50)]
    public string FirstName { get; set; }
    
    [Required, StringLength(100)]
    public string LastName { get; set; }
    
    public string? PhoneNumber { get; set; }
    
    public ICollection<Purchased_Ticket> Tickets { get; set; }
}