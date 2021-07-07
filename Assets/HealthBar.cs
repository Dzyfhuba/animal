using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;

    public int maxHealth;
    public float curHealth;
    GameObject objName; 

    void Start(){

        slider = gameObject.GetComponent<Slider>();
        objName = gameObject;
        Debug.Log(objName.name);

        SetMaxHealth(maxHealth);
        
    } 
    public void SetMaxHealth(int health)
    {
       slider.maxValue = health;
       slider.value = health; 
       curHealth = slider.value;
    }

    // Update is called once per frame
    public void SetHealth(int health)
    {
        slider.value = health;
    }

    public void HealthDecrease(int dmg){
        slider.value -= dmg;
    }

    void Update(){
        curHealth = slider.value;
    }
    public void reset(){
        slider.value = maxHealth;
    }
}
