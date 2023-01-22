using GraphQL.Entities;

namespace GraphQL.Dto;

public class ReservationModel
{ 
    public int Id { get; set; }

    public Room Room { get; set; }

    public Guest Guest { get; set; }

    public DateTime CheckinDate { get; set; }
    
    public DateTime CheckoutDate { get; set; }
}