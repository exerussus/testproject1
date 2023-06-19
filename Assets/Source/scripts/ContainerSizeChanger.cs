
using System;
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

    private void SizeRecalculate()
    {
        if (true) _conteinerRectTransform.sizeDelta = new Vector2(_conteinerRectTransform.sizeDelta.x,
            _flexGridLayout.cellSize.y * _flexGridLayout.ChildrenCount / _flexGridLayout.ColumnCount);
    }
}
