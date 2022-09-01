using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
	public int maxHealth = 100;
	public int currentHealth;
	public HealthBar healthBar;
    public TMP_Text WeatherText;
    public GameObject fog;
    // Start is called before the first frame update
    void Start()
    {
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
    }

	public void TakeDamage(int damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "normal")
        {
            WeatherText.text = "normal";
        }
        if (other.tag == "fog")
        {
            WeatherText.text = "fog";
            fog.SetActive(true);
        }
        if (other.tag == "rain")
        {
            WeatherText.text = "rain";
        }
        if (other.tag == "windy")
        {
            WeatherText.text = "windy";
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "fog")
        {
            WeatherText.text = "fog";
            fog.SetActive(false);
        }
    }
}