public class AttendanceService
{
    private readonly Dictionary<int, List<string>> attendees = new();

    public void Register(int eventId, string name)
    {
        if (!attendees.ContainsKey(eventId))
            attendees[eventId] = new List<string>();

        attendees[eventId].Add(name);
    }

    public List<string> GetAttendees(int eventId)
    {
        return attendees.ContainsKey(eventId) ? attendees[eventId] : new List<string>();
    }
}
