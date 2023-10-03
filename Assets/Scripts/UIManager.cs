using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class UIManager : MonoSingleton<UIManager>
{

	public void sdfasdwepUpCoin(){
		sdfeUiRoot.SetActive(false);
		posdfpUp.SetActive(true);
	}

	public void dfeePopqUpCoin(){
		sdfeUiRoot.SetActive(true);
		posdfpUp.SetActive(false);
	}

	public void sdfemasdond(){
		sdfeUiRoot.SetActive(false);
		popUpsdfeDiamond.SetActive(true);
	}

	public void CloseShssodsfdf ()
	{
		sdfeUiRoot.SetActive (true);
		popUpsdfeDiamond.SetActive (false);
	}
	[FormerlySerializedAs("_lb")] public Text sdfew;
	[FormerlySerializedAs("thuong")] public GameObject thsdfeuong;
	[FormerlySerializedAs("popUp")] public GameObject posdfpUp;
	[FormerlySerializedAs("popUpDiamond")] public GameObject popUpsdfeDiamond;
	[FormerlySerializedAs("UiRoot")] public GameObject sdfeUiRoot;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void sdfeeecssess ()
	{
		PlayerPrefs.SetInt ("gold", PlayerPrefs.GetInt ("gold", 450) + 200);
		thsdfeuong.SetActive (true);
		sdfew.text = "" + PlayerPrefs.GetInt ("gold", 450);
		if (posdfpUp.activeInHierarchy == true) {
			sdfeUiRoot.SetActive(true);
			posdfpUp.SetActive (false);
		}
	}

	public void sdfepUpCoin(){
		sdfeUiRoot.SetActive(false);
		posdfpUp.SetActive(true);
	}

	public void dfeePopUpCoin(){
		sdfeUiRoot.SetActive(true);
		posdfpUp.SetActive(false);
	}

	public void sdfemond(){
		sdfeUiRoot.SetActive(false);
		popUpsdfeDiamond.SetActive(true);
	}

	public void CloseShodsfdf ()
	{
		sdfeUiRoot.SetActive (true);
		popUpsdfeDiamond.SetActive (false);
	}
}
