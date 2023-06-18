
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImageSaver : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private ImageHandler _imageHandler;
    
    public void SaveImage()
    {
        _imageHandler.SaveSprite(_image.sprite);
        SceneManager.LoadScene(SceneConstant.View);
    }
}
