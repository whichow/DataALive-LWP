using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    public GameObject[] backgrounds;

    public bool random;

    private int index;

    void Start()
    {
        backgrounds[index].SetActive(true);
        if(random)
        {
            SwitchBackground();
        }
    }

    public void SwitchBackground()
    {
        backgrounds[index].SetActive(false);
        if(random)
        {
            index = Random.Range(0, backgrounds.Length);
        }
        else
        {
            if(++index >= backgrounds.Length)
                index = 0;
        }
        backgrounds[index].SetActive(true);
    }
}
