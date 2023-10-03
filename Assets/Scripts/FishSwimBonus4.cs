using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Serialization;

public class FishSwimBonus4 : MonoBehaviour
{
    void Updaasdte()
    {
        // transform.eulerAngles = Vector3.MoveTowards(transform.eulerAngles, new Vector3(0, 0, 270), 180 * Time.deltaTime / 5);
    }

    public void destroasdwssyOnList(Transform _trs)
    {
        sdfwer.Remove(_trs);

        if (sdfwer.Count == 0)
        {
            Destroy(gameObject);
        }
    }    void Upd121ate()
    {
        // transform.eulerAngles = Vector3.MoveTowards(transform.eulerAngles, new Vector3(0, 0, 270), 180 * Time.deltaTime / 5);
    }

    public void destrocfasdwyOnList(Transform _trs)
    {
        sdfwer.Remove(_trs);

        if (sdfwer.Count == 0)
        {
            Destroy(gameObject);
        }
    }
    Swim asdw;

    List<Transform> sdfwer;
    [FormerlySerializedAs("countFish")] public int sdfe = 1;
    [FormerlySerializedAs("_FishPre")] public GameObject _FisdfeshPre;
    [FormerlySerializedAs("Distan")] public float Didfeeestan = 0.5f;

    public void QwasddfsaStartBonus4(float sdfwesdf, float sdfe)
    {
        asdw = GetComponent<Swim>();
        asdw.asdwwwwwSpeed = ((Mathf.PI * sdfwesdf) / 5);
        asdw.RotaasdwteSpeed = 38;
        sdfwer = new List<Transform>();
        for (int i = 0; i < this.sdfe; i++)
        {
            Transform _tr = Instantiate(_FisdfeshPre).transform;
            _tr.position = Vector3.zero;
            _tr.position = transform.position - transform.right * Didfeeestan * i;
            _tr.right = transform.right;
            _tr.GetComponent<FishFollowBonusControl>().SetTasdwqqqrget(transform, Vector3.Magnitude(transform.right * Didfeeestan * i));
            _tr.GetComponent<Swim>().asdwwwwwSpeed = asdw.asdwwwwwSpeed;
            _tr.GetComponent<Swim>().RotaasdwteSpeed = 38;
            if (sdfe == 0)
                _tr.gameObject.AddComponent<SwinRotationBonus>().xcv3w32 = 270;
            else
                _tr.gameObject.AddComponent<SwinRotationBonus>().xcv3w32 = 90;
            sdfwer.Add(_tr);
        }
        Destroy(gameObject);
    }

    void Update()
    {
        // transform.eulerAngles = Vector3.MoveTowards(transform.eulerAngles, new Vector3(0, 0, 270), 180 * Time.deltaTime / 5);
    }

    public void destroasdwyOnList(Transform _trs)
    {
        sdfwer.Remove(_trs);

        if (sdfwer.Count == 0)
        {
            Destroy(gameObject);
        }
    }
}
