
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    [SerializeField] private Loading _loading;
    private void OnEnable()
    {
        _loading.OnDone += Run;
    }

    private void OnDisable()
    {
        _loading.OnDone -= Run;
    }

    private static void Run()
    {
        SceneManager.LoadScene(SceneConstant.Gallery);
    }
}
