using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

    public Sprite[] HeartSprites;
    public Image HeartUI;
    public GameObject Player;
    private static bool HUDExists;

    void Start () {
        Player.GetComponent<PlayerHealthManager>();
        if (!HUDExists)
        {
            HUDExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update() {
        HeartUI.sprite = HeartSprites[Player.GetComponent<PlayerHealthManager>().playerCurrentHealth];
    }
}
