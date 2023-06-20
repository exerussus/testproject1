
using UnityEngine;

public class ImageColliderDetecter : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (LoadHandler.CanBeLoaded)
        {
            LoadHandler.Load();
            var imageLoader = other.GetComponent<ImageLoader>();
            imageLoader.LoadImage();
        }
    }
}
