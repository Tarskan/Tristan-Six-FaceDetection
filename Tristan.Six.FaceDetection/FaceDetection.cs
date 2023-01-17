using System.Reflection;
using OpenCvSharp;

namespace Tristan.Six.FaceDetection;

public class FaceDetection {
    
    public FaceDetectionResult DetectInScene(byte[] imageData)
    {
        return new FaceDetectionResult(imageData);
    }
    public IList<FaceDetectionResult> DetectInScenes(IList<byte[]> imagesSceneData) {
        IList<FaceDetectionResult> listImage = new List<FaceDetectionResult>();
        var jobs = new List<Task>();
        foreach (var image in imagesSceneData)
        {
            var task = Task.Run(() => listImage.Add(new FaceDetectionResult(image));
            jobs.Add(task);
        }

        Task.WaitAll(jobs.ToArray());

        return listImage;
    }
    
}


