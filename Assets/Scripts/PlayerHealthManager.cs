using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthManager : MonoBehaviour {

    public int maxHealth;
    public int currentHealth;
    public float waitToReload;
    public bool isReloading;

    // Use this for initialization
    void Start () {
        currentHealth = maxHealth;
        isReloading = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (isReloading)
        {
            waitToReload -= Time.deltaTime;
            if (waitToReload < 0)
            {
                currentHealth = maxHealth;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                gameObject.SetActive(true);
            }
        } else if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
            if (gameObject.name == "Player")
            {
                gameObject.SetActive(false);
                isReloading = true;
            }
        }
    }

    public void Hurt(int damage)
    {
        currentHealth -= damage;
    }

    public void Heal(int amount)
    {
        currentHealth += amount;
    }

    public void FullHeal()
    {
        currentHealth = maxHealth;
    }
}
