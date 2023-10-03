using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;


public class shopScenes : MonoBehaviour
{
	void Updaxte ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.LoadLevel ("Home");
		}
	}


	public void HoasdwmqeButoon ()
	{
		Application.LoadLevel ("Home");
	}

	public void showAaasdwds ()
	{
//		if (Advertisement.IsReady())
//		{
//			Advertisement.Show("rewardedVideo", new ShowOptions
//				{
//					resultCallback = result =>
//					{
//						if (result.ToString() == "Finished")
//						{
//							PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) + 200);
//							thuong.SetActive(true);
//							if (ads.activeInHierarchy == true)
//							{
//								ads.SetActive(false);
//							}
//						}
//					}
//				});
//		}
                 
	}

	public void asdwcdandcleAds ()
	{
		adsasdqw.SetActive (false);
	}

	[FormerlySerializedAs("thuong")] public GameObject asdw;
	[FormerlySerializedAs("ads")] public GameObject adsasdqw;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.LoadLevel ("Home");
		}
	}


	public void HoasdwmeButoon ()
	{
		Application.LoadLevel ("Home");
	}

	public void showAasdwds ()
	{
//		if (Advertisement.IsReady())
//		{
//			Advertisement.Show("rewardedVideo", new ShowOptions
//				{
//					resultCallback = result =>
//					{
//						if (result.ToString() == "Finished")
//						{
//							PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) + 200);
//							thuong.SetActive(true);
//							if (ads.activeInHierarchy == true)
//							{
//								ads.SetActive(false);
//							}
//						}
//					}
//				});
//		}
                 
	}

	public void asdwcandcleAds ()
	{
		adsasdqw.SetActive (false);
	}
}
