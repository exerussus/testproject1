
using System;
using UnityEngine;

public class ImageCreator : MonoBehaviour
{
    [SerializeField] private string _imagesUrl;
    [SerializeField] private GameObject _conteiner;
    [SerializeField] private GameObject _imagePrefub;
    [SerializeField] private LoadHandler _loadHandler;
    [SerializeField] private ImageColliderDetecter _imageColliderDetecter;

    public Action OnCreated;
    
    private void Start()
    {
         Create();
    }
    
    private void Create()
    {
        var imagesCount = ImageCountChecker.GetJpgCount(_imagesUrl);
        for (int i = 1; i <= imagesCount; i++)
        {
            var imageUrl = _imagesUrl + i + ".jpg";
            GameObject newImageButton = Instantiate(_imagePrefub, _conteiner.transform);
            var imageLoader = newImageButton.GetComponent<ImageLoader>();
            imageLoader.imageUrl = imageUrl;
            var loadDistributer = newImageButton.GetComponent<LoadDistributer>();
            loadDistributer.SetItems(_loadHandler, _imageColliderDetecter);
        }
        OnCreated?.Invoke();
    }
}
