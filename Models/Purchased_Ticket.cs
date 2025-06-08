using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apbd12_cw6.Models;

public class Purchased_Ticket
{
    [Required]
    public int TicketConcertId { get; set; }
    
    [ForeignKey("TicketConcertId")]
    public Ticket_Concert TicketConcert { get; set; }
    
    [Required]
    public int CustomerId { get; set; }
    
    [ForeignKey("CustomerId")]
    public Customer Customer { get; set; }
    
    [Required]
    public DateOnly PurchaseDate { get; set; }
}