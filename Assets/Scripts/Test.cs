using DefaultNamespace;
using UnityEngine;

public class Test : MonoBehaviour
{
    public void CheckVideoRewardAdsAvailable()
    {
        AndroidAdsNativeService.Instance.CheckVideoRewardAdsAvailable();
    }

    public void ShowAds()
    {
        AndroidAdsNativeService.Instance.ShowAds();
    }

    public void LogEvent()
    {
        AndroidFirebaseService.Instance.LogEventOpenApp();
    }
}