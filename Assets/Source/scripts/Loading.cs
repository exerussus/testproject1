
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
     [SerializeField] private Slider _slider;
     [SerializeField] private TextMeshProUGUI _text;
     private float _timeCount;
     private float _fillValue;

     public Action OnDone;
     private Action _onFixedUpdate;

     public void Start()
     {
          Run(2);
     }

     public void Run(float timeCount)
     {
          _slider.value = 0;
          _text.text = "0%";
          _timeCount = timeCount;
          _fillValue = 1 / _timeCount * Time.fixedDeltaTime;
          _onFixedUpdate += Progress;
     }

     private void Progress()
     {   
          _slider.value += _fillValue;
          _text.text = Mathf.RoundToInt(_slider.value * 100) + "%";
          if (_slider.value >= 1)
          {
               _onFixedUpdate -= Progress;
               OnDone?.Invoke();
          }
     }

     private void FixedUpdate()
     {
          _onFixedUpdate?.Invoke();
     }
}
