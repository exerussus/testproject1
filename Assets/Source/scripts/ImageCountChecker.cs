
using UnityEngine.Networking;

public class ImageCountChecker
{
    public static int GetImagesCount(string url)
    {
        var www = UnityWebRequest.Get(url);
        var isError = false;
        var imageCount = 0;
        while (!isError)
        {
            if (www.result is UnityWebRequest.Result.ConnectionError or UnityWebRequest.Result.ProtocolError)
            {
                break;
            }
            imageCount += 1;
        }
        return imageCount;
    }
}