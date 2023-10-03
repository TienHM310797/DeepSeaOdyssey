using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class FishSignFreeControl : MonoBehaviour
{
    void OnEnaable()
    {
        dfgew = GetComponent<FishControl>();
        if (gameObject.tag == "fish")
            dfgew._casdwallDie += calldidfgre;
        fghrew = GetComponent<Swim>();
        TidfgrmeRotate = asdq + Random.Range(-sdfsdfe, sdfsdfe);
    }

    void calsdldidfgre()
    {
        this.enabled = false;
    }

    void Upadate()
    {
        if (ElapseRdfgrotate > TidfgrmeRotate)
        {
            fghrew.Rotaasdwte(Random.Range(-xfdghfgh, xfdghfgh));
            ElapseRdfgrotate = 0;
            TidfgrmeRotate = asdq + Random.Range(-sdfsdfe, sdfsdfe);
        }
        else
        {
            ElapseRdfgrotate += Time.deltaTime;
        }
    }
    [FormerlySerializedAs("RotateInterval")] public float asdq = 5;
    [FormerlySerializedAs("RotateIntervalRndRange")] public float sdfsdfe = 1;
    [FormerlySerializedAs("RotateAngleRndRange")] public float xfdghfgh = 30;

    private Swim fghrew;
    private FishControl dfgew;

    private float TidfgrmeRotate;
    private float ElapseRdfgrotate;

    void OnEnable()
    {
        dfgew = GetComponent<FishControl>();
        if (gameObject.tag == "fish")
            dfgew._casdwallDie += calldidfgre;
        fghrew = GetComponent<Swim>();
        TidfgrmeRotate = asdq + Random.Range(-sdfsdfe, sdfsdfe);
    }

    void calldidfgre()
    {
        this.enabled = false;
    }

    void Update()
    {
        if (ElapseRdfgrotate > TidfgrmeRotate)
        {
            fghrew.Rotaasdwte(Random.Range(-xfdghfgh, xfdghfgh));
            ElapseRdfgrotate = 0;
            TidfgrmeRotate = asdq + Random.Range(-sdfsdfe, sdfsdfe);
        }
        else
        {
            ElapseRdfgrotate += Time.deltaTime;
        }
    }
}
