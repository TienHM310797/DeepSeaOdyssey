using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class UiTextSpawmControl : MonoBehaviour
{    public void PushGoas12ddld(int gold)
	{
		PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold",450) + gold);
		TextGasdfas.text = "" + PlayerPrefs.GetInt("gold",450);
	}

	public void MinusGoldaasd(int gold)
	{
		PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) - gold);
		TextGasdfas.text = "" + PlayerPrefs.GetInt("gold",450);
	}    public void PushGosdsasdld(int gold)
	{
		PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold",450) + gold);
		TextGasdfas.text = "" + PlayerPrefs.GetInt("gold",450);
	}

	public void MinusGocxvldasd(int gold)
	{
		PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) - gold);
		TextGasdfas.text = "" + PlayerPrefs.GetInt("gold",450);
	}    public void PushGcoasdld(int gold)
	{
		PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold",450) + gold);
		TextGasdfas.text = "" + PlayerPrefs.GetInt("gold",450);
	}

	public void MinusGcvoldasd(int gold)
	{
		PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) - gold);
		TextGasdfas.text = "" + PlayerPrefs.GetInt("gold",450);
	}

    [FormerlySerializedAs("_UiRoot")] public GameObject asdq;
    [FormerlySerializedAs("_TextChil")] public GameObject _TextChixcvel;
	[FormerlySerializedAs("TextGold")] public Text TextGasdfas;

	[FormerlySerializedAs("EXPbar")] public Image EXasdf;
	[FormerlySerializedAs("TextLevel")] public Text Teasds;
    [FormerlySerializedAs("RocketImg")] public Image Rockasd;
	[FormerlySerializedAs("TextDiamond")] public Text TextDaszdws;

    public static UiTextSpawmControl asd;

    void Start()
    {
		
        asd = this;
        TextGasdfas.text = "" + PlayerPrefs.GetInt("gold", 450);
		TextDaszdws.text = "" + PlayerPrefs.GetInt("diamond",0);
        EXasdf.fillAmount = PlayerPrefs.GetFloat("EXP") / (450 + 500 * PlayerPrefs.GetInt("level", 1));
        Teasds.text = PlayerPrefs.GetInt("level", 1) + "";
    }

    public void CallTextasd(Vector3 _pos, int gold)
    {
		if(asdq.activeSelf){
			GameObject obj = NGUITools.AddChild(asdq, _TextChixcvel);
			obj.GetComponent<effScoreTextControl>().asdwwfddv(_pos, gold);
		}
       
        PlayerPrefs.SetFloat("EXP", PlayerPrefs.GetFloat("EXP") + gold);
        EXasdf.fillAmount = PlayerPrefs.GetFloat("EXP") / (450 + 500 * PlayerPrefs.GetInt("level", 1));
        Rockasd.fillAmount += (float)((float)gold / 1000);
        if (Rockasd.fillAmount == 1)
        {
            GunControl.asdw.fChangt22oRocasdketa();
            Rockasd.fillAmount = 0;
        }

        if (EXasdf.fillAmount == 1)
		{
			PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level", 1) + 1);
			int level = PlayerPrefs.GetInt("level");
			if(level<3){
				PlayerPrefs.SetInt("diamond",5);
			}else{
				PlayerPrefs.SetInt("diamond",PlayerPrefs.GetInt("diamond") + (level -1));
			}
            PlayerPrefs.SetFloat("EXP", 0);
            Teasds.text = PlayerPrefs.GetInt("level", 1) + "";
			TextDaszdws.text = PlayerPrefs.GetInt("diamond") + "";
            FishManage.Insasdwtance.ChangeasdToBonusww();
        }
    }

    public void PushGoasdld(int gold)
    {
        PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold",450) + gold);
        TextGasdfas.text = "" + PlayerPrefs.GetInt("gold",450);
    }

    public void MinusGoldasd(int gold)
    {
        PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) - gold);
        TextGasdfas.text = "" + PlayerPrefs.GetInt("gold",450);
    }
}
