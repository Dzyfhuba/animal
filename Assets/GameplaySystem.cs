using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplaySystem : MonoBehaviour
{
    // Start is called before the first frame update
    public HealthBar HB1;
    public HealthBar HB2;
    public HealthBar HB3;

    public bool HB1Appear;
    public bool HB2Appear;
    public bool HB3Appear;

    public void setH1Appear(bool e)
    {
        HB1Appear = e;
    }
    public void setH2Appear(bool e)
    {
        HB2Appear = e;
    }

    public void setH3Appear(bool e)
    {
        HB3Appear = e;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Space))
        {
            damage(20);
        }

    }


    public void Fight(int damageTotal)
    {
        damage(damageTotal);
    }

    private void damage(int dmg)
    {
        if (HB1Appear && HB2Appear)
        {
            // StartCoroutine(delay(3));
            HB2.HealthDecrease(dmg);
            Debug.Log("HB2 decrease\ndecrease:" + HB2.slider.value);
        }
        else if (HB3Appear && HB2Appear)
        {
            // StartCoroutine(delay(3));
            HB3.HealthDecrease(dmg);
            Debug.Log("HB3 decrease\ndecrease:" + HB3.slider.value);
        }
        else if (HB1Appear && HB1Appear)
        {
            // StartCoroutine(delay(3));
            HB2.HealthDecrease(dmg);
            Debug.Log("HB2 decrease\ndecrease:" + HB1.slider.value);
        }
    }
}
