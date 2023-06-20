
using UnityEngine;

public class ColliderOffer : MonoBehaviour
{
    [SerializeField] private Collider2D _collider2D;
    [SerializeField] private ImageLoader _imageLoader;

    private void OnEnable()
    {
        _imageLoader.OnLoaded += ColliderDisable;
    }
    private void OnDisable()
    {
        _imageLoader.OnLoaded -= ColliderDisable;
    }

    private void ColliderDisable()
    {
        _collider2D.enabled = false;
    }
}
