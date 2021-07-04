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



        if (HB1Appear && HB2Appear)
        {
            StartCoroutine(delay(3));
            HB2.HealthDecrease(20);
            Debug.Log("HB2 decrease\ndecrease:" + HB2.slider.value);
        }
    }
    private IEnumerator delay(int d)
    {
        yield return new WaitForSecondsRealtime(d);
    }
}
