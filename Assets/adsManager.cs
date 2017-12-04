using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class adsManager : MonoBehaviour {




public static adsManager instance;
	void Awake()
	{
		if(instance==null)
		instance=this;
		else{
			Destroy(gameObject);
			return;
		}
		DontDestroyOnLoad(gameObject);
    }
    public  int ads_timer=8;

 InterstitialAd interstitial;
 public string id;
		private void RequestInterstitial(){
    #if UNITY_ANDROID
        string adUnitId =id;
    #elif UNITY_IPHONE
        string adUnitId =id;
    #else
        string adUnitId = "unexpected_platform";
    #endif

    // Initialize an InterstitialAd.
     interstitial = new InterstitialAd(adUnitId);

	 // Create an empty ad request.
    AdRequest request = new AdRequest.Builder().Build();
    // Load the interstitial with the request.
    interstitial.LoadAd(request);
}

void Update()
{
    if(ads_timer<=0){
        ads_timer=8;
        GameOver();
    }

    
}

private void GameOver()
{
  if (interstitial.IsLoaded()) {
    interstitial.Show();
  }
}
}
