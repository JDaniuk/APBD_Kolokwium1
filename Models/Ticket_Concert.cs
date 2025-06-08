using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apbd12_cw6.Models;

public class Ticket_Concert
{
    [Key]
    public int TickedConcertId { get; set; }
    
    [Required]
    public int TicketId { get; set; }
    
    [ForeignKey("TicketId")]
    public Ticket Ticket { get; set; }
    
    [Required]
    public int ConcertId { get; set; }
    
    [ForeignKey("ConcertId")]
    public Concert Concert { get; set; }
    
    [Required]
    public double Price { get; set; }
    
    public ICollection<Purchased_Ticket> Purchased_Tickets { get; set; }
}