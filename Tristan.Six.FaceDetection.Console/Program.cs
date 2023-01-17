// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using Tristan.Six.FaceDetection;

IList<byte[]> imagesData = new List<byte[]>();
IList<FaceDetectionResult> detectFaceInScenesResults = new List<FaceDetectionResult>();

if (args.Length == 0)
{
    System.Console.WriteLine("Il faut donner le path des images !");
}
else
{
    for (int i = 0; i < args.Length; i++)
    {
        try
        {
            var imageData = await File.ReadAllBytesAsync(args[i]);
            imagesData.Add(imageData);
        }
        catch (FileNotFoundException e)
        {
            System.Console.WriteLine("Le fichier " + e.FileName + " n'existe pas !");
        }
    }
}

foreach (var detectionResult in detectFaceInScenesResults)
{ 
    System.Console.WriteLine($"Points" + $"{JsonSerializer.Serialize(detectionResult.Points)}");
}