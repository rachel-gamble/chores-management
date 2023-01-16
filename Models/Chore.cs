namespace choresmanagement.Models;

public class Chore
{
    public Chore(int id, string name, int minutes, int timesperweek, bool completed)
    {
        Id = id;
        Name = name;
        Minutes = minutes;
        TimesPerWeek = timesperweek;
        Completed = completed;

    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int Minutes { get; set; }
    public int TimesPerWeek { get; set; }
    public bool Completed { get; set; }


}