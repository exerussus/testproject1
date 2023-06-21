
using UnityEngine;

public class LoadDistributer : MonoBehaviour
{
    [SerializeField] private LoadHandler _loadHandler;
    [SerializeField] private ImageLoader _imageLoader;
    [SerializeField] private ImageColliderDetecter _imageColliderDetecter;

    public void SetItems(LoadHandler loadHandler, ImageColliderDetecter imageColliderDetecter)
    {
        _loadHandler = loadHandler;
        _imageColliderDetecter = imageColliderDetecter;
        enabled = true;
    }
    
    private void OnEnable()
    {
        _imageColliderDetecter.OnDetected += SendToLoad;
        _imageLoader.OnLoaded += ReduceLoad;
    }

    private void OnDisable()
    {
        _imageColliderDetecter.OnDetected -= SendToLoad;
        _imageLoader.OnLoaded -= ReduceLoad;
    }

    private void SendToLoad(Collider2D collider2D)
    {
        if (_loadHandler.CanBeLoaded)
        {
            collider2D.enabled = false;
            var imageLoader = collider2D.GetComponent<ImageLoader>();
            _loadHandler.Load(imageLoader);
        }
    }

    private void ReduceLoad()
    {
        _loadHandler.Unload();
    }
}
