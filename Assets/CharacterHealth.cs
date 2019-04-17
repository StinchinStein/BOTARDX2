using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHealth : MonoBehaviour
{
    public float CurrentHealth { get; set; }
    public float MaxHealth { get; set; }
    public Slider healthbar;
    
    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = 100f;
        //Resets health to full on game load
        CurrentHealth = MaxHealth;
        healthbar.value = CalculateHealth();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void damage()
    {
        if (CurrentHealth <= 0)
        {
            Die();
        }
    }

    float CalculateHealth()
    {
        return CurrentHealth / MaxHealth;
    }

    void Die()
    {
        CurrentHealth = 0;
        Debug.Log("Your dead");
    }
    

}
