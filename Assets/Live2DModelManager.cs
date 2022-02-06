using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Live2DModelManager : MonoBehaviour
{
    public GameObject[] models;
    
    // Start is called before the first frame update
    void Start()
    {
        foreach(var model in models)
        {
            model.SetActive(false);
        }
        StartCoroutine(ShowModels());
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
