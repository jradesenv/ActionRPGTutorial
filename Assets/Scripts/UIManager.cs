using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Text hpText;
    public Slider hpSlider;
    public PlayerHealthManager playerHealth;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        hpSlider.maxValue = playerHealth.maxHealth;
        hpSlider.value = playerHealth.currentHealth;
        hpText.text = "HP: " + playerHealth.currentHealth + "/" + playerHealth.maxHealth;

    }
}
