using System.ComponentModel.DataAnnotations;

namespace apbd12_cw6.Models;

public class Concert
{
    [Key]
    public int ConcertId { get; set; }
    
    [Required, StringLength(100)]
    public string Name { get; set; }
    
    [Required]
    public DateOnly Date { get; set; }
    
    [Required]
    public int AvailableTickets { get; set; }
    
    
    public ICollection<Ticket_Concert> Tickets { get; set; }
}