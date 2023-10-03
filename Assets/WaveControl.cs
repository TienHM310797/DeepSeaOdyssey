using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class WaveControl : MonoBehaviour {
    
    void Updasate () {
        transform.Translate(Vector3.left * speedsdfwer * Time.smoothDeltaTime);
    }

    void OnBecamesdInvisible()
    {
        FishManage.Insasdwtance.BonusasdwTime();
        gameObject.SetActive(false);
    }

    void OnTriqwggerEnter2D(Collider2D col)
    {
        if (col.tag == "fish")
        {
            col.GetComponent<FishControl>().CollisiasdwonWithWave();
        }
    }
    [FormerlySerializedAs("speed")] public float speedsdfwer = 2;

	void Update () {
        transform.Translate(Vector3.left * speedsdfwer * Time.smoothDeltaTime);
	}

    void OnBecameInvisible()
    {
        FishManage.Insasdwtance.BonusasdwTime();
        gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "fish")
        {
            col.GetComponent<FishControl>().CollisiasdwonWithWave();
        }
    }
}
