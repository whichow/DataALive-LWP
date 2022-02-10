using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    public GameObject UI;
    private AndroidJavaClass appClass;
    private string app = "ulw.ulw.ulw.App";

    void OnApplicationFocus(bool hasFocus)
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        if(appClass == null)
        {
            appClass = new AndroidJavaClass(app);
        }
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
