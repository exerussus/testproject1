
using UnityEngine;

[CreateAssetMenu(fileName = "ImgHandler", menuName = "ImageHandlerSO")]
public class ImageHandler : ScriptableObject
{
    private Sprite _sprite;

    public void SaveSprite(Sprite sprite)
    {
        _sprite = sprite;
    }

    public Sprite LoadSprite()
    {
        return _sprite;
    }
}
