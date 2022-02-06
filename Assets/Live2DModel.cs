using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Live2DModel : MonoBehaviour
{
    public string[] motionNames;
    public string idleMotion;
    public string idleExpression;
    private LAppModel model;

    // Start is called before the first frame update
    void Start()
    {
        LAppModelProxy proxy = GetComponent<LAppModelProxy>();
        model = proxy.GetModel();
    }

    void OnMouseDown()
    {
        while(true)
        {
            int index = Random.Range(0, motionNames.Length);
            string motionName = motionNames[index];
            if(motionName != idleMotion)
            {
                model.StartMotion(motionName, 0, 2);
                // model.SetRandomExpression();
                break;
            }
        }
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if(model.IsFinished())
    //     {
    //         model.StartMotion(idleMotion, 0, 1);
    //         // model.SetExpression(idleExpression);
    //     }
    // }
}
