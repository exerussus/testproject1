using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class ImageLoader : MonoBehaviour
{
    [SerializeField] private Image _image;
    public string imageUrl;
    public bool IsLoaded { get; private set; } = false;
    public Action OnLoaded;
    
    [Obsolete("Obsolete")]
    public void LoadImage()
    {
        if (!IsLoaded && imageUrl != null)
        {
            StartCoroutine(LoadImageCoroutine());
        }
    }
    
    [Obsolete("Obsolete")]
    private IEnumerator LoadImageCoroutine()
    {
        var www = new WWW(imageUrl);
        yield return www;
        var texture = www.texture;
        var sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
        _image.sprite = sprite;
        IsLoaded = true;
        LoadHandler.Unload();
        OnLoaded?.Invoke();
    }
}
