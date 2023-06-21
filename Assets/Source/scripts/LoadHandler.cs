
using System.Collections.Generic;
using UnityEngine;

public class LoadHandler : MonoBehaviour
{
    private static LoadHandler instance;
    
    private static int _actuallyLoad;
    private static int _maxLoad = 1;
    
    private static List<ImageLoader> _imageLoaderList = new List<ImageLoader>();
    public static bool CanBeLoaded => _actuallyLoad < _maxLoad;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        _actuallyLoad = 0;
    }

    public static void Load(ImageLoader imageLoader)
    {
        _imageLoaderList.Add(imageLoader);
    }

    public static void Unload()
    {
        _actuallyLoad = _actuallyLoad - 1 >= 0 ? _actuallyLoad -= 1 : 0;
    }

    private void Update()
    {
        if (_imageLoaderList.Count == 0) return;

        for (int i = _imageLoaderList.Count-1; i >= 0 ; i--)
        {
            var imageLoader = _imageLoaderList[i];
            if (imageLoader.IsLoaded) _imageLoaderList.Remove(imageLoader);
            else if (CanBeLoaded)
            {
                _actuallyLoad += 1;
                imageLoader.LoadImage();
            }
            else break;
        }
    }
}
