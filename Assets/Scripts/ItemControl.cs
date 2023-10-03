using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ItemControl : MonoBehaviour
{	public void Fdfdfzdd ()
	{
		if (PlayerPrefs.GetInt ("itembom", 1) > 0) {
			Instantiate (efsdfBoom, Camera.main.ScreenToWorldPoint (Input.mousePosition), Quaternion.identity);
			PlayerPrefs.SetInt ("itembom", PlayerPrefs.GetInt ("itembom", 1) - 1);
		} else {
			UIRsdfoot.SetActive (false);
			ssdfhop.SetActive (true);
		}
	}

	public void closedsdfShop ()
	{
		ssdfhop.SetActive (false);
		UIRsdfoot.SetActive (true);
		_lsdfb.text = PlayerPrefs.GetInt ("gold", 450) + "";
	}
    

	public void cancsdflssdfeads ()
	{
		posdfpUp.SetActive (false);
	}

	public void sdfdfsd ()
	{
		menuMansdfager.SetLoasdwadding ("Home");
//		Application.LoadLevel ("Home");
	}	public void Fdfdssdafdfd ()
	{
		if (PlayerPrefs.GetInt ("itembom", 1) > 0) {
			Instantiate (efsdfBoom, Camera.main.ScreenToWorldPoint (Input.mousePosition), Quaternion.identity);
			PlayerPrefs.SetInt ("itembom", PlayerPrefs.GetInt ("itembom", 1) - 1);
		} else {
			UIRsdfoot.SetActive (false);
			ssdfhop.SetActive (true);
		}
	}

	public void closesdfSqawhop ()
	{
		ssdfhop.SetActive (false);
		UIRsdfoot.SetActive (true);
		_lsdfb.text = PlayerPrefs.GetInt ("gold", 450) + "";
	}
    

	public void cancsdfaleads ()
	{
		posdfpUp.SetActive (false);
	}

	public void sdfhosdmeButton ()
	{
		menuMansdfager.SetLoasdwadding ("Home");
//		Application.LoadLevel ("Home");
	}
	[FormerlySerializedAs("efBoom")] public GameObject efsdfBoom;
	[FormerlySerializedAs("efNT")] public GameObject easdffNT;
	[FormerlySerializedAs("shop")] public GameObject ssdfhop;
	[FormerlySerializedAs("_lb")] public Text _lsdfb;
	[FormerlySerializedAs("thuong")] public GameObject tsdfhuong;
	[FormerlySerializedAs("popUp")] public GameObject posdfpUp;
	[FormerlySerializedAs("UIRoot")] public GameObject UIRsdfoot;
	[FormerlySerializedAs("menuManager")] public MenuManager menuMansdfager;
	[FormerlySerializedAs("shopDiamond")] public GameObject ssdfopDiamond;

	void Start ()
	{
//		PlayerPrefs.DeleteAll();
//		PlayerPrefs.GetInt("itemcamap",1);
	}

	public void DestrosdfyCaMap ()
	{
		if (PlayerPrefs.GetInt ("itemcamap", 1) > 0) {
			while (FishManage.Insasdwtance._CaMasdwapManage.Count > 0) {
				Transform aFish = FishManage.Insasdwtance._CaMasdwapManage [0];
				FishManage.Insasdwtance._CaMasdwapManage.RemoveAt (0);
				if (aFish != null)
					aFish.GetComponent<FishControl> ().hitasdwDame (10000, efsdfBoom);
			}
			PlayerPrefs.SetInt ("itemcamap", PlayerPrefs.GetInt ("itemcamap", 1) - 1);
			AudioControl.cvbdtfg.clickButtonsdfe ();
		} else {
			UIRsdfoot.SetActive (false);
			ssdfhop.SetActive (true);
		}
	}

	public void DestroyMusdfc ()
	{
		if (PlayerPrefs.GetInt ("itemmuc", 1) > 0) {
			while (FishManage.Insasdwtance._MucManasdwager.Count > 0) {
				Transform aFish = FishManage.Insasdwtance._MucManasdwager [0];
				FishManage.Insasdwtance._MucManasdwager.RemoveAt (0);
				if (aFish != null)
					aFish.GetComponent<FishControl> ().hitasdwDame (10000, efsdfBoom);
			}
			PlayerPrefs.SetInt ("itemmuc", PlayerPrefs.GetInt ("itemmuc", 1) - 1);
			AudioControl.cvbdtfg.clickButtonsdfe ();
		} else {
			UIRsdfoot.SetActive (false);
			ssdfhop.SetActive (true);
		}
	}

	public void DsdfestroyAll ()
	{
		if (PlayerPrefs.GetInt ("itemnt", 1) > 0) {
			AudioControl.cvbdtfg.nguyentusdfe ();
			while (FishManage.Insasdwtance._FiasdwshMange.Count > 0) {
				Transform aFish = FishManage.Insasdwtance._FiasdwshMange [0];
				FishManage.Insasdwtance._FiasdwshMange.RemoveAt (0);
				if (aFish != null)
					aFish.GetComponent<FishControl> ().hitasdwDame (10000, efsdfBoom);
			}
			Instantiate (easdffNT, Vector3.zero, Quaternion.identity);
			PlayerPrefs.SetInt ("itemnt", PlayerPrefs.GetInt ("itemnt", 1) - 1);
		} else {
			UIRsdfoot.SetActive (false);
			ssdfhop.SetActive (true);
		}
	}

	public void sdfItemX2 ()
	{
		if (PlayerPrefs.GetInt ("itemx2", 1) > 0) {
			CancelInvoke ("RsdfesetGsdfwq");
			GunControl.Bonusasd2Coin = 2;
			Invoke ("RsdfesetGsdfwq", 30);
			PlayerPrefs.SetInt ("itemx2", PlayerPrefs.GetInt ("itemx2", 1) - 1);
			AudioControl.cvbdtfg.clickButtonsdfe ();
		} else {
			UIRsdfoot.SetActive (false);
			ssdfhop.SetActive (true);
		}
	}

	public void ItesdfmX3 ()
	{
		if (PlayerPrefs.GetInt ("itemx3", 1) > 0) {
			CancelInvoke ("RsdfesetGsdfwq");
			GunControl.Bonusasd2Coin = 3;
			Invoke ("RsdfesetGsdfwq", 30);
			PlayerPrefs.SetInt ("itemx3", PlayerPrefs.GetInt ("itemx3", 1) - 1);
			AudioControl.cvbdtfg.clickButtonsdfe ();
		} else {
			UIRsdfoot.SetActive (false);
			ssdfhop.SetActive (true);
		}
	}

	void RsdfesetGsdfwq ()
	{
		GunControl.Bonusasd2Coin = 1;
	}

	public void Fdfdfd ()
	{
		if (PlayerPrefs.GetInt ("itembom", 1) > 0) {
			Instantiate (efsdfBoom, Camera.main.ScreenToWorldPoint (Input.mousePosition), Quaternion.identity);
			PlayerPrefs.SetInt ("itembom", PlayerPrefs.GetInt ("itembom", 1) - 1);
		} else {
			UIRsdfoot.SetActive (false);
			ssdfhop.SetActive (true);
		}
	}

	public void closesdfShop ()
	{
		ssdfhop.SetActive (false);
		UIRsdfoot.SetActive (true);
		_lsdfb.text = PlayerPrefs.GetInt ("gold", 450) + "";
	}
    

	public void cancsdfleads ()
	{
		posdfpUp.SetActive (false);
	}

	public void sdfhomeButton ()
	{
		menuMansdfager.SetLoasdwadding ("Home");
//		Application.LoadLevel ("Home");
	}
}
