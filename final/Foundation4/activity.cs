using System;

public abstract class Activity
{
    private DateTime date;
    private int minutes;

    public DateTime Date { get => date; set => date = value; }
    public int Minutes { get => minutes; set => minutes = value; }

    public Activity(DateTime date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public abstract double GetDistance(); // distance in miles or km
    public abstract double GetSpeed(); // speed in mph or kph
    public abstract double GetPace(); // pace in min per mile or km

    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} - {Minutes} min: Distance {GetDistance():0.0}, Speed {GetSpeed():0.0}, Pace: {GetPace():0.0}";
    }
}
