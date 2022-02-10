using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchRoleButton : MonoBehaviour
{
    public GameObject[] roles;

    private int index;

    void Start()
    {
        SwitchRandomRole();
    }

    public void SwitchRandomRole()
    {
        if(roles.Length < 1)
        {
            return;
        }
        roles[index].SetActive(false);
        while(true)
        {
            int i = Random.Range(0, roles.Length);
            if(i != index)
            {
                index = i;
                break;
            }
        }
        roles[index].SetActive(true);
    }

    public void SwitchNextRole()
    {

    }

    public void SwitchPreviousRole()
    {

    }
}
