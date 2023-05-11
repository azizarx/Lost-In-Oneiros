using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitHealth : MonoBehaviour
{
    int currentHealth;
    int currentmaxHealth;

    public int Health
    {
        get
        {
            return currentHealth;
        }
        set
        {
            currentHealth = value;
        }
    }
    public int MaxHealth
    {
        get
        {
            return currentmaxHealth;
        }
        set
        {
            currentmaxHealth = value;
        }
    }
    public unitHealth(int Health, int MaxHealth)
    {
        currentHealth = Health;
        currentmaxHealth = MaxHealth;
    }
    public void DmgUnit(int dmgAmount)
    {
        if (currentHealth>0)
        {
            currentHealth -= dmgAmount;
        }
    }
    public void HealUnit(int healAmount)
    {
        if (currentHealth < 0)
        {
            currentHealth += healAmount;
        }
        if (currentHealth < currentmaxHealth)
        {
            currentHealth = currentmaxHealth;
        }
    }

}
