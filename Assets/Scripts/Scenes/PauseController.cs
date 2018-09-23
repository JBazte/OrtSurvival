using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour {

    public GameObject PauseUI;
    private bool paused;
    public GameObject HUD;
    private GameObject thePlayer;

    // Use this for initialization
    void Start()
    {
        thePlayer = GameObject.FindGameObjectWithTag("Player");
        paused = false;
        PauseUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (thePlayer.GetComponent<PlayerHealthManager>().playerCurrentHealth > 0)
        {
            if (Input.GetButtonDown("Cancel") || Input.GetKeyDown(KeyCode.P))
            {
                paused = !paused;
            }
            if (paused)
            {
                thePlayer.SetActive(false);
                HUD.SetActive(false);
                PauseUI.SetActive(true);
                Time.timeScale = 0;
            }
            if (!paused)
            {
                thePlayer.SetActive(true);
                HUD.SetActive(true);
                PauseUI.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }

    public void Reanudar()
    {
        StartCoroutine(ReanudarDelay());
    }

    public void Reiniciar()
    {
        StartCoroutine(RestartDelay());
    }

    public void Salir()
    {
        StartCoroutine(ExitDelay());
    }
    public IEnumerator ReanudarDelay()
    {
        yield return new WaitForSecondsRealtime(.8f);
        paused = false;
    }

    public IEnumerator RestartDelay()
    {
        yield return new WaitForSecondsRealtime(.8f);
        System.Diagnostics.Process.Start(Application.dataPath.Replace("_Data", ".exe"));
        Application.Quit();
    }

    public IEnumerator ExitDelay()
    {
        yield return new WaitForSecondsRealtime(.8f);
        Application.Quit();
    }

}
