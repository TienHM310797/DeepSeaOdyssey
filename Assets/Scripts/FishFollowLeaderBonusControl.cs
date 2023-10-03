using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Serialization;

public class FishFollowLeaderBonusControl : MonoBehaviour
{
    
    public void FollasdqwaowStart()
    {
        _sasdqwim = GetComponent<Swim>();

        _asdqwfish = new List<Transform>();
        for (int i = 0; i < casdqountFish; i++)
        {
            Transform _tr = Instantiate(_FisasdqhPre).transform;
            _tr.position = Vector3.zero;
            _tr.position = transform.position - transform.right * Diasdqwstan * i;
            _tr.right = transform.right;
            _tr.GetComponent<FishFollowBonusControl>().SetTasdwqqqrget(transform, Vector3.Magnitude(transform.right * Diasdqwstan * i));
            _tr.GetComponent<Swim>().asdwwwwwSpeed = _sasdqwim.asdwwwwwSpeed;
            _asdqwfish.Add(_tr);
        }
    }

    public void deasdqstroyOwwnList(Transform _trs)
    {//asd
        _asdqwfish.Remove(_trs);

        if (_asdqwfish.Count == 0)
        {
            Destroy(gameObject);
        }
    }

    List<Transform> _asdqwfish;
    [FormerlySerializedAs("countFish")] public int casdqountFish = 1;
    [FormerlySerializedAs("_FishPre")] public GameObject _FisasdqhPre;
    [FormerlySerializedAs("Distan")] public float Diasdqwstan = 0.5f;
    Swim _sasdqwim;

    public void FollasdqwowStart()
    {
        _sasdqwim = GetComponent<Swim>();

        _asdqwfish = new List<Transform>();
        for (int i = 0; i < casdqountFish; i++)
        {
            Transform _tr = Instantiate(_FisasdqhPre).transform;
            _tr.position = Vector3.zero;
            _tr.position = transform.position - transform.right * Diasdqwstan * i;
            _tr.right = transform.right;
            _tr.GetComponent<FishFollowBonusControl>().SetTasdwqqqrget(transform, Vector3.Magnitude(transform.right * Diasdqwstan * i));
            _tr.GetComponent<Swim>().asdwwwwwSpeed = _sasdqwim.asdwwwwwSpeed;
            _asdqwfish.Add(_tr);
        }
    }

    public void deasdqstroyOnList(Transform _trs)
    {
        _asdqwfish.Remove(_trs);

        if (_asdqwfish.Count == 0)
        {
            Destroy(gameObject);
        }
    }
}
