
using System.Net;
using System.Text.RegularExpressions;
using UnityEngine;

public class ImageCountChecker
{
    public static int GetJpgCount(string url)
    {
        int count = 0;
        using (WebClient client = new WebClient())
        {
            string htmlCode = client.DownloadString(url);
            Regex regex = new Regex(@"<a[^>]*?href=(['""])(.*)/test-task-unity-data/pics/[\w]+\.jpg\1");
            MatchCollection matches = regex.Matches(htmlCode);

            count = matches.Count; 
        }
        Debug.Log(count);
        return count;
    }
}