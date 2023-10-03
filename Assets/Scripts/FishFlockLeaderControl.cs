using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Serialization;

public class FishFlockLeaderControl : MonoBehaviour
{

    List<Transform> _fiasdwsh;
    int couasdwntFish = 1;
    [FormerlySerializedAs("_FishPre")] public GameObject _FiasdwshPre;

    [FormerlySerializedAs("minCount")] public int minCoasdwunt;
    [FormerlySerializedAs("maxCount")] public int maxasdwCount;

    public void asawewq()
    {
        _fiasdwsh = new List<Transform>();
        couasdwntFish = Random.Range(minCoasdwunt, maxasdwCount);
        for (int i = 0; i < couasdwntFish; i++)
        {
            Transform _tr = Instantiate(_FiasdwshPre).transform;
            _tr.GetComponent<FishFlockControl>().SetLeasdwader(transform);
            _fiasdwsh.Add(_tr);
            _tr.position = new Vector2(transform.position.x, transform.position.y) + Random.insideUnitCircle * 0.8f;
           // FishManage.Instance._FishMange.Add(_tr);
        }
    }

    public void destroasdwyOnList(Transform _tasdwrs)
    {
        _fiasdwsh.Remove(_tasdwrs);

        if (_fiasdwsh.Count == 0)
        {
                Destroy(gameObject);
        }
    }
}
