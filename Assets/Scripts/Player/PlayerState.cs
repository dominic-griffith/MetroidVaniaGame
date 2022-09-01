using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public static PlayerState Instance;

    public int currentHealth;
    public int maxHealth = 3;

    private void Awake()
    {
        if (Instance == null)
        {

            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        currentHealth = maxHealth; //change once saving system is done
    }

    public static PlayerState GetInstance()
    {
        return Instance;
    }

}
