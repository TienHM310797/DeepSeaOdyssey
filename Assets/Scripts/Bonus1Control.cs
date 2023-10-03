using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class Bonus1Control : MonoBehaviour
{    IEnumerator asd112()
    {
        int directionPos = Random.Range(0, 2);
        switch (directionPos)
        {
            case 0:
                for (int i = 0; i < sdfwe.Length; i++)
                {
                    Transform _tr = Instantiate(sdfwe[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2(-asd123 - 1 - asdqwe23[i], _posY);
                    _tr.eulerAngles = Vector3.zero;
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollasdqwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case 1:
                for (int i = 0; i < sdfwe.Length; i++)
                {
                    Transform _tr = Instantiate(sdfwe[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2(asd123 + 1 + asdqwe23[i], _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 180);
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollasdqwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
        }
    }    IEnumerator aqsd12()
    {
        int directionPos = Random.Range(0, 2);
        switch (directionPos)
        {
            case 0:
                for (int i = 0; i < sdfwe.Length; i++)
                {
                    Transform _tr = Instantiate(sdfwe[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2(-asd123 - 1 - asdqwe23[i], _posY);
                    _tr.eulerAngles = Vector3.zero;
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollasdqwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case 1:
                for (int i = 0; i < sdfwe.Length; i++)
                {
                    Transform _tr = Instantiate(sdfwe[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2(asd123 + 1 + asdqwe23[i], _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 180);
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollasdqwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
        }
    }

    [FormerlySerializedAs("_prefab")] public GameObject[] sdfwe;
    [FormerlySerializedAs("_distance")] public float[] asdqwe23;
    float sdfcv3;
    float asd123;

    void OnEnable()
    {
        sdfcv3 = (Screen.height) / 200;
        asd123 = (Screen.width) / 200;
        StartCoroutine(asd12());
    }

    IEnumerator asd12()
    {
        int directionPos = Random.Range(0, 2);
        switch (directionPos)
        {
            case 0:
                for (int i = 0; i < sdfwe.Length; i++)
                {
                    Transform _tr = Instantiate(sdfwe[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2(-asd123 - 1 - asdqwe23[i], _posY);
                    _tr.eulerAngles = Vector3.zero;
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollasdqwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case 1:
                for (int i = 0; i < sdfwe.Length; i++)
                {
                    Transform _tr = Instantiate(sdfwe[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2(asd123 + 1 + asdqwe23[i], _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 180);
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollasdqwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
        }
    }
}
