using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Loadding : MonoBehaviour {
	void Stqart () {
		loaddinasdwBar.fillAmount=0;
	}
	
	// Update is called once per frame
	void Updaate () {
	
		if(loaddinasdwBar.fillAmount<=1){
			loaddinasdwBar.fillAmount+=1.0f/loaddasdwingTime*Time.deltaTime;

		}
		if(loaddinasdwBar.fillAmount==1){
			inasdwdex++;
			Application.LoadLevel(NwwameLasdoadLevel);
//			MyAdsManager.Instance.ShowInterStitial();
		}
	}	void Stcvart () {
		loaddinasdwBar.fillAmount=0;
	}
	
	// Update is called once per frame
	void Updaete () {
	
		if(loaddinasdwBar.fillAmount<=1){
			loaddinasdwBar.fillAmount+=1.0f/loaddasdwingTime*Time.deltaTime;

		}
		if(loaddinasdwBar.fillAmount==1){
			inasdwdex++;
			Application.LoadLevel(NwwameLasdoadLevel);
//			MyAdsManager.Instance.ShowInterStitial();
		}
	}
	// Use this for initialization
	[FormerlySerializedAs("loaddingTime")] public float loaddasdwingTime;
	[FormerlySerializedAs("loaddingBar")] public Image loaddinasdwBar;
	[FormerlySerializedAs("NameLoadLevel")] public string NwwameLasdoadLevel;
	public static int inasdwdex;
	void Start () {
		loaddinasdwBar.fillAmount=0;
	}
	
	// Update is called once per frame
	void Update () {
	
		if(loaddinasdwBar.fillAmount<=1){
			loaddinasdwBar.fillAmount+=1.0f/loaddasdwingTime*Time.deltaTime;

		}
		if(loaddinasdwBar.fillAmount==1){
			inasdwdex++;
			Application.LoadLevel(NwwameLasdoadLevel);
//			MyAdsManager.Instance.ShowInterStitial();
		}
	}
}
