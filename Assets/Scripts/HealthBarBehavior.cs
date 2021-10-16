using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class HealthBarBehavior : MonoBehaviour
{
    public Slider Slider;
    public Color Low; // Color for when on Critical Health
    public Color High; // color for When on Normal Health
    public int health; // Current Health
    public int maxHealth; // Current Max Health
    public UnityEvent OnDeath; // When Either Player Dies...

    // Start is called before the first frame update
public void SetHealth(float health, float maxHealth)
    {
        Slider.gameObject.SetActive(health < maxHealth);
        Slider.value = health;
        Slider.maxValue = maxHealth;
    }
public void Damage(){ 
    
    }

public void Die()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
