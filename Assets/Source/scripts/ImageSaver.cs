
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImageSaver : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private ImageHandler _imageHandler;
    [SerializeField] private ImageLoader _imageLoader;
    
    public void SaveImage()
    {
        if (_imageLoader.IsLoaded)
        {
            _imageHandler.SaveSprite(_image.sprite);
            SceneManager.LoadScene(SceneConstant.View);
        }
    }
}
