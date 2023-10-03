using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Serialization;

public class FishManage : MonoBehaviour
{
    public void ChangeaasdsdToBonusww()
    {
        Norasdwmal.SetActive(false);
        Bonasdwus.SetActive(false);

        Instantiate(waasdwve, new Vector2(8, 0), Quaternion.identity);
        asdw_stt = asdqqww.asdqwbonus;
        Invoke("activeeffwaaaaave", 0.2f);
    }
    void activeeffwaaaaaave()
    {
        efasdwfwave.SetActive(true);
    }

    public void BonuwsasdwTime()
    {
        Norasdwmal.SetActive(false);
        Bonasdwus.SetActive(true);
        Invoke("enchasdweck", 2);
    }

    void enchaqsdweck()
    {
        _checasdwkTimeBonus = true;
    }
    public enum asdqqww
    {
        norasdwal,
        asdqwbonus
    }

    [FormerlySerializedAs("Normal")] public GameObject Norasdwmal;
    [FormerlySerializedAs("Bonus")] public GameObject Bonasdwus;

    [FormerlySerializedAs("wave")] public GameObject waasdwve;
    [FormerlySerializedAs("effwave")] public GameObject efasdwfwave;

    [FormerlySerializedAs("_stt")] public asdqqww asdw_stt;

    public static FishManage Insasdwtance;
    [FormerlySerializedAs("_FishMange")] public List<Transform> _FiasdwshMange;
    [FormerlySerializedAs("_CaMapManage")] public List<Transform> _CaMasdwapManage;
    [FormerlySerializedAs("_MucManager")] public List<Transform> _MucManasdwager;

    bool _checasdwkTimeBonus;

    void Start()
    {
        Insasdwtance = this;
        _FiasdwshMange = new List<Transform>();
        _CaMasdwapManage = new List<Transform>();
        _MucManasdwager = new List<Transform>();
        _checasdwkTimeBonus = false;

    }
    void Update()
    {
        if (_checasdwkTimeBonus && Bonasdwus.activeInHierarchy)
        {
            if (_FiasdwshMange.Count == 0)
            {
                Norasdwmal.SetActive(true);
                Bonasdwus.SetActive(false);
                _checasdwkTimeBonus = false;
                _FiasdwshMange.Clear();
            }
        }
    }

    public void ChangeasdToBonusww()
    {
        Norasdwmal.SetActive(false);
        Bonasdwus.SetActive(false);

        Instantiate(waasdwve, new Vector2(8, 0), Quaternion.identity);
        asdw_stt = asdqqww.asdqwbonus;
        Invoke("activeeffwaaaaave", 0.2f);
    }
    void activeeffwaaaaave()
    {
        efasdwfwave.SetActive(true);
    }

    public void BonusasdwTime()
    {
        Norasdwmal.SetActive(false);
        Bonasdwus.SetActive(true);
        Invoke("enchasdweck", 2);
    }

    void enchasdweck()
    {
        _checasdwkTimeBonus = true;
    }
}
