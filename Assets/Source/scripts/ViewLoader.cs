
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ViewLoader : MonoBehaviour
{
    [SerializeField] private Image _iamge;
    [SerializeField] private ImageHandler _imageHandler;

    private void Start()
    {
        _iamge.sprite = _imageHandler.LoadSprite();
    }
}
