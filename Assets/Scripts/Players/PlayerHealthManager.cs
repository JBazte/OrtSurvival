using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthManager : MonoBehaviour {

    public int playerMaxHealth;
    public int playerCurrentHealth;
    private bool flashActive;
    public float flashLength;
    private float flashCounter;
    private SpriteRenderer playerSprite;
    private GameObject HUD;

    // Use this for initialization
    void Start() {
        playerCurrentHealth = playerMaxHealth;
        playerSprite = GetComponent<SpriteRenderer>();
        HUD = GameObject.Find("Health");
    }

    // Update is called once per frame
    void Update() {
        if (playerCurrentHealth <= 0)
        {
            gameObject.SetActive(false);
            HUD.gameObject.SetActive(false);
            SceneManager.LoadScene(60);
            Time.timeScale = 0f;
        }
        if (playerCurrentHealth > playerMaxHealth)
        {
            playerCurrentHealth = playerMaxHealth;
        }
        if (flashActive)
        {
            if (flashCounter > flashLength * .66f)
            {
                playerSprite.color = Color.red;
            }
            else if (flashCounter > flashLength * .33f)
            {
                playerSprite.color = Color.white;
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
            }
            else if (flashCounter > 0f)
            {
                playerSprite.color = Color.red;
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 0f);
            }
            else
            {
                playerSprite.color = Color.white;
                playerSprite.color = new Color(playerSprite.color.r, playerSprite.color.g, playerSprite.color.b, 1f);
                flashActive = false;
            }
            flashCounter -= Time.deltaTime;
        }
    }

    public void HurtPlayer(int damageToGive)
    {
        playerCurrentHealth -= damageToGive;
        flashActive = true;
        flashCounter = flashLength;
    }

    public void SetMaxHelath()
    {
        playerCurrentHealth = playerMaxHealth;
    }

}
