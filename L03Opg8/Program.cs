using System;

struct Time
{
    // privat felt til at gemme antal sekunder siden midnat
    private int _secondsSinceMidnight;
    private const int _maxSeconds = 24 * 3600; // antal sekunder i et døgn

    // property til timer
    public int Hour
    {
        set
        {
            int hour = value;
            // beholder sekunder og opdaterer timer
            int temp = _secondsSinceMidnight % 3600;
            _secondsSinceMidnight = (temp + hour * 3600) % _maxSeconds;
        }
        get { return _secondsSinceMidnight / 3600; }
    }

    // property til minutter
    public int Min
    {
        set
        {
            int min = value;
            int temp = _secondsSinceMidnight % 60; // beholder sekunder
            int hoursInSeconds = (Hour * 3600);    // gemmer timerne
            _secondsSinceMidnight = hoursInSeconds + (min * 60) + temp;
        }
        get { return (_secondsSinceMidnight % 3600) / 60; }
    }

    // property til sekunder
    public int Sek
    {
        set
        {
            int sec = value;
            int hoursAndMinutesInSeconds = (Hour * 3600) + (Min * 60);
            _secondsSinceMidnight = hoursAndMinutesInSeconds + sec;
        }
        get { return _secondsSinceMidnight % 60; }
    }

    // constructor som tager en string i formatet "hh:mm:ss"
    public Time(string time)
    {
        var parts = time.Split(':');
        int hour = Int32.Parse(parts[0]);
        int min = Int32.Parse(parts[1]);
        int sec = Int32.Parse(parts[2]);
        _secondsSinceMidnight = (hour * 3600) + (min * 60) + sec;
    }

    // constructor som tager 3 int parametre (timer, minutter og sekunder)
    public Time(int hour, int min, int sec)
    {
        _secondsSinceMidnight = (hour * 3600) + (min * 60) + sec;
    }

    // override ToString() for at returnere tiden i formatet "hh:mm:ss"
    public override string ToString()
    {
        return $"{Hour:D2}:{Min:D2}:{Sek:D2}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Time t1, t2;
        t1 = new Time("08:30:00");
        t2 = t1;
        t2.Hour = t2.Hour + 2;
        Console.WriteLine(t1.ToString()); // bør skrive 08:30:00
        Console.WriteLine(t2.ToString()); // bør skrive 10:30:00
        Console.ReadLine();
    }
}
