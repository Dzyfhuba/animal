using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthtBar;

    void Start()
    {
        currentHealth = maxHealth;
        // healthtBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            TakeDamage(20);
        }
    }
    
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

    }
}
