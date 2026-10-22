public class Vehicle : IReportable
{
    public int Id { get; }
    public double BatteryKWh { get; }
    public double CurrentKWh { get; private set; }

    public double Percent =>
        BatteryKWh == 0 ? 0 :
        CurrentKWh / BatteryKWh * 100;

    public Vehicle(int id, double batteryKWh)
    {
        Id = id;
        BatteryKWh = batteryKWh;
        CurrentKWh = 0;
    }

    public string GetReport()
    {
        return $"Bil {Id}: {Percent:0} %";
    }
}