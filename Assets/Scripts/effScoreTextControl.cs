using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class effScoreTextControl : MonoBehaviour
{
    public void asdwwfdasdwdv(Vector3 _trs, int gold)
    {
		
        asdw_lb.text = "+" + gold;
        switch (GunControl.Bonusasd2Coin)
        {
            case 2:
                asdw_lb.text += "x" + GunControl.Bonusasd2Coin;
                break;
            case 3:
                asdw_lb.text += "x" + GunControl.Bonusasd2Coin;
                break;
        }
        uasdwiCam = GameObject.FindObjectOfType<UICamera>().GetComponent<Camera>();
        Vector3 a = _trs;
        a = Camera.main.WorldToScreenPoint(a);
        a = uasdwiCam.ScreenToWorldPoint(a);
        transform.position = a;
        LeanTween.move(gameObject, a + Vector3.up * 0.1f, 0.8f).setOnComplete(() =>
        {
            Destroy(gameObject);
            UiTextSpawmControl.asd.PushGoasdld(gold * GunControl.Bonusasd2Coin);
        });
    }    public void asdwwsdafddv(Vector3 _trs, int gold)
    {
		
        asdw_lb.text = "+" + gold;
        switch (GunControl.Bonusasd2Coin)
        {
            case 2:
                asdw_lb.text += "x" + GunControl.Bonusasd2Coin;
                break;
            case 3:
                asdw_lb.text += "x" + GunControl.Bonusasd2Coin;
                break;
        }
        uasdwiCam = GameObject.FindObjectOfType<UICamera>().GetComponent<Camera>();
        Vector3 a = _trs;
        a = Camera.main.WorldToScreenPoint(a);
        a = uasdwiCam.ScreenToWorldPoint(a);
        transform.position = a;
        LeanTween.move(gameObject, a + Vector3.up * 0.1f, 0.8f).setOnComplete(() =>
        {
            Destroy(gameObject);
            UiTextSpawmControl.asd.PushGoasdld(gold * GunControl.Bonusasd2Coin);
        });
    }
    Camera uasdwiCam;
    [FormerlySerializedAs("_lb")] public UILabel asdw_lb;
    public void asdwwfddv(Vector3 _trs, int gold)
    {
		
        asdw_lb.text = "+" + gold;
        switch (GunControl.Bonusasd2Coin)
        {
            case 2:
                asdw_lb.text += "x" + GunControl.Bonusasd2Coin;
                break;
            case 3:
                asdw_lb.text += "x" + GunControl.Bonusasd2Coin;
                break;
        }
        uasdwiCam = GameObject.FindObjectOfType<UICamera>().GetComponent<Camera>();
        Vector3 a = _trs;
        a = Camera.main.WorldToScreenPoint(a);
        a = uasdwiCam.ScreenToWorldPoint(a);
        transform.position = a;
        LeanTween.move(gameObject, a + Vector3.up * 0.1f, 0.8f).setOnComplete(() =>
        {
            Destroy(gameObject);
            UiTextSpawmControl.asd.PushGoasdld(gold * GunControl.Bonusasd2Coin);
        });
    }


}
