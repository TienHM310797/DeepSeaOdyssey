using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class MenuManager : MonoBehaviour {

	public void CliasdwackHome(){
		Application.LoadLevel("Home");
	}

	public void ClicasdwasdkYesExit(){
		Application.Quit();
	}
	public void CLickassdwCancelExit(){
//		MyAdsManager.Instance.ShowBanner();
		boxExitasdw.SetActive(false);
	}

	public void ClickCasdcvwncelNoBanner(){
		boxExitasdw.SetActive(false);
	}
    
	public void VisiblewPasdwanel(){
		pasdwnel.SetActive(false);
		buttonasdwNext.SetActive(false);
//		AudioManager.audioManager.StopSingle(null);
	}

	public void RepadwwlaweyScene(){
		Application.LoadLevel(Application.loadedLevel);
	}

	public void EneblasPanasdwel(){
		pasdwnel.SetActive(true);
		buttonasdwNext.SetActive(false);
//		AudioManager.audioManager.PlaySingle(playAudio,false);

	}
	[FormerlySerializedAs("groupSetting")] public GameObject groupSasdwetting;
	private bool cheasdw;
	[FormerlySerializedAs("loadding")] public GameObject asdw;
	[FormerlySerializedAs("btnMusic")] public GameObject btnMusicasdww;
	[FormerlySerializedAs("playAudio")] public AudioClip playasdw;
	[FormerlySerializedAs("boxExit")] public GameObject boxExitasdw;
	[FormerlySerializedAs("checkShowBanner")] public bool checasdwkShowBanner;
	[FormerlySerializedAs("panel")] public GameObject pasdwnel;
	[FormerlySerializedAs("buttonNext")] public GameObject buttonasdwNext;
	[FormerlySerializedAs("audioClip")] public AudioClip audioasdwwwClip;

	[FormerlySerializedAs("UIRoot")] public GameObject UIasdwRoot;
	// Use this for initialization
	void Start () {
		cheasdw = true;
//		if(btnMusic!=null){
//			if(MainStatic.CHECK_VOLUM){
//				btnMusic.transform.GetChild (0).gameObject.SetActive (true);
//				btnMusic.transform.GetChild (1).gameObject.SetActive (false);
//				AudioListener.pause = false;
//			}else{
//				btnMusic.transform.GetChild (0).gameObject.SetActive (false);
//				btnMusic.transform.GetChild (1).gameObject.SetActive (true);
//				AudioListener.pause = true;
//
//			}
//		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			if(boxExitasdw.activeSelf){
				if(UIasdwRoot!=null){
					UIasdwRoot.SetActive(true);
				}
				boxExitasdw.SetActive(false);
				if(checasdwkShowBanner){
//					MyAdsManager.Instance.ShowBanner();
				}
			}else{
//				MyAdsManager.Instance.HideBanner();
				if(UIasdwRoot!=null){
					UIasdwRoot.SetActive(false);
				}
				boxExitasdw.SetActive(true);
			}
		}
	}

	public void asdwClickSetting(){
		//AudioManager.audioManager.PlaySingle(audioClip,false);
		if(cheasdw){
			iTween.MoveTo (groupSasdwetting, iTween.Hash ("position", new Vector3(-3.6f,0f,0), "time", 1, "easetype", iTween.EaseType.easeInOutBack));
			
			cheasdw=false;
		}else{
			iTween.MoveTo (groupSasdwetting, iTween.Hash ("position", new Vector3(-5f,0f,0), "time", 1, "easetype", iTween.EaseType.easeOutBack));
			cheasdw = true;
		}
	}

	public void SetLoasdwadding(string level){
		//AudioManager.audioManager.PlaySingle(audioClip,false);
		asdw.SetActive(true);
		asdw.transform.GetChild(0).GetComponent<Loadding>().NwwameLasdoadLevel = level;
	}

	public void NextScasdwene(string nameScene){
		Application.LoadLevel(nameScene);

	}
	public void ClickButonPlay(){
		Invoke("Deasdwlay",.5f);
//		AudioManager.audioManager.PlaySingle(playAudio,false);
	}

	public void Deasdwlay(){
		Application.LoadLevel("ChooseLevel");
//		ManagerChooseLevel.check = true;
	}

//	public void NextSceneChooseLevel(string level){
//		Application.LoadLevel("ChooseLevel");
////		ManagerChooseLevel.check = false;
//		MyAdsManager.HideBanner();
//		for(int i=2;i<12;i++){
//			if(level=="Level"+i){
//				PlayerPrefs.SetInt("Level" + i,i);
//			}
//		}
//	}
	public void ChaasdwngeMusic(){
		
		if (btnMusicasdww.transform.GetChild (0).gameObject.activeSelf == true) {
			btnMusicasdww.transform.GetChild (0).gameObject.SetActive (false);
			btnMusicasdww.transform.GetChild (1).gameObject.SetActive (true);
			AudioListener.pause = true;
//			MainStatic.CHECK_VOLUM= false;
		}else{
			btnMusicasdww.transform.GetChild (0).gameObject.SetActive (true);
			btnMusicasdww.transform.GetChild (1).gameObject.SetActive (false);
			AudioListener.pause = false;
//			MainStatic.CHECK_VOLUM= true;
		}
	}

	public void CliasdwckHome(){
		Application.LoadLevel("Home");
	}

	public void ClicasdwkYesExit(){
		Application.Quit();
	}
	public void CLickasdwCancelExit(){
//		MyAdsManager.Instance.ShowBanner();
		boxExitasdw.SetActive(false);
	}

	public void ClickCasdwncelNoBanner(){
		boxExitasdw.SetActive(false);
	}
    
	public void VisiblePasdwanel(){
		pasdwnel.SetActive(false);
		buttonasdwNext.SetActive(false);
//		AudioManager.audioManager.StopSingle(null);
	}

	public void RepadwwlayScene(){
		Application.LoadLevel(Application.loadedLevel);
	}

	public void EneblePanasdwel(){
		pasdwnel.SetActive(true);
		buttonasdwNext.SetActive(false);
//		AudioManager.audioManager.PlaySingle(playAudio,false);

	}

}
