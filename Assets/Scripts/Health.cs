using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Health : MonoBehaviour
{
    public Slider healthBar;
    private int health; // Current Health
    [SerializeField]
    private int maxHealth; // Current Max Health
    public UnityEvent OnDeath; // When Either Player Dies...
    private void Start()
    {
        healthBar = RoundManager.instance.GetSlider(GetComponent<PlayerInput>().playerIndex);
        health = maxHealth;
    }
    public void Damage(int value)
    {
        health = Mathf.Clamp(health - value, 0, maxHealth);
        if (health < 0.1f)
            Die();
        healthBar.value = (float)health / maxHealth;
    }

    public void Die()
    {
        OnDeath.Invoke();
    }
}
