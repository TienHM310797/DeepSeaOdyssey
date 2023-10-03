using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class Bonus3Control : MonoBehaviour
{
    IEnumerator aSDS2()
    {
        int directionPos = Random.Range(0, 2);
        switch (directionPos)
        {
            case 0:
                for (int i = 0; i < asdqwe3.Length; i++)
                {
                    int a = 1;
                    if (i <= (int)asdqwe3.Length / 2)
                    {
                        a = 1;
                    }
                    else
                        a = -1;
                    Transform _tr = Instantiate(asdqwe3[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((-limitWithasd2 - 1 - ad45[i]) * a, _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 0 + 90 - (90 * a));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollasdqwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case 1:
                for (int i = 0; i < asdqwe3.Length; i++)
                {
                    int a = 1;
                    if (i <= (int)asdqwe3.Length / 2)
                    {
                        a = 1;
                    }
                    else
                        a = -1;
                    Transform _tr = Instantiate(asdqwe3[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((limitWithasd2 + 1 + ad45[i]) * a, _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 90 + (90 * a));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollasdqwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
        }
    }
    
    [FormerlySerializedAs("_prefab")] public GameObject[] asdqwe3;
    [FormerlySerializedAs("_distance")] public float[] ad45;
    float dfg43;
    float limitWithasd2;

    void OnEnable()
    {
        dfg43 = (Screen.height) / 200;
        limitWithasd2 = (Screen.width) / 200;
        StartCoroutine(aSD2());
    }

    IEnumerator aSD2()
    {
        int directionPos = Random.Range(0, 2);
        switch (directionPos)
        {
            case 0:
                for (int i = 0; i < asdqwe3.Length; i++)
                {
                    int a = 1;
                    if (i <= (int)asdqwe3.Length / 2)
                    {
                        a = 1;
                    }
                    else
                        a = -1;
                    Transform _tr = Instantiate(asdqwe3[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((-limitWithasd2 - 1 - ad45[i]) * a, _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 0 + 90 - (90 * a));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollasdqwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
            case 1:
                for (int i = 0; i < asdqwe3.Length; i++)
                {
                    int a = 1;
                    if (i <= (int)asdqwe3.Length / 2)
                    {
                        a = 1;
                    }
                    else
                        a = -1;
                    Transform _tr = Instantiate(asdqwe3[i]).transform;
                    float _posY = -2.1f + (1 * i);
                    _tr.position = new Vector2((limitWithasd2 + 1 + ad45[i]) * a, _posY);
                    _tr.eulerAngles = new Vector3(0, 0, 90 + (90 * a));
                    _tr.GetComponent<FishFollowLeaderBonusControl>().FollasdqwowStart();
                    yield return new WaitForSeconds(0.5f);
                }
                break;
        }
    }
}
