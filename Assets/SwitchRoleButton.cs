using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchRoleButton : MonoBehaviour
{
    public GameObject[] roles;
    public bool random;

    private int index;

    void Start()
    {
        roles[index].SetActive(true);
    }

    public void SwitchRole()
    {
        roles[index].SetActive(false);
        if(random)
        {
            index = Random.Range(0, roles.Length);
        }
        else
        {
            if(++index >= roles.Length)
                index = 0;
        }
        roles[index].SetActive(true);
    }
}
