
using System;
using UnityEngine;

public class ImageCreator : MonoBehaviour
{
    [SerializeField] private string _imagesUrl;
    [SerializeField] private GameObject _conteiner;
    [SerializeField] private GameObject _imagePrefub;

    public Action OnCreated;
    
    private void Start()
    {
         Create();
    }

    [Obsolete("Obsolete")]
    private void Create()
    {
        var imagesCount = 66; //ImageCountChecker.GetImagesCount(_imagesUrl);
        for (int i = 1; i <= imagesCount; i++)
        {
            var imageUrl = _imagesUrl + i + ".jpg";
            GameObject newImageButton = Instantiate(_imagePrefub, _conteiner.transform);
            var imageLoader = newImageButton.GetComponent<ImageLoader>();
            imageLoader.imageUrl = imageUrl;
        }
        OnCreated?.Invoke();
    }
}
