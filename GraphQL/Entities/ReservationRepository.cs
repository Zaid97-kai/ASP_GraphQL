using Microsoft.EntityFrameworkCore;

namespace GraphQL.Entities;

public class ReservationRepository
{
    private readonly MyHotelDbContext _myHotelDbContext;

    public ReservationRepository(MyHotelDbContext myHotelDbContext)
    {
        _myHotelDbContext = myHotelDbContext;
    }
    
    public async Task<IEnumerable<Reservation>> GetAll()
    {
        return await _myHotelDbContext
            .Reservations
            .Include(x => x.Room)
            .Include(x => x.Guest)
            .ToListAsync();
    }
}