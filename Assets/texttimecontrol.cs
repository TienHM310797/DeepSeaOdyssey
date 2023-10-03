using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;
using UnityEngine.UI;
public class texttimecontrol : MonoBehaviour
{
    void Staart()
    {
        asdqwe = 60;
        _tsdfehis = GetComponent<Text>();
        StartCoroutine(timesdfwe());
    }

    IEnumerator timeqsdfwe()
    {
        yield return new WaitForSeconds(1);
        if (asdqwe > 0)
        {
            asdqwe -= 1;
            _tsdfehis.text = asdqwe + "";
        }
        else
        {
            
            PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) + 10);
            sdfelb.text = PlayerPrefs.GetInt("gold", 450) + "";
            asdqwe = 60;
            
        }
        StartCoroutine(timesdfwe());
    }
    float asdqwe;
	[FormerlySerializedAs("_lb")] public Text sdfelb;
	Text _tsdfehis;

    void Start()
    {
        asdqwe = 60;
		_tsdfehis = GetComponent<Text>();
        StartCoroutine(timesdfwe());
    }

    IEnumerator timesdfwe()
    {
        yield return new WaitForSeconds(1);
        if (asdqwe > 0)
        {
            asdqwe -= 1;
            _tsdfehis.text = asdqwe + "";
        }
        else
        {
            
                PlayerPrefs.SetInt("gold", PlayerPrefs.GetInt("gold", 450) + 10);
                sdfelb.text = PlayerPrefs.GetInt("gold", 450) + "";
                asdqwe = 60;
            
        }
        StartCoroutine(timesdfwe());
    }

}
