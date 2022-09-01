using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthSystem : MonoBehaviour
{
    public void TakeDamage(int dmg)
    {
        PlayerState.GetInstance().currentHealth -= dmg;

        if(PlayerState.GetInstance().currentHealth <= 0)
        {
            //Kill Player
        }

    }

    public void Heal(int health)
    {
        if (PlayerState.GetInstance().currentHealth + health > PlayerState.GetInstance().maxHealth)
            PlayerState.GetInstance().currentHealth = PlayerState.GetInstance().maxHealth;
        else
            PlayerState.GetInstance().currentHealth += health;
    }
}
