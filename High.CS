using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Simulate high voltage occurrence
        SimulateHighVoltage();

        // Check for high voltage
        CheckForHighVoltage();
    }

    static void SimulateHighVoltage()
    {
        Console.WriteLine("Simulating high voltage occurrence...");
        // Simulate a delay
        Thread.Sleep(2000);
    }

    static void CheckForHighVoltage()
    {
        Random random = new Random();
        int voltageLevel = random.Next(100, 300); // Simulate voltage level (random between 100V and 300V)

        if (voltageLevel > 200)
        {
            Console.WriteLine("Warning: High Voltage Detected!");
            Console.WriteLine($"Voltage Level: {voltageLevel}V");
            Console.WriteLine("Take necessary precautions to avoid electric shock.");
        }
        else
        {
            Console.WriteLine("Voltage level is within normal range.");
        }
    }
}
