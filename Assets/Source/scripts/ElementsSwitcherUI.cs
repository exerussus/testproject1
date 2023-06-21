
using UnityEngine;

public class ElementsSwitcherUI : MonoBehaviour
{
    [SerializeField] private GameObject _portraitUI;
    [SerializeField] private GameObject _landscapeUI;

    private void SwitchElementsUI()
    {
        var newOrientation = Screen.orientation;
        if (newOrientation is ScreenOrientation.Portrait or ScreenOrientation.PortraitUpsideDown)
        {
            _portraitUI.SetActive(true);
            _landscapeUI.SetActive(false);
        }
        else if (newOrientation is ScreenOrientation.LandscapeLeft or ScreenOrientation.LandscapeRight)
        {
            _portraitUI.SetActive(false);
            _landscapeUI.SetActive(true);
        }
    }

    private void Update()
    {
        SwitchElementsUI();
    }
}


