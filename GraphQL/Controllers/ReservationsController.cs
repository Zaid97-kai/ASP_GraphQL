using GraphQL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GraphQL.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReservationsController : ControllerBase
{
    private readonly ReservationRepository _reservationRepository;

    public ReservationsController(ReservationRepository reservationRepository)
    {
        _reservationRepository = reservationRepository;
    }

    [HttpGet("[action]")]
    public async Task<IEnumerable<Reservation>> List()
    {
        var list = await _reservationRepository.GetAll();
        return list;
    }
}