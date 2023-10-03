using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class FishFlockControl : MonoBehaviour
{
    void asdqww()
    {
        this.enabled = false;
    }


    void Updaate()
    {
        if (_trLeaderasdw == null)
            return;
        DirectionToLeaderasdw = _trLeaderasdw.position - _tasdw.position;
        DirectionToLeaderasdw.z = 0;

        _tasdw.right = _trLeaderasdw.right * 384f + (DirectionToLeaderasdw.magnitude / CohesionDiasdwstance * DirectionToLeaderasdw) + DirectionRndForcesdww;

        if (IsRotasdwating)
        {
            AngleasdwActiveRotate += aasdw * Time.deltaTime;
            DirectionRndForcesdww = Quaternion.Euler(0, 0, AngleasdwActiveRotate) * RndForceasdwRotate;
            ElapsasseRotate += Time.deltaTime;

            if (ElapsasseRotate > TimeRasdwotate)
            {
                IsRotasdwating = false;
                ElapsasseRotate = 0;
            }
        }
        else
        {
            asdwrvalRotate += Time.deltaTime;
            if (asdwrvalRotate > asdwlRotate)
            {
                IsRotasdwating = true;
                asdwlRotate = Random.Range(0.1f, 2.5f);
                aasdw = (Random.Range(0, 2) == 0 ? -1f : 1f) * asdwSpeedRotate;
                asdwrvalRotate = 0;
            }
        }
    }
    void OnBecameInvissdible()
    {
        if (_folasdq != null)
            _folasdq.destroasdwyOnList(transform);
    }

    public void SetLeasaadwader(Transform _leader)
    {
        _trLeaderasdw = _leader;
        _swimLeadersdfe = _leader.GetComponent<Swim>();
        _folasdq = _leader.GetComponent<FishFlockLeaderControl>();
        CohesionDiasdwstance = asdqwe + _swimLeadersdfe.BoundasdwCircleRadius + _swimasdq.BoundasdwCircleRadius;

    }
    [FormerlySerializedAs("DistanceToLeader")] public float asdqwe = 50;

    Swim _swimLeadersdfe;
    FishControl _fishControlasdw;
    Transform _trLeaderasdw;


    FishFlockLeaderControl _folasdq;
    private Swim _swimasdq;
    private Transform _tasdw;
    private Vector3 DirectionRndForcesdww;

    float CohesionDiasdwstance;
    Vector3 DirectionToLeaderasdw;

    float ElapsasseRotate;
    float TimeRasdwotate = 1;
    float asdwSpeedRotate = 180;
    float AngleasdwActiveRotate;
    bool IsRotasdwating;

    Vector3 RndForceasdwRotate;
    float aasdw;

    float asdwrvalRotate;
    float asdwlRotate;


    void OnEnable()
    {
        _swimasdq = GetComponent<Swim>();
        _fishControlasdw = GetComponent<FishControl>();
        _tasdw = transform;

        _fishControlasdw._casdwallDie += asdw;

        IsRotasdwating = true;

        TimeRasdwotate = 1;
        asdwSpeedRotate = 180;

        RndForceasdwRotate = Random.insideUnitCircle.normalized * 96;
        asdwlRotate = Random.Range(0.1f, 2.5f);
        aasdw = (Random.Range(0, 2) == 0 ? -1f : 1f) * asdwSpeedRotate;
    }

    void asdw()
    {
        this.enabled = false;
    }


    void Update()
    {
        if (_trLeaderasdw == null)
            return;
        DirectionToLeaderasdw = _trLeaderasdw.position - _tasdw.position;
        DirectionToLeaderasdw.z = 0;

        _tasdw.right = _trLeaderasdw.right * 384f + (DirectionToLeaderasdw.magnitude / CohesionDiasdwstance * DirectionToLeaderasdw) + DirectionRndForcesdww;

        if (IsRotasdwating)
        {
            AngleasdwActiveRotate += aasdw * Time.deltaTime;
            DirectionRndForcesdww = Quaternion.Euler(0, 0, AngleasdwActiveRotate) * RndForceasdwRotate;
            ElapsasseRotate += Time.deltaTime;

            if (ElapsasseRotate > TimeRasdwotate)
            {
                IsRotasdwating = false;
                ElapsasseRotate = 0;
            }
        }
        else
        {
            asdwrvalRotate += Time.deltaTime;
            if (asdwrvalRotate > asdwlRotate)
            {
                IsRotasdwating = true;
                asdwlRotate = Random.Range(0.1f, 2.5f);
                aasdw = (Random.Range(0, 2) == 0 ? -1f : 1f) * asdwSpeedRotate;
                asdwrvalRotate = 0;
            }
        }
    }
    void OnBecameInvisible()
    {
        if (_folasdq != null)
            _folasdq.destroasdwyOnList(transform);
    }

    public void SetLeasdwader(Transform _leader)
    {
        _trLeaderasdw = _leader;
        _swimLeadersdfe = _leader.GetComponent<Swim>();
        _folasdq = _leader.GetComponent<FishFlockLeaderControl>();
        CohesionDiasdwstance = asdqwe + _swimLeadersdfe.BoundasdwCircleRadius + _swimasdq.BoundasdwCircleRadius;

    }
}
