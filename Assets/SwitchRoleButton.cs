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
        roles[index].SetActive(false);
        index = Random.Range(0, roles.Length);
        roles[index].SetActive(true);
    }

    public void SwitchNextRole()
    {

    }

    public void SwitchPreviousRole()
    {

    }
}
