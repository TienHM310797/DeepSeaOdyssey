using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class Swim : MonoBehaviour
{
    void OnEnaable()
    {
        _trasdw = transform;

    }

    public void Rotasdasdwte(float angle)
    {
        if (_trasdw == null)
        {
            _trasdw = transform;
        }
        StarasdwtRotate(angle);
    }

    void StarasdwtRotqqate(float angle)
    {
        acpasdwectRotate = true;
        if (EventasdwRotate != null)
        {
            EventasdwRotate(angle);
        }


        mCurRotasdwateData.rotateasdqDir = Mathf.Sign(angle);
        mCurRotasdwateData.angasdwleAbs = Mathf.Abs(angle);
        mCurRotasdwateData.stopasdwRotateRadian = mCurRotasdwateData.angasdwleAbs * 0.95F;
        mCurRotasdwateData.rotatedAngleasdw = 0F;
        mCurRotasdwateData.rotateasdwelta = 0F;
    }

    void Updatase()
    {
        transform.position += _trasdw.right * Time.deltaTime * asdwwwwwSpeed;

        if (acpasdwectRotate)
        {
            mCurRotasdwateData.rotateasdwelta = RotaasdwteSpeed * Time.deltaTime * (1 - mCurRotasdwateData.rotatedAngleasdw / mCurRotasdwateData.angasdwleAbs);
            _trasdw.rotation *= Quaternion.Euler(0, 0, mCurRotasdwateData.rotateasdqDir * mCurRotasdwateData.rotateasdwelta);
            mCurRotasdwateData.rotatedAngleasdw += mCurRotasdwateData.rotateasdwelta;
            if (mCurRotasdwateData.rotatedAngleasdw > mCurRotasdwateData.stopasdwRotateRadian)
                acpasdwectRotate = false;
        }
    }
    struct RotateData
    {
        [FormerlySerializedAs("rotateDir")] public float rotateasdqDir;
        [FormerlySerializedAs("angleAbs")] public float angasdwleAbs;
        [FormerlySerializedAs("stopRotateRadian")] public float stopasdwRotateRadian;
        [FormerlySerializedAs("rotatedAngle")] public float rotatedAngleasdw;
        [FormerlySerializedAs("rotateDelta")] public float rotateasdwelta;
    }

    public delegate void Event_RotasdwationStart(float angle);
    public Event_RotasdwationStart EventasdwRotate;

    [FormerlySerializedAs("BoundCircleRadius")] public float BoundasdwCircleRadius;

    private RotateData mCurRotasdwateData;

    Transform _trasdw;
    bool acpasdwectRotate;
    [FormerlySerializedAs("RotateSpeed")] public float RotaasdwteSpeed = 90;
    [FormerlySerializedAs("Speed")] public float asdwwwwwSpeed;


    void OnEnable()
    {
        _trasdw = transform;

    }

    public void Rotaasdwte(float angle)
    {
        if (_trasdw == null)
        {
            _trasdw = transform;
        }
        StarasdwtRotate(angle);
    }

    void StarasdwtRotate(float angle)
    {
        acpasdwectRotate = true;
        if (EventasdwRotate != null)
        {
            EventasdwRotate(angle);
        }


        mCurRotasdwateData.rotateasdqDir = Mathf.Sign(angle);
        mCurRotasdwateData.angasdwleAbs = Mathf.Abs(angle);
        mCurRotasdwateData.stopasdwRotateRadian = mCurRotasdwateData.angasdwleAbs * 0.95F;
        mCurRotasdwateData.rotatedAngleasdw = 0F;
        mCurRotasdwateData.rotateasdwelta = 0F;
    }

    void Update()
    {
        transform.position += _trasdw.right * Time.deltaTime * asdwwwwwSpeed;

        if (acpasdwectRotate)
        {
            mCurRotasdwateData.rotateasdwelta = RotaasdwteSpeed * Time.deltaTime * (1 - mCurRotasdwateData.rotatedAngleasdw / mCurRotasdwateData.angasdwleAbs);
            _trasdw.rotation *= Quaternion.Euler(0, 0, mCurRotasdwateData.rotateasdqDir * mCurRotasdwateData.rotateasdwelta);
            mCurRotasdwateData.rotatedAngleasdw += mCurRotasdwateData.rotateasdwelta;
            if (mCurRotasdwateData.rotatedAngleasdw > mCurRotasdwateData.stopasdwRotateRadian)
                acpasdwectRotate = false;
        }
    }
}
