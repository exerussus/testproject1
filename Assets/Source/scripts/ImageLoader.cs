using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class ImageLoader : MonoBehaviour
{
    [SerializeField] private Image _image;
    public void LoadImage(string imageUrl)
    {
        StartCoroutine(LoadImageCoroutine(imageUrl));
    }
    
    private IEnumerator LoadImageCoroutine(string imageUrl)
    {
        var www = new WWW(imageUrl);
        yield return www;
        var texture = www.texture;
        var sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
        _image.sprite = sprite;
    }
}
