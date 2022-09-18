using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Live2DModelManager : MonoBehaviour
{
    public GameObject[] models;

    private int index;

    void Start()
    {
        models[index].SetActive(true);
    }

    public void SwitchNext()
    {
        models[index].SetActive(false);
        if (++index >= models.Length)
            index = 0;
        models[index].SetActive(true);
    }

    public void SwitchPrevious()
    {
        models[index].SetActive(false);
        if (--index < 0)
            index = models.Length - 1;
        models[index].SetActive(true);
    }

    public void SwitchRandom()
    {
        models[index].SetActive(false);
        index = Random.Range(0, models.Length);
        models[index].SetActive(true);
    }

    IEnumerator ShowModels()
    {
        int i = 0;
        while (true)
        {
            if (i == models.Length)
            {
                break;
            }
            if (i > 0)
            {
                models[i - 1].SetActive(false);
            }
            models[i].SetActive(true);
            i++;
            yield return new WaitForSeconds(3f);
        }
    }
}
