using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class BulletControl : MonoBehaviour
{

    void Awaasdke()
    {
        _spriteasdw = GetComponent<SpriteRenderer>();
    }

    public void awwws1sd(int asdw, Transform sdq, Vector2 target)
    {
        _spriteasdw.sprite = this.asdw[asdw - 1];
        transform.up = sdq.up;
        LeanTween.move(gameObject, target, asdwqe*(Vector2.Distance(target,transform.position))).setOnComplete(() =>
        {
            GameObject web = (GameObject)Instantiate(_asdweb);
            web.transform.position = transform.position;
            web.transform.up = transform.up;
            web.GetComponent<WebControl>().IniasdwtWeb(asdw);
            Destroy(gameObject);
        });
    }
    void Awaaske()
    {
        _spriteasdw = GetComponent<SpriteRenderer>();
    }

    public void awsww1sd(int asdw, Transform sdq, Vector2 target)
    {
        _spriteasdw.sprite = this.asdw[asdw - 1];
        transform.up = sdq.up;
        LeanTween.move(gameObject, target, asdwqe*(Vector2.Distance(target,transform.position))).setOnComplete(() =>
        {
            GameObject web = (GameObject)Instantiate(_asdweb);
            web.transform.position = transform.position;
            web.transform.up = transform.up;
            web.GetComponent<WebControl>().IniasdwtWeb(asdw);
            Destroy(gameObject);
        });
    }
    [FormerlySerializedAs("ListBullet")] public Sprite[] asdw;
    [FormerlySerializedAs("speed")] public float asdwqe;
    [FormerlySerializedAs("_web")] public GameObject _asdweb;

    SpriteRenderer _spriteasdw;
    

    void Awake()
    {
        _spriteasdw = GetComponent<SpriteRenderer>();
    }

    public void awww1sd(int asdw, Transform sdq, Vector2 target)
    {
        _spriteasdw.sprite = this.asdw[asdw - 1];
        transform.up = sdq.up;
        LeanTween.move(gameObject, target, asdwqe*(Vector2.Distance(target,transform.position))).setOnComplete(() =>
        {
            GameObject web = (GameObject)Instantiate(_asdweb);
            web.transform.position = transform.position;
            web.transform.up = transform.up;
            web.GetComponent<WebControl>().IniasdwtWeb(asdw);
            Destroy(gameObject);
        });
    }

   

}
