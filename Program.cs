using System;
using System.Collections.Generic;

List<IReportable> reports = new List<IReportable>
{
    new Vehicle(1, 75),
    new ChargingStation("AC-01", 11),
    new ChargingStation("DC-01", 150)
};

foreach (IReportable item in reports)
{
    Console.WriteLine(item.GetReport());
}Console.WriteLine("Test av laddstation:");

ChargingStation station = new ChargingStation("TEST-01", 11);

try
{
    station.StartCharging();
    Console.WriteLine("Första laddningen startade.");

    station.StartCharging();
    Console.WriteLine("Andra laddningen startade.");
}
catch (InvalidOperationException ex)
{
    Console.WriteLine("Förväntat fel: " + ex.Message);
}

station.StopCharging();
Console.WriteLine("Laddningen stoppades.");