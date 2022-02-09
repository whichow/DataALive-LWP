using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    public GameObject UI;
    private AndroidJavaClass appClass;
    private string app = "ulw.ulw.ulw.App";

    // Start is called before the first frame update
    void Start()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        appClass = new AndroidJavaClass(app);
#endif
    }

    void OnApplicationFocus(bool hasFocus)
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        if(appClass.GetStatic<bool>("isWallpaper"))
        {
            UI.SetActive(false);
        }
        else
        {
            UI.SetActive(true);
        }
#else
        UI.SetActive(true);
#endif
    }
}
