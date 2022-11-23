using System;
using Rofi;
using UnityEngine;

public class AndroidLoginService : PersistentSingleton<AndroidLoginService>
{
    public void StartLoginScene()
    {
        using AndroidJavaClass javaBridge = new AndroidJavaClass(Constants.ANDROID_CODE_PACKAGE + Constants.ANDROID_NATIVE_BRIDGE);
        javaBridge.CallStatic("OpenLoginScene");
    }

    //get data from native
    public void OnLoginComplete(String data)
    {
        Debug.Log("[Unity] OnLoginComplete " + data);
    }
}