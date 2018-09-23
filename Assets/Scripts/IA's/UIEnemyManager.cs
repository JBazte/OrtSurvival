using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIEnemyManager : MonoBehaviour {

    public Slider enemyHealtBar;
    public EnemyHealthManager enemyHealth;
    private Canvas can;

	// Use this for initialization
	void Start () {
        can = GetComponent<Canvas>();
        can.worldCamera = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update() {
        enemyHealtBar.maxValue = enemyHealth.EnemyMaxHealth;
        enemyHealtBar.value = enemyHealth.EnemyCurrentHealth;
        if (enemyHealth.EnemyCurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
	}
}