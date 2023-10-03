using UnityEngine;
using System.Collections;
using DarkTonic.MasterAudio;

public class AudioControl : MonoBehaviour
{
    public void sdfweee()
    {
        MasterAudio.StopAllOfSound("bg" + sdfewq);
    }

    public void shootqsdfe()
    {
        if (asdfaswed)
        {
            MasterAudio.PlaySound("shot");
        }
    }

    public void clickBuwettonsdfe()
    {
        if (asdfaswed)
        {
            MasterAudio.PlaySound("button");
        }
    }

    public void nguyeqntusdfe()
    {
        if (asdfaswed)
        {
            MasterAudio.PlaySound("nguyentu");
        }
    }

    public void boomwesdfe()
    {
        if (asdfaswed)
        {
            MasterAudio.PlaySound("bom");
        }
    }

    public void coinasdfe()
    {
        if (asdfaswed)
        {
            MasterAudio.PlaySound("coin");
        }
    }

    public static bool asdfaswed = true;
    public static bool sdfe = true;
    public static AudioControl cvbdtfg;
    public static int sdfewq=1;

    void Awake()
    {
        cvbdtfg = this;
        DontDestroyOnLoad(gameObject);
    }

    public void openbgsdfe()
    {
        if (sdfe)
        {
            sdfewq = Random.Range(1, 5);
            MasterAudio.PlaySound("bg" + sdfewq);
        }
    }

    public void sdfee()
    {
        MasterAudio.StopAllOfSound("bg" + sdfewq);
    }

    public void shootsdfe()
    {
        if (asdfaswed)
        {
            MasterAudio.PlaySound("shot");
        }
    }

    public void clickButtonsdfe()
    {
        if (asdfaswed)
        {
            MasterAudio.PlaySound("button");
        }
    }

    public void nguyentusdfe()
    {
        if (asdfaswed)
        {
            MasterAudio.PlaySound("nguyentu");
        }
    }

    public void boomsdfe()
    {
        if (asdfaswed)
        {
            MasterAudio.PlaySound("bom");
        }
    }

    public void coinsdfe()
    {
        if (asdfaswed)
        {
            MasterAudio.PlaySound("coin");
        }
    }
}
