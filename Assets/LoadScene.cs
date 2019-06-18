using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    int currentIndex;
    [SerializeField] int timeToWait = 4;

    private void Start()
    {
        currentIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
        
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }
    public void LoadSplashScene()
    {
        SceneManager.LoadScene("Splash Scene");
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentIndex + 1);
    }
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Start Scene");
    }
}
