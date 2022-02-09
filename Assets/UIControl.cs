using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
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
        if(appClass.GetStatic<bool>("isWallpaper"))
        {
            
        }
    }
}
