using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    public Image[] healthUI;

    private void Update()
    {
        UpdateHealthUI();
    }

    private void UpdateHealthUI()
    {
        for(int i = 0; i < healthUI.Length; i++)
        {
            if (i < PlayerState.GetInstance().currentHealth)
                healthUI[i].enabled = true;
            else
                healthUI[i].enabled = false;
        }
    }
}
