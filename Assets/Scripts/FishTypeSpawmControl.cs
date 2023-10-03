using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class FishTypeSpawmControl : MonoBehaviour
{
    void OnEnsdfable()
    {
        StartCoroutine(spawmsdf3(vcb3));
    }

    IEnumerator spawddmsdf3(float starttimesdf3)
    {
        yield return new WaitForSeconds(starttimesdf3);

        int a = Random.Range(0, asdw.Length);
        Transform _tr = Instantiate(asdw[a]).transform;
        int directionPos = Random.Range(0, 4);
        switch (directionPos)
        {
            case 0:
                float _posY0 = Random.Range(-limitHieghtasdf + 1, limitHieghtasdf - 1);
                _tr.position = new Vector2(-limitWithsdfe - 1 - sdf3, _posY0);
                if (_posY0 < -limitHieghtasdf / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(25, 65));
                }
                else
                {
                    if (_posY0 > limitHieghtasdf / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-65, -25));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-45, 45));
                    }
                }
                break;

            case 1:
                float _posX1 = Random.Range(-limitWithsdfe + 1, limitWithsdfe - 1);
                _tr.position = new Vector2(_posX1, limitHieghtasdf + 1 + sdf3);
                if (_posX1 < -limitWithsdfe / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(295, 335));
                }
                else
                {
                    if (_posX1 > limitWithsdfe / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-155, -115));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-135, -35));
                    }
                }
                break;

            case 2:

                float _posX2 = Random.Range(-limitWithsdfe + 1, limitWithsdfe - 1);
                _tr.position = new Vector2(_posX2, -limitHieghtasdf - 1 - sdf3);
                if (_posX2 < -limitWithsdfe / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(25, 65));
                }
                else
                {
                    if (_posX2 > limitWithsdfe / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(115, 155));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(35, 145));
                    }
                }
                break;

            case 3:
                float _posY3 = Random.Range(-limitHieghtasdf + 1, limitHieghtasdf - 1);
                _tr.position = new Vector2(limitWithsdfe + 1 + sdf3, _posY3);
                if (_posY3 < -limitHieghtasdf / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(115, 165));
                }
                else
                {
                    if (_posY3 > limitHieghtasdf / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(205, 245));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(135, 235));
                    }
                }
                break;
        }

        switch (a)
        {
            case 2:
                _tr.GetComponent<FishFlockLeaderControl>().asawewq();
                break;
            case 1:
                _tr.GetComponent<FishFollowLeaderControl>().WwsdfFollowStart();
                break;
        }

        yield return new WaitForSeconds(sdf33);
        StartCoroutine(spawmsdf3(0));
    }
    [FormerlySerializedAs("_pre")] public GameObject[] asdw;
    [FormerlySerializedAs("countTime")] public float sdf33;
    [FormerlySerializedAs("RndCountTime")] public float sdfe;
    [FormerlySerializedAs("StartWaitTime")] public float vcb3;

    public static FishTypeSpawmControl bvrfts;

    [FormerlySerializedAs("_distance")] public float sdf3 = 0;

    float limitHieghtasdf;
    float limitWithsdfe;

    public void Start()
    {

        limitHieghtasdf = (Screen.height) / 200;
        limitWithsdfe = (Screen.width) / 200;
        bvrfts = this;
    }

    void OnEnable()
    {
        StartCoroutine(spawmsdf3(vcb3));
    }

    IEnumerator spawmsdf3(float starttimesdf3)
    {
        yield return new WaitForSeconds(starttimesdf3);

        int a = Random.Range(0, asdw.Length);
        Transform _tr = Instantiate(asdw[a]).transform;
        int directionPos = Random.Range(0, 4);
        switch (directionPos)
        {
            case 0:
                float _posY0 = Random.Range(-limitHieghtasdf + 1, limitHieghtasdf - 1);
                _tr.position = new Vector2(-limitWithsdfe - 1 - sdf3, _posY0);
                if (_posY0 < -limitHieghtasdf / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(25, 65));
                }
                else
                {
                    if (_posY0 > limitHieghtasdf / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-65, -25));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-45, 45));
                    }
                }
                break;

            case 1:
                float _posX1 = Random.Range(-limitWithsdfe + 1, limitWithsdfe - 1);
                _tr.position = new Vector2(_posX1, limitHieghtasdf + 1 + sdf3);
                if (_posX1 < -limitWithsdfe / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(295, 335));
                }
                else
                {
                    if (_posX1 > limitWithsdfe / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-155, -115));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(-135, -35));
                    }
                }
                break;

            case 2:

                float _posX2 = Random.Range(-limitWithsdfe + 1, limitWithsdfe - 1);
                _tr.position = new Vector2(_posX2, -limitHieghtasdf - 1 - sdf3);
                if (_posX2 < -limitWithsdfe / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(25, 65));
                }
                else
                {
                    if (_posX2 > limitWithsdfe / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(115, 155));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(35, 145));
                    }
                }
                break;

            case 3:
                float _posY3 = Random.Range(-limitHieghtasdf + 1, limitHieghtasdf - 1);
                _tr.position = new Vector2(limitWithsdfe + 1 + sdf3, _posY3);
                if (_posY3 < -limitHieghtasdf / 2)
                {
                    _tr.eulerAngles = new Vector3(0, 0, Random.Range(115, 165));
                }
                else
                {
                    if (_posY3 > limitHieghtasdf / 2)
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(205, 245));
                    }
                    else
                    {
                        _tr.eulerAngles = new Vector3(0, 0, Random.Range(135, 235));
                    }
                }
                break;
        }

        switch (a)
        {
            case 2:
                _tr.GetComponent<FishFlockLeaderControl>().asawewq();
                break;
            case 1:
                _tr.GetComponent<FishFollowLeaderControl>().WwsdfFollowStart();
                break;
        }

        yield return new WaitForSeconds(sdf33);
        StartCoroutine(spawmsdf3(0));
    }
}
