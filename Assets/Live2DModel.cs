using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Live2DModel : MonoBehaviour
{
    public string[] motionNames;
    public bool useIndex;
    public int index;
    private LAppModel model;

    private float mouseDownTime;
    private Vector3 mousePos;
    private Live2DAudio l2dAudio;

    // Start is called before the first frame update
    void Start()
    {
        LAppModelProxy proxy = GetComponent<LAppModelProxy>();
        model = proxy.GetModel();

        l2dAudio = GetComponent<Live2DAudio>();
    }

    void OnMouseDown()
    {
        Debug.Log("On mouse down");
        mouseDownTime = Time.time;
        mousePos = Input.mousePosition;
    }

    void OnMouseUp()
    {
        Debug.Log("On mouse up");
        if (Time.time - mouseDownTime > 0.5f)
        {
            return;
        }
        var deltaPos = Vector3.Distance(Input.mousePosition, mousePos);
        if (deltaPos > 0.1f)
        {
            return;
        }
        Debug.Log("On mouse click");
        if(model.IsFinished())
        {
            if(!useIndex)
            {
                index = Random.Range(0, motionNames.Length);
            }
            string motionName = motionNames[index];
            model.StartRandomMotion(motionName, 1);
            // model.SetRandomExpression();
            if(l2dAudio != null)
            {
                l2dAudio.PlayAudio(index);
            }
        }
    }
}
