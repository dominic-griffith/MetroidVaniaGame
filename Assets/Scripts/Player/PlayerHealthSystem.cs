using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthSystem : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth; //change once saving system is done
    }

    public void TakeDamage(int dmg)
    {
        currentHealth -= dmg;

        if(currentHealth <= 0)
        {
            //Kill Player
        }

    }

    public void Heal(int health)
    {
        currentHealth += health;

        if (currentHealth > maxHealth)
            currentHealth = maxHealth;
    }

}
