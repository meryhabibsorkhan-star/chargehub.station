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
}