using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class Bonus2Control : MonoBehaviour {
    IEnumerator asswd2()
    {
        int directionPos = Random.Range(0, 2);
        switch (directionPos)
        {
            case 0:
                for (int i = 0; i < asdw.Length; i++)
                {
                    Transform _tr = Instantiate(asdw[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((-asd3 - 1 - xcve[i])*Mathf.Pow(-1,i), _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 0 +90- (90 * Mathf.Pow(-1, i)));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollasdqwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case 1:
                for (int i = 0; i < asdw.Length; i++)
                {
                    Transform _tr = Instantiate(asdw[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((asd3 + 1 + xcve[i])*Mathf.Pow(-1,i), _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 90+(90 * Mathf.Pow(-1, i)));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollasdqwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
        }
    }IEnumerator adsd2()
    {
        int directionPos = Random.Range(0, 2);
        switch (directionPos)
        {
            case 0:
                for (int i = 0; i < asdw.Length; i++)
                {
                    Transform _tr = Instantiate(asdw[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((-asd3 - 1 - xcve[i])*Mathf.Pow(-1,i), _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 0 +90- (90 * Mathf.Pow(-1, i)));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollasdqwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case 1:
                for (int i = 0; i < asdw.Length; i++)
                {
                    Transform _tr = Instantiate(asdw[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((asd3 + 1 + xcve[i])*Mathf.Pow(-1,i), _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 90+(90 * Mathf.Pow(-1, i)));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollasdqwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
        }
    }
    [FormerlySerializedAs("_prefab")] public GameObject[] asdw;
    [FormerlySerializedAs("_distance")] public float[] xcve;
    float szdf3w;
    float asd3;

    void OnEnable()
    {
        szdf3w = (Screen.height) / 200;
        asd3 = (Screen.width) / 200;
        StartCoroutine(asd2());
    }

    IEnumerator asd2()
    {
        int directionPos = Random.Range(0, 2);
        switch (directionPos)
        {
            case 0:
                for (int i = 0; i < asdw.Length; i++)
                {
                    Transform _tr = Instantiate(asdw[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((-asd3 - 1 - xcve[i])*Mathf.Pow(-1,i), _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 0 +90- (90 * Mathf.Pow(-1, i)));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollasdqwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case 1:
                for (int i = 0; i < asdw.Length; i++)
                {
                    Transform _tr = Instantiate(asdw[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((asd3 + 1 + xcve[i])*Mathf.Pow(-1,i), _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 90+(90 * Mathf.Pow(-1, i)));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollasdqwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
        }
    }
}
