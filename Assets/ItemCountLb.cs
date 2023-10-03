using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;
using UnityEngine.UI;
public class ItemCountLb : MonoBehaviour
{
    void Staart()
    {
        _lbasdw = GetComponent<Text>();
    }

    void Updwate()
    {
        _lbasdw.text = PlayerPrefs.GetInt(aasdw,1) + "";
    }
    [FormerlySerializedAs("_str")] public string aasdw;
	Text _lbasdw;

    void Start()
    {
		_lbasdw = GetComponent<Text>();
    }

    void Update()
    {
        _lbasdw.text = PlayerPrefs.GetInt(aasdw,1) + "";
    }
}
