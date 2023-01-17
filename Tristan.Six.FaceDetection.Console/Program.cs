// See https://aka.ms/new-console-template for more information

using System.Text.Json;

static void Main(string[] args)
{
    foreach (var detectionResult in detectFaceInScenesResults)
    {
        System.Console.WriteLine($"Points" + $"{JsonSerializer.Serialize(detectionResult.Points)}");
    }
}