using System.ComponentModel.DataAnnotations;

namespace GraphQL.Entities;

public class Room
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int Number { get; set; }

    [StringLength(200)]
    public string Name { get; set; }

    [Required]
    public RoomStatus Status { get; set; }

    public bool AllowedSmoking { get; set; }

    public Room()
    {

    }
    s
    public Room(int number, string name, RoomStatus status, bool allowedSmoking)
    {
        Number = number;
        Name = name;
        Status = status;
        AllowedSmoking = allowedSmoking;
    }
}