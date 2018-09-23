using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour {

    public string LevelToLoad;
    //private GameObject playerObject;
    public string exitPoint;
    private PlayerController thePlayer;
    public Image black;
    public Animator anim;
    private bool time;

    // Use this for initialization
    void Start () {
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
        thePlayer = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update () {
        if (time)
        {
            Time.timeScale = 0f;
        }
	}

    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "Player")
        {
            time = true;
            StartCoroutine(Fading());
            //playerObject = other.gameObject;
            thePlayer.startPoint = exitPoint;
        }
    }

    void OnLevelFinishedLoading(Scene scene, LoadSceneMode mode)
    {
        GameObject[] objects = scene.GetRootGameObjects();
        foreach(GameObject obj in objects)
        {
            if(obj.name == "Dario Boss")
            {
                //EnemyIA ia = obj.GetComponent<EnemyIA>();
                //ia.player = playerObject.transform;
            }
        }
    }
    IEnumerator Fading()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => black.color.a == 1);
        SceneManager.LoadScene(LevelToLoad);
        anim.SetBool("Fade", false);
    }
}
