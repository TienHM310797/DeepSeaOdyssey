using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Serialization;

public class FishFollowLeaderControl : MonoBehaviour
{
    public void WwsdfFoallowStart()
    {
        _swimasdq = GetComponent<Swim>();
        asdqwe = new List<Transform>();
        asdqwwe1 = Random.Range(minCountasdq, maasdqxCount);
        for (int i = 0; i < asdqwwe1; i++)
        {
            Transform _tr = Instantiate(_FishPreasdq).transform;
            _tr.position = Vector3.zero;
            _tr.position = transform.position - transform.right * Distanasdq * i;
            _tr.right = transform.right;
            _tr.GetComponent<FishFollowControl>().SetTaasdqrget(transform, Vector3.Magnitude(transform.right * Distanasdq * i));
            _tr.GetComponent<Swim>().asdwwwwwSpeed = _swimasdq.asdwwwwwSpeed;
            asdqwe.Add(_tr);
        }
    }

    public void destroyasdqsdOnList(Transform _trsasdq)
    {
        asdqwe.Remove(_trsasdq);

        if (asdqwe.Count == 0)
        {
            Destroy(gameObject);
        }
    }
    List<Transform> asdqwe;
    int asdqwwe1 = 1;
    [FormerlySerializedAs("_FishPre")] public GameObject _FishPreasdq;
    [FormerlySerializedAs("Distan")] public float Distanasdq = 0.5f;
    Swim _swimasdq;

    [FormerlySerializedAs("minCount")] public int minCountasdq;
    [FormerlySerializedAs("maxCount")] public int maasdqxCount;

    public void WwsdfFollowStart()
    {
        _swimasdq = GetComponent<Swim>();
        asdqwe = new List<Transform>();
        asdqwwe1 = Random.Range(minCountasdq, maasdqxCount);
        for (int i = 0; i < asdqwwe1; i++)
        {
            Transform _tr = Instantiate(_FishPreasdq).transform;
            _tr.position = Vector3.zero;
            _tr.position = transform.position - transform.right * Distanasdq * i;
            _tr.right = transform.right;
            _tr.GetComponent<FishFollowControl>().SetTaasdqrget(transform, Vector3.Magnitude(transform.right * Distanasdq * i));
            _tr.GetComponent<Swim>().asdwwwwwSpeed = _swimasdq.asdwwwwwSpeed;
            asdqwe.Add(_tr);
        }
    }

    public void destroyasdqOnList(Transform _trsasdq)
    {
        asdqwe.Remove(_trsasdq);

        if (asdqwe.Count == 0)
        {
            Destroy(gameObject);
        }
    }
}
