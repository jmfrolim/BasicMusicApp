public class Episode
{
    private List<string> _guests = new();
    public int Duration { get; set; }
    public int Order { get; set; }
    public string Summary => $"{Order}.{Title} ({Duration} min) e Convidados: {string.Join(",",_guests)}";
    //
    //{string.Join(", ", convidados)}
    public string Title { get; set; }
    public Episode(int duration,int order, string title)
    {
        Duration = duration;
        Order = order;
        Title = title;
    }

    public void AddGuests(string guest)
    {
        _guests.Add(guest);
    }
}
