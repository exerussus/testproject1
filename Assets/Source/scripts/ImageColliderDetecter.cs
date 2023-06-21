
using System;
using UnityEngine;

public class ImageColliderDetecter : MonoBehaviour
{
    public Action<Collider2D> OnDetected;
    private void OnTriggerStay2D(Collider2D other)
    {
            OnDetected?.Invoke(other);
    }
}
