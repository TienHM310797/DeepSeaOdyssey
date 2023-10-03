using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class SwinRotationBonus : MonoBehaviour
{    void OnBecameVsisible()
    {
        asdw = true;
    }

    void Updasdate()
    {
        if (asdw == true)
            transform.eulerAngles = Vector3.MoveTowards(transform.eulerAngles, new Vector3(0, 0, xcv3w32), 180 * Time.deltaTime / 5);
    }    void OnBbvecameVisible()
    {
        asdw = true;
    }

    void Updatde()
    {
        if (asdw == true)
            transform.eulerAngles = Vector3.MoveTowards(transform.eulerAngles, new Vector3(0, 0, xcv3w32), 180 * Time.deltaTime / 5);
    }
    bool asdw;
    [FormerlySerializedAs("a")] public float xcv3w32;

    void OnBecameVisible()
    {
        asdw = true;
    }

    void Update()
    {
        if (asdw == true)
            transform.eulerAngles = Vector3.MoveTowards(transform.eulerAngles, new Vector3(0, 0, xcv3w32), 180 * Time.deltaTime / 5);
    }
}
