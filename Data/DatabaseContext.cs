using apbd12_cw6.Models;
using Microsoft.EntityFrameworkCore;

namespace apbd12_cw6.Data;

public class DatabaseContext : DbContext
{
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Ticket_Concert> TicketConcerts { get; set; }
    public DbSet<Concert> Concerts { get; set; }
    public DbSet<Purchased_Ticket> PurchasedTickets { get; set; }
    public DbSet<Customer> Customers { get; set; }


    protected DatabaseContext() {}
    
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().HasData(new List<Customer>()
            {
                new Customer() {CustomerId = 1, FirstName = "Jakub", LastName = "Daniuk", PhoneNumber = "123456788"},
                new Customer() {CustomerId = 2, FirstName = "Jan", LastName = "Nowak"},
            });

        modelBuilder.Entity<Ticket>().HasData(new List<Ticket>()
        {
            new Ticket(){TicketID = 1, SerialNumber = "aaa01", SeatNumber = 1},
            new Ticket(){TicketID = 2, SerialNumber = "aaa02", SeatNumber = 2},
        });

        modelBuilder.Entity<Ticket>().HasData(new List<Ticket_Concert>()
        {
            
            new Ticket_Concert(){TickedConcertId = 1,TicketId = 1,ConcertId = 1, Price = 10.5},
            new Ticket_Concert(){TickedConcertId = 2,TicketId = 2,ConcertId = 2, Price = 20.5}
           });

        modelBuilder.Entity<Concert>().HasData(new List<Concert>()
        {
            new Concert(){ConcertId = 1, Name = "ACDC", Date = DateOnly.Parse("09.05.2020"), AvailableTickets = 100},
            new Concert(){ConcertId = 2, Name = "Black Sabath", Date = DateOnly.Parse("09.05.2020"), AvailableTickets = 100},
        });

        modelBuilder.Entity<Purchased_Ticket>().HasData(new List<Purchased_Ticket>()
        {
            new Purchased_Ticket(){CustomerId = 1, TicketConcertId = 1, PurchaseDate = DateOnly.Parse("09.05.2020")},
            new Purchased_Ticket(){CustomerId = 2, TicketConcertId = 2, PurchaseDate = DateOnly.Parse("09.05.2020")}
        });
        
        modelBuilder.Entity<Purchased_Ticket>()
            .HasKey(p => new { p.TicketConcertId, p.CustomerId });
        
  
    }
    
    
}