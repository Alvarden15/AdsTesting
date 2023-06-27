using GoogleMobileAds.Api;
using UnityEngine;

public class AdsInitializer : MonoBehaviour
{
    private void Start()
    {
        MobileAds.Initialize(initStatus => { });
    }
}