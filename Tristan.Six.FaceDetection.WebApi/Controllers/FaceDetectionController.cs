namespace Tristan.Six.FaceDetection.WebApi.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]

public class FaceDetectionController : ControllerBase
{
    private readonly FaceDetection _faceDetection;

    public FaceDetectionController(Six.FaceDetection.FaceDetection faceDetection)
    {
        _faceDetection = faceDetection;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> OnPostUploadAsync(List<IFormFile> files)
    {
        if (files.Count != 1)
            return BadRequest();
        using var sceneSourceStream = files[0].OpenReadStream();
        using var sceneMemoryStream = new MemoryStream();
        sceneSourceStream.CopyTo(sceneMemoryStream);
        var imageSceneData = sceneMemoryStream.ToArray();

        // La méthode ci-dessous permet de retourner une image depuis un tableau de bytes
        var imageData = new byte[imageSceneData.Length];

        for (int i = 0; i < imageData.Length; i++)
        {
            imageData[i] = imageSceneData[i];
        }
        imageData = imageSceneData;
        return File(imageData, "image/png");
    }
}