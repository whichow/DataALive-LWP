using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Live2DModelManager : MonoBehaviour
{
    public GameObject[] models;
    public bool random;

    private int index;

    void Start()
    {
        models[index].SetActive(true);
        if(random)
        {
            SwitchModel();
        }
    }

    public void SwitchModel()
    {
        models[index].SetActive(false);
        if(random)
        {
            index = Random.Range(0, models.Length);
        }
        else
        {
            if(++index >= models.Length)
                index = 0;
        }
        models[index].SetActive(true);
    }

    IEnumerator ShowModels()
    {
        int i = 0;
        while(true)
        {
            if(i == models.Length)
            {
                break;
            }
            if(i > 0)
            {
                models[i - 1].SetActive(false);
            }
            models[i].SetActive(true);
            i++;
            yield return new WaitForSeconds(3f);
        }
    }
}
