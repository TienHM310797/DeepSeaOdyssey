using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class Bonus4Control : MonoBehaviour
{
    void OnEnaasdble()
    {
        asdasd3 = Screen.height / 200;
        int a = Random.Range(0, 2);
        if (a == 0)
        {
            for (int i = 0; i < ASDQWE.Length; i++)
            {
                Transform _tr = Instantiate(ASDQWE[i]);

                _tr.position = new Vector2(2f + i, -asdasd3 - 2.5f);
                _tr.eulerAngles = new Vector3(0, 0, 90);

                _tr.GetComponent<FishSwimBonus4>().QwasddfsaStartBonus4(2f + i, a);
            }
        }
        else
        {
            for (int i = 0; i < ASDQWE.Length; i++)
            {
                Transform _tr = Instantiate(ASDQWE[i]);

                _tr.position = new Vector2(2f + i, asdasd3 + 2.5f);
                _tr.eulerAngles = new Vector3(0, 0, 270);

                _tr.GetComponent<FishSwimBonus4>().QwasddfsaStartBonus4(2f + i, a);
            }
        }
    }    void OnEasdnable()
    {
        asdasd3 = Screen.height / 200;
        int a = Random.Range(0, 2);
        if (a == 0)
        {
            for (int i = 0; i < ASDQWE.Length; i++)
            {
                Transform _tr = Instantiate(ASDQWE[i]);

                _tr.position = new Vector2(2f + i, -asdasd3 - 2.5f);
                _tr.eulerAngles = new Vector3(0, 0, 90);

                _tr.GetComponent<FishSwimBonus4>().QwasddfsaStartBonus4(2f + i, a);
            }
        }
        else
        {
            for (int i = 0; i < ASDQWE.Length; i++)
            {
                Transform _tr = Instantiate(ASDQWE[i]);

                _tr.position = new Vector2(2f + i, asdasd3 + 2.5f);
                _tr.eulerAngles = new Vector3(0, 0, 270);

                _tr.GetComponent<FishSwimBonus4>().QwasddfsaStartBonus4(2f + i, a);
            }
        }
    }
    [FormerlySerializedAs("_prefab")] public Transform[] ASDQWE;
    float asdasd3;

    void OnEnable()
    {
        asdasd3 = Screen.height / 200;
        int a = Random.Range(0, 2);
        if (a == 0)
        {
            for (int i = 0; i < ASDQWE.Length; i++)
            {
                Transform _tr = Instantiate(ASDQWE[i]);

                _tr.position = new Vector2(2f + i, -asdasd3 - 2.5f);
                _tr.eulerAngles = new Vector3(0, 0, 90);

                _tr.GetComponent<FishSwimBonus4>().QwasddfsaStartBonus4(2f + i, a);
            }
        }
        else
        {
            for (int i = 0; i < ASDQWE.Length; i++)
            {
                Transform _tr = Instantiate(ASDQWE[i]);

                _tr.position = new Vector2(2f + i, asdasd3 + 2.5f);
                _tr.eulerAngles = new Vector3(0, 0, 270);

                _tr.GetComponent<FishSwimBonus4>().QwasddfsaStartBonus4(2f + i, a);
            }
        }
    }
}
