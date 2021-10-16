using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehavior : MonoBehaviour
{
    public Slider Slider;
    public Color Low; // Color for when on Critical Health
    public Color High; // color for When on Normal Health

    // Start is called before the first frame update
public void SetHealth(float health, float maxHealth)
    {
        Slider.gameObject.SetActive(health < maxHealth);
        Slider.value = health;
        Slider.maxValue = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
