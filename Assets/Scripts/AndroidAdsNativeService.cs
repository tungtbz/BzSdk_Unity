using System;
using UnityEngine;

public class AndroidAdsNativeService : PersistentSingleton<AndroidAdsNativeService>
{
    public void CheckVideoRewardAdsAvailable()
    {
        using AndroidJavaClass javaBridge = new AndroidJavaClass("com.bz.lib.AndroidBridge");
        bool isA = javaBridge.CallStatic<bool>("IsRewardedVideoAvailable");
        Debug.Log("CheckVideoRewardAdsAvailable " + isA);
    }

    public void ShowAds()
    {
        using AndroidJavaClass javaBridge = new AndroidJavaClass("com.bz.lib.AndroidBridge");
        javaBridge.CallStatic("ShowVideoReward");
    }

    public void OnAdsComplete(String placement)
    {
        Debug.Log("[Unity] OnAdsComplete " + placement);
    }
}