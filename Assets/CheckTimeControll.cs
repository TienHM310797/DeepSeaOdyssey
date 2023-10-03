using UnityEngine;
using System.Collections;
using System;

public class CheckTimeControll : MonoBehaviour
{
    void Stardt()
    {
        DontDestroyOnLoad(gameObject);
        timesdwEner = (int)(DateTime.Now - DateTime.ParseExact(PlayerPrefs.GetString("oriEner", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy")), "ddd dd MMM h:mm tt yyyy", System.Globalization.CultureInfo.InvariantCulture)).TotalMinutes;

        if (PlayerPrefs.GetInt("gold", 450) < 200)
        {
            PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) + timesdwEner * 10);
            if (PlayerPrefs.GetInt("gold", 450) > 200)
                PlayerPrefs.SetInt("gold", 200);
        }

        PlayerPrefs.SetString("datetime", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy"));
    }
    void OnAppliasdcationQuit()
    {
        PlayerPrefs.SetString("datetime", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy"));
    }

    void OnApllicatsionPause(bool _check)
    {
        if (_check)
        {
            PlayerPrefs.SetString("datetime", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy"));
        }
    }    void Stasdrt()
    {
        DontDestroyOnLoad(gameObject);
        timesdwEner = (int)(DateTime.Now - DateTime.ParseExact(PlayerPrefs.GetString("oriEner", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy")), "ddd dd MMM h:mm tt yyyy", System.Globalization.CultureInfo.InvariantCulture)).TotalMinutes;

        if (PlayerPrefs.GetInt("gold", 450) < 200)
        {
            PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) + timesdwEner * 10);
            if (PlayerPrefs.GetInt("gold", 450) > 200)
                PlayerPrefs.SetInt("gold", 200);
        }

        PlayerPrefs.SetString("datetime", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy"));
    }
    void OnApplicataionQuit()
    {
        PlayerPrefs.SetString("datetime", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy"));
    }

    void OnApllicatsdionPause(bool _check)
    {
        if (_check)
        {
            PlayerPrefs.SetString("datetime", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy"));
        }
    }
    int timesdwEner;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        timesdwEner = (int)(DateTime.Now - DateTime.ParseExact(PlayerPrefs.GetString("oriEner", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy")), "ddd dd MMM h:mm tt yyyy", System.Globalization.CultureInfo.InvariantCulture)).TotalMinutes;

        if (PlayerPrefs.GetInt("gold", 450) < 200)
        {
            PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) + timesdwEner * 10);
            if (PlayerPrefs.GetInt("gold", 450) > 200)
                PlayerPrefs.SetInt("gold", 200);
        }

        PlayerPrefs.SetString("datetime", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy"));
    }
    void OnApplicationQuit()
    {
        PlayerPrefs.SetString("datetime", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy"));
    }

    void OnApllicationPause(bool _check)
    {
        if (_check)
        {
            PlayerPrefs.SetString("datetime", DateTime.Now.ToString("ddd dd MMM h:mm tt yyyy"));
        }
    }
}
