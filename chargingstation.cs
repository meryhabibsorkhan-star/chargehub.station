using System;

public class ChargingStation : IReportable
{
    public string Id { get; }
    public double MaxKw { get; }
    public bool IsAvailable { get; private set; } = true;

    public ChargingStation(string id, double maxKw)
    {
        if (maxKw <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(maxKw),
                "Effekten måste vara större än 0."
            );
        }

        Id = id;
        MaxKw = maxKw;
    }

    public void StartCharging()
    {
        if (!IsAvailable)
        {
            throw new InvalidOperationException(
                $"{Id} är upptagen."
            );
        }

        IsAvailable = false;
    }

    public void StopCharging()
    {
        IsAvailable = true;
    }

    public string GetReport()
    {
        return $"Station {Id}: {MaxKw} kW";
    }
}

