using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerProperties : MonoBehaviour
{
    public TextMeshProUGUI scoreDisplay;
    public Image healthDisplay;
    public int score;
    public float health;
    public float MaxHealth;

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = "Score: " + score;
        healthDisplay.fillAmount = health / MaxHealth;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if(health <= 0.0f)
        {
            GetComponent<PlayerRespawn>().RespawnCharacter();
            health = MaxHealth;
        }
    }
}
