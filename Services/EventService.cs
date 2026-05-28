using EventEase.Models;

public class EventService
{
    public List<Event> GetEvents()
    {
        return Enumerable.Range(1, 50).Select(i => new Event
        {
            Id = i,
            Name = $"Event {i}",
            Date = DateTime.Now.AddDays(i),
            Location = "Tallinn"
        }).ToList();
    }
}
