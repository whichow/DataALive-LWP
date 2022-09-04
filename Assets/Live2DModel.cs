using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Live2DModel : MonoBehaviour
{
    public string[] motionNames;
    private LAppModel model;

    // Start is called before the first frame update
    void Start()
    {
        LAppModelProxy proxy = GetComponent<LAppModelProxy>();
        model = proxy.GetModel();
    }

    void OnMouseDown()
    {
        if(model.IsFinished())
        {
            int index = Random.Range(0, motionNames.Length);
            string motionName = motionNames[index];
            model.StartRandomMotion(motionName, 1);
            model.SetRandomExpression();
        }
    }
}
