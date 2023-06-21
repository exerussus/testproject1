using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


public class ImageLoader : MonoBehaviour
{
    [SerializeField] private Image _image;
    public string imageUrl;
    public bool IsLoaded { get; private set; } = false;
    public Action OnLoaded;
    
    public void LoadImage()
    {
        if (!IsLoaded && imageUrl != null)
        {
            StartCoroutine(LoadImageCoroutine());
        }
    }
    

    private IEnumerator LoadImageCoroutine()
    {
        var www = UnityWebRequestTexture.GetTexture(imageUrl);
        yield return www.SendWebRequest();
        
        if (www.result != UnityWebRequest.Result.ConnectionError && 
            www.result != UnityWebRequest.Result.ProtocolError)
        {
            var texture = DownloadHandlerTexture.GetContent(www);
            var sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
            _image.sprite = sprite;
            IsLoaded = true;
            OnLoaded?.Invoke();
        }
    }
}
