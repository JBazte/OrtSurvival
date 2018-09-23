using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealthManager : MonoBehaviour {

    public int EnemyMaxHealth;
    public int EnemyCurrentHealth;
    private bool flashActive;
    public float flashLength;
    private float flashCounter;
    private SpriteRenderer enemySprite;
    private Killer kill;
    private EffectsManager sound;

    // Use this for initialization
    void Start()
    {
        EnemyCurrentHealth = EnemyMaxHealth;
        enemySprite = GetComponent<SpriteRenderer>();
        kill = FindObjectOfType<Killer>();
        sound = FindObjectOfType<EffectsManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyCurrentHealth <= 0)
        {
            sound.EnemyKill.Play();
            kill.Enemy.Add(name);
            Destroy(gameObject);
        }
        if (flashActive)
        {
            if (flashCounter > flashLength * .66f)
            {
                enemySprite.color = Color.red;
            }
            else if (flashCounter > flashLength * .33f)
            {
                enemySprite.color = Color.red;
            }
            else if (flashCounter > 0f)
            {
                enemySprite.color = Color.white;
            }
            else
            {
                enemySprite.color = Color.white;
                flashActive = false;
            }
            flashCounter -= Time.deltaTime;
        }
    }

    public void HurtEnemy(int damageToGive)
    {
        EnemyCurrentHealth -= damageToGive;
        flashActive = true;
        flashCounter = flashLength;
    }
    public void SetMaxHelath()
    {
        EnemyCurrentHealth = EnemyMaxHealth;
    }
}
