namespace BabyTracker.Models;

public class BabyEvent
{
    public int Id { get; set; }
    public int? MilkAmount { get; set; }
    public int? FoodAmount {get; set;} 
    public bool? Poop {get; set;}  
    public string? Notes { get; set; }
    public DateTime OccurredAt { get; set; } = DateTime.UtcNow;
    public int BabyId { get; set; }
    public Baby Baby { get; set; } = null!;
    
}
