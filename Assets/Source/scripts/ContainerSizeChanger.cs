
using UnityEngine;

public class ContainerSizeChanger : MonoBehaviour
{
    [SerializeField] private RectTransform _conteinerRectTransform;
    [SerializeField] private FlexibleGridLayout _flexGridLayout;

    private void OnEnable()
    {
        _flexGridLayout.OnCalculated += SizeRecalculate;
    }
    private void OnDisable()
    {
        _flexGridLayout.OnCalculated -= SizeRecalculate;
    }

    private void SizeRecalculate(float maxSize)
    {
        _conteinerRectTransform.sizeDelta = new Vector2(
            _conteinerRectTransform.sizeDelta.x, maxSize - _flexGridLayout.ScrollAreaHeight);
    }
}
