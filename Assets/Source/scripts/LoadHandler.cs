
using UnityEngine;

public class LoadHandler : MonoBehaviour
{
    private static LoadHandler instance;
    
    private static int _actuallyLoad;
    private static int _maxLoad = 1;
    public static bool CanBeLoaded => _actuallyLoad < _maxLoad;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        _actuallyLoad = 0;
    }

    public static void Load()
    {
        _actuallyLoad += 1;
    }

    public static void Unload()
    {
        _actuallyLoad = _actuallyLoad - 1 >= 0 ? _actuallyLoad -= 1 : 0;
    }

}
