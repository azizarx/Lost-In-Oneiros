using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static float hp = 100;
    public static float maxHp = 100;
    public static float Sprintbar = 100;
    public static bool isSprinting = false;
    public Slider StaminaSlider;
    public Slider HealthSlider;
    void Start()
    {
        HealthSlider.maxValue = 100;
        StaminaSlider.value = 100;
        StaminaSlider.maxValue = 100;
        StaminaSlider.value = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isSprinting = true;
            Sprintbar -= 40f * Time.deltaTime ;
            Debug.Log(Sprintbar);
            Sprintbar = Mathf.Max(Sprintbar, 0);
            StaminaSlider.value = Sprintbar;
        }
        else if (Sprintbar < 100)
        {
            Sprintbar += 20f * Time.deltaTime;
            StaminaSlider.value = Sprintbar;
        }
        isSprinting = false;
        HealthSlider.value = hp;

    }
    public static void TakeDamage(float damage)
{
    hp -= damage;
    if (hp <= 0)
    {    
        hp = 0;
        Debug.Log("You died");
    }
}

}
