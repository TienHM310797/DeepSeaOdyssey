using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;
using UnityEngine.UI;
public class ButtonBuyControl : MonoBehaviour
{    public void sdfea()
    {
        if (PlayerPrefs.GetInt("diamond") >= asdwqed)
        {
            PlayerPrefs.SetInt(asdw, PlayerPrefs.GetInt(asdw,1) + 1);
            PlayerPrefs.SetInt("diamond", PlayerPrefs.GetInt("diamond") - asdwqed);
            if (xzcve != null)
            {
                xzcve.text = PlayerPrefs.GetInt("diamond") + "";
            }
        }
        else
        {
            xcved.SetActive(true);
            xcver.SetActive(false);
        }
    }    public void sdsdfe()
    {
        if (PlayerPrefs.GetInt("diamond") >= asdwqed)
        {
            PlayerPrefs.SetInt(asdw, PlayerPrefs.GetInt(asdw,1) + 1);
            PlayerPrefs.SetInt("diamond", PlayerPrefs.GetInt("diamond") - asdwqed);
            if (xzcve != null)
            {
                xzcve.text = PlayerPrefs.GetInt("diamond") + "";
            }
        }
        else
        {
            xcved.SetActive(true);
            xcver.SetActive(false);
        }
    }

    [FormerlySerializedAs("_str")] public string asdw;
    [FormerlySerializedAs("price")] public int asdwqed;
	[FormerlySerializedAs("priceLb")] public Text xcve;
    [FormerlySerializedAs("popUp")] public GameObject xcved;
	[FormerlySerializedAs("Shop")] public GameObject xcver;
	[FormerlySerializedAs("_txt")] public Text xzcve;

    public void sdfe()
    {
        if (PlayerPrefs.GetInt("diamond") >= asdwqed)
        {
            PlayerPrefs.SetInt(asdw, PlayerPrefs.GetInt(asdw,1) + 1);
            PlayerPrefs.SetInt("diamond", PlayerPrefs.GetInt("diamond") - asdwqed);
            if (xzcve != null)
            {
                xzcve.text = PlayerPrefs.GetInt("diamond") + "";
            }
        }
        else
        {
            xcved.SetActive(true);
			xcver.SetActive(false);
        }
    }

}
