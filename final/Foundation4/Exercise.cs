using System.ComponentModel;

abstract class Exercise
{
    protected string _date;
    protected int _minutes;
    protected double _distance;
    protected double _speed;
    protected double _pace;
    protected string _exerciseType;

    public Exercise(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance();
    public virtual void Calculate()
    {
        _distance = GetDistance();
        _speed = _distance / _minutes * 60;
        _pace = 60 / _speed;
    }
    public virtual string GetSummary()
    {
        Calculate();
        return $"{_date}, {_exerciseType}, ({_minutes} minutes) - Distance: {_distance} km, Pace: {_pace:F2} min per km";
        //     03 Nov 2022    Running        (30 min)           - Distance      3.0 miles,  Speed 6.0 mph,              Pace: 10.0 min per mile
    }
}

// Distance (km) = swimming laps * 50 / 1000
// Distance (miles) = swimming laps * 50 / 1000 * 0.62
// Speed (mph or kph) = (distance / minutes) * 60
// Pace (min per mile or min per km)= minutes / distance
// Speed = 60 / pace
// Pace = 60 / speed