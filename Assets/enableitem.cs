using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class enableitem : MonoBehaviour {
	void Staasdrt()
	{
		_asdwbox = GetComponent<Button>();
		_asdwspr = GetComponent<Image>();
	}


	void Updawwte()
	{
		if (GunControl.Bonusasd2Coin != 1 && _asdwbox.interactable)
		{
			_asdwbox.interactable = false;
			_asdwspr.color = new Color(0.3f, 0.3f, 0.3f, 1);
		}
		if (GunControl.Bonusasd2Coin == 1 && !_asdwbox.interactable)
		{
			_asdwbox.interactable = true;
			_asdwspr.color = new Color(1, 1, 1, 1);
		}
	}
	Button _asdwbox;
	Image _asdwspr;
    void Start()
    {
		_asdwbox = GetComponent<Button>();
		_asdwspr = GetComponent<Image>();
    }


    void Update()
    {
		if (GunControl.Bonusasd2Coin != 1 && _asdwbox.interactable)
        {
			_asdwbox.interactable = false;
			_asdwspr.color = new Color(0.3f, 0.3f, 0.3f, 1);
        }
		if (GunControl.Bonusasd2Coin == 1 && !_asdwbox.interactable)
        {
			_asdwbox.interactable = true;
            _asdwspr.color = new Color(1, 1, 1, 1);
        }
    }
}
