using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallpaperManager : MonoBehaviour
{
    private AndroidJavaClass activityClass;
    private AndroidJavaClass wrapperClass;
    private AndroidJavaObject wrapperObject;

    private string activity = "ulw.ulw.ulw.UnityPlayerActivity";
    private string wrapper = "ulw.ulw.ulw.Wrapper";

    void Start()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        activityClass = new AndroidJavaClass(activity);
        wrapperClass = new AndroidJavaClass(wrapper);
        wrapperObject = wrapperClass.CallStatic<AndroidJavaObject>("instance");
#endif
    }

    public void SetAsWallpaper()
    {
        StartWallpaperService();
    }

    private void StartWallpaperService()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        activityClass.CallStatic("StartService");
#endif
    }
}
