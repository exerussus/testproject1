
using UnityEngine;
using UnityEngine.SceneManagement;

public class GalleryTransition : MonoBehaviour
{
    public void Run()
    {
        SceneManager.LoadScene(SceneConstant.Load);
    }
}
