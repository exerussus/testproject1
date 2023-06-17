using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Button = UnityEngine.UIElements.Button;


public class ImageLoader : MonoBehaviour
{
    [SerializeField] private Image _image;
    private Button _button;
    private string _imageUrl;

    private void Start()
    {
        _imageUrl = "http://data.ikppbb.com/test-task-unity-data/pics/33.jpg";
        LoadImage();
    }
    
    private void LoadImage()
    {
        StartCoroutine(LoadImageCoroutine());
    }
    
    private IEnumerator LoadImageCoroutine()
    {
        var www = new WWW(_imageUrl);
        yield return www;
        var texture = www.texture;
        var sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
        _image.sprite = sprite;
    }
}
