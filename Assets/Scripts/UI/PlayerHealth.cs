using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;

    public Image[] healthUI;

    private void Update()
    {
        UpdateHealthUI();
    }

    private void UpdateHealthUI()
    {
        for(int i = 0; i < healthUI.Length; i++)
        {
            if (i < currentHealth)
                healthUI[i].enabled = true;
            else
                healthUI[i].enabled = false;
        }
    }
}
