
using UnityEngine;
using UnityEngine.SceneManagement;

public class GalleryReturner : MonoBehaviour
{
    public void LoadGallery()
    {
        SceneManager.LoadScene(SceneConstant.Gallery);
    }
}
