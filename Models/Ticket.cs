using System.ComponentModel.DataAnnotations;

namespace apbd12_cw6.Models;

public class Ticket
{
    [Key]
    public int TicketID { get; set; }
   [Required, StringLength(50)]
   public string SerialNumber { get; set; }
   [Required]
   public int SeatNumber { get; set; }
   
  public ICollection<Ticket_Concert> TicketConcerts { get; set; } 
   
}