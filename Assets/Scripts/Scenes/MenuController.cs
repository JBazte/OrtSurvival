using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{

    public Image black;
    public Animator anim;

    void Update()
    {

    }

    public void NewScene(string sceneName)
    {
        StartCoroutine(Fading(sceneName));
    }
    
    public void ExitScene()
    {
        StartCoroutine(ExitDelay());
    }

    IEnumerator Fading(string sceneName)
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        anim.SetBool("Fade", false);
        SceneManager.LoadScene(sceneName);
    }

    public IEnumerator ExitDelay()
    {
        yield return new WaitForSeconds(.8f);
        Application.Quit();
    }
}
