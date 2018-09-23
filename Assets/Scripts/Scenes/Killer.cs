using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Killer : MonoBehaviour
{

    private static bool killerExists;
    public List<string> Enemy = new List<string>();

    // Use this for initialization
    void Start()
    {
        if (!killerExists)
        {
            killerExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
            for (int i = 0; i < Enemy.Count; i++)
            {
                GameObject killed = GameObject.Find(Enemy[i]);
                Destroy(killed);
            }
        if(Enemy.Count >= 22)
        {
            Enemy.Add(name);
            SceneManager.LoadScene(59);
            Time.timeScale = 0f;
        }
    }
}