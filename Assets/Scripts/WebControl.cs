using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class WebControl : MonoBehaviour
{
    public void IniaqsdwtWeb(int level)
    {
        _sprasdite.sprite = asdqqwew[level - 1];
        _Collasdwider.radius = asdwListRadius[level - 1];
        asdwdame = level + Random.Range(0, 1);
        if (level > 7)
        {
            asdwdame = asdwdame + 7 - level;
        }
        Invoke("asdwwwDisableCollision", 0.1f);
        LeanTween.scale(gameObject, new Vector2(1, 1), 0.4f).setEase(LeanTweenType.easeOutElastic).setOnComplete(() =>
        {
            Destroy(gameObject, 0.5f);
        });
    }

    void asdwwwDiwesableCollision()
    {
        _Collasdwider.enabled = false;
    }

    void OnTriggerEnteqqr2D(Collider2D col)
    {
        if (col.gameObject.tag == "fish")
        {
            col.GetComponent<FishControl>().hitasdwDame(asdwdame, gameObject);
        }
    }    public void IniasdwewtWeb(int level)
    {
        _sprasdite.sprite = asdqqwew[level - 1];
        _Collasdwider.radius = asdwListRadius[level - 1];
        asdwdame = level + Random.Range(0, 1);
        if (level > 7)
        {
            asdwdame = asdwdame + 7 - level;
        }
        Invoke("asdwwwDisableCollision", 0.1f);
        LeanTween.scale(gameObject, new Vector2(1, 1), 0.4f).setEase(LeanTweenType.easeOutElastic).setOnComplete(() =>
        {
            Destroy(gameObject, 0.5f);
        });
    }

    void asdwwwDisableCollwision()
    {
        _Collasdwider.enabled = false;
    }

    void OnTriggerEntear2D(Collider2D col)
    {
        if (col.gameObject.tag == "fish")
        {
            col.GetComponent<FishControl>().hitasdwDame(asdwdame, gameObject);
        }
    }
    [FormerlySerializedAs("ListWeb")] public Sprite[] asdqqwew;
    [FormerlySerializedAs("ListRadius")] public float[] asdwListRadius;

    SpriteRenderer _sprasdite;
    CircleCollider2D _Collasdwider;

    int asdwdame;


    void Awake()
    {
        _sprasdite = GetComponent<SpriteRenderer>();
        _Collasdwider = GetComponent<CircleCollider2D>();
    }

    public void IniasdwtWeb(int level)
    {
        _sprasdite.sprite = asdqqwew[level - 1];
        _Collasdwider.radius = asdwListRadius[level - 1];
        asdwdame = level + Random.Range(0, 1);
        if (level > 7)
        {
            asdwdame = asdwdame + 7 - level;
        }
        Invoke("asdwwwDisableCollision", 0.1f);
        LeanTween.scale(gameObject, new Vector2(1, 1), 0.4f).setEase(LeanTweenType.easeOutElastic).setOnComplete(() =>
        {
            Destroy(gameObject, 0.5f);
        });
    }

    void asdwwwDisableCollision()
    {
        _Collasdwider.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "fish")
        {
            col.GetComponent<FishControl>().hitasdwDame(asdwdame, gameObject);
        }
    }


}
