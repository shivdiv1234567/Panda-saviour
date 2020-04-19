using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Slider slider;
    public Gradient gradient;
    public int Damage = 20;
    public Image fill;
    public GameManager gm;
        
    private void Start()
    {
        currentHealth = maxHealth;
        slider.maxValue = maxHealth;

        fill.color = gradient.Evaluate(1f);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        slider.value = currentHealth;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(Damage);
        }
    }

    private void Update()
    {
        if (currentHealth < 0)
        {
            Destroy(gameObject);
            gm.Reset();
        }
    }

}
