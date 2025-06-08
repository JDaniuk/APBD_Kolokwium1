using System.ComponentModel.DataAnnotations;

namespace apbd12_cw6.DTO;

public class GetPurchasesDTO
{
   
    [Required]
    public int CustomerId { get; set; }
    [Required]
    public int TicketConcertId { get; set; }
    [Required]
    public DateOnly PurchaseDate { get; set; }
    [Required]
    List<GetTicketConcertDTO> TicketConcerts { get; set; }
}

public class GetCustomerDTO
{

    [Required]
    public int CustomerId { get; set; }
    [Required]
    public string FirstName { get; set; }
    
    [Required]
    public string LastName { get; set; }
    
    [Required]
    List<GetPurchasesDTO> purchasedTickets;
    
}

public class GetTicketConcertDTO
{
    [Required]
    public int TicketConcertId { get; set; }
    [Required]
    public int TicketId { get; set; }
    [Required]
    public int ConcertId { get; set; }
    
    [Required]
    public double Price { get; set; }
    
    [Required]
    public List<GetConcertDTO> Concerts { get; set; }
    [Required]
    public List<GetTicketDTO> Tickets { get; set; }
}

public class GetTicketDTO
{
    [Required]
    public int TicketId { get; set; }
    [Required]
    public String SerialNumber { get; set; }
    [Required]
    public int SeatNumber { get; set; }
    
}

public class GetConcertDTO
{
    [Required]
    public int ConcertId { get; set; }
    [Required]
    public String Name { get; set; }
    [Required]
    public DateOnly Date { get; set; }
}