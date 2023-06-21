
using UnityEngine;

public class ImageColliderDetecter : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (LoadHandler.CanBeLoaded)
        {
            var imageLoader = other.GetComponent<ImageLoader>();
            LoadHandler.Load(imageLoader);
        }
    }
}
