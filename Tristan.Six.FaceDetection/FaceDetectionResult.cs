using System.Reflection;
using OpenCvSharp;


namespace Tristan.Six.FaceDetection;

public record FaceDetectionResult
{
    public byte[] ImageData { get; set; }
    public IList<ObjectDetectionPoint> Points { get; set; }
}
public record ObjectDetectionPoint
{
    public double X { get; set; }
    public double Y { get; set; }
}