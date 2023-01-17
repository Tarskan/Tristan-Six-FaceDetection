// See https://aka.ms/new-console-template for more information

using System.Text.Json;

foreach (var detectionResult in detectFaceInScenesResults)
{
    System.Console.WriteLine($"Points" + $"{JsonSerializer.Serialize(detectionResult.Points)}");
} 
