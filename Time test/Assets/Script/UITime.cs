using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITime : MonoBehaviour
{
    public TimeFrameWork Framework;
    private Image IMG;

    //Sprites
    public Sprite daySprite;
    public Sprite nightSprite;

    public String ingameTime;

    // Start is called before the first frame update
    void Start()
    {
        Framework = FindObjectOfType<TimeFrameWork>();
        IMG = GetComponent<Image>();
    }

    void FixedUpdate()
    {
        ingameTime = Framework.timeGetter();

        //Checks if the time is day
        if (ingameTime.Equals("day"))
        {
            daySetter();
        }

        //Checks if the time is night
        if (ingameTime.Equals("night"))
        {
            nightSetter();
        }
    }


    private void daySetter()
    {
        IMG.sprite = daySprite;
    }

    private void nightSetter()
    {
        IMG.sprite = nightSprite;
    }
}
