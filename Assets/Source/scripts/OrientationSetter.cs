
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OrientationSetter : MonoBehaviour
{
    public enum Orientation
    {
        Any,
        Portrait,
        PortraitFixed,
        Landscape,
        LandscapeFixed
    }

    public Orientation ScreenOrientation;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += Rotate;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= Rotate;
    }

    private void Rotate(Scene scene, LoadSceneMode mode)
    {
        switch (ScreenOrientation)
        {
            case Orientation.Any:
                Screen.orientation = UnityEngine.ScreenOrientation.AutoRotation;
                
                Screen.autorotateToPortrait = Screen.autorotateToPortraitUpsideDown = true;
                Screen.autorotateToLandscapeLeft = Screen.autorotateToLandscapeRight = true;
                break;
            
            case Orientation.Portrait:
                Screen.orientation = UnityEngine.ScreenOrientation.Portrait;
                Screen.autorotateToPortrait = Screen.autorotateToPortraitUpsideDown = true;
                Screen.autorotateToLandscapeLeft = Screen.autorotateToLandscapeRight = false;
                break;
            
            case Orientation.PortraitFixed:
                Screen.orientation = UnityEngine.ScreenOrientation.Portrait;
                break;
            
            case Orientation.Landscape:
                Screen.orientation = UnityEngine.ScreenOrientation.LandscapeRight;
                Screen.orientation = UnityEngine.ScreenOrientation.AutoRotation;
                
                Screen.autorotateToPortrait = Screen.autorotateToPortraitUpsideDown = false;
                Screen.autorotateToLandscapeLeft = Screen.autorotateToLandscapeRight = true;
                break;
            
            case Orientation.LandscapeFixed:
                Screen.orientation = UnityEngine.ScreenOrientation.LandscapeLeft;
                break;
        }
    }
}
