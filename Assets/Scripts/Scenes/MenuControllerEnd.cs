using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControllerEnd : MonoBehaviour {

    public Image black;
    public Animator anim;
    private GameObject button;

    void Start() {
        button = GameObject.Find("Reiniciar");
        GameObject myEventSystem = GameObject.Find("EventSystem");
        myEventSystem.GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(button);
    }

    void Update(){
        
    }

    public void NewScene(string sceneName)
    {
        StartCoroutine(Fading(sceneName));
    }

    public void RestartScene()
    {
        StartCoroutine(RestartDelay());
    }

    public void ExitScene()
    {
        StartCoroutine(Delay());
    }

    IEnumerator Fading(string sceneName)
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        anim.SetBool("Fade", false);
        SceneManager.LoadScene(sceneName);
    }

    public IEnumerator RestartDelay()
    {
        yield return new WaitForSecondsRealtime(.8f);
        System.Diagnostics.Process.Start(Application.dataPath.Replace("_Data", ".exe"));
        Application.Quit();
    }

    public IEnumerator Delay()
    {
        yield return new WaitForSecondsRealtime(.8f);
        Application.Quit();
    }
}
