
using UnityEngine;

public class ImageCreator : MonoBehaviour
{
    [SerializeField] private string _imagesUrl;
    [SerializeField] private GameObject _conteiner;
    [SerializeField] private RectTransform _conteinerRectTransform;
    [SerializeField] private GameObject _imagePrefub;

    private void Start()
    {
        Create();
    }

    private void Create()
    {
        var imagesCount = 66; //ImageCountChecker.GetImagesCount(_imagesUrl);
        for (int i = 1; i <= imagesCount; i++)
        {
            var imageUrl = _imagesUrl + i + ".jpg";
            GameObject newImageButton = Instantiate(_imagePrefub, _conteiner.transform);
            var imageLoader = newImageButton.GetComponent<ImageLoader>();
            imageLoader.LoadImage(imageUrl);
            _conteinerRectTransform.sizeDelta = new Vector2(_conteinerRectTransform.sizeDelta.x, 
                _conteinerRectTransform.rect.height + 203);
        }
    }
}
