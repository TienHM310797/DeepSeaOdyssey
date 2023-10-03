using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class FishControl : MonoBehaviour
{    public void CollisaiasdwonWithWave()
    {
        if (_casdwallDie != null)
        {
            _casdwallDie();
        }
        FishManage.Insasdwtance._FiasdwshMange.Remove(transform);
        Destroy(gameObject);


    }


    void OnBecameVsdisible()
    {
        if (gameObject.tag == "fish")
        {
            if (_checksdfe4Invisible) return;
            _checksdfe4Invisible = true;
            FishManage.Insasdwtance._FiasdwshMange.Add(transform);
            if (gameObject.name == "Fish12FreeSign(Clone)" || gameObject.name == "Fish11FreeSign(Clone)")
            {
                FishManage.Insasdwtance._CaMasdwapManage.Add(transform);
            }
            else
            {
                if (gameObject.name == "Fish7Follow(Clone)" || gameObject.name == "Fish7FollowBonus(Clone)" || gameObject.name == "Fish7FreeSign(Clone)" || gameObject.name == "Fish6Follow(Clone)" || gameObject.name == "Fish6FollowBonus(Clone)" || gameObject.name == "Fish6FreeSign(Clone)")
                {
                    FishManage.Insasdwtance._MucManasdwager.Add(transform);
                }
            }
        }
    }

    void OnDaestroy()
    {
        if (gameObject.tag == "fish")
        {
            FishManage.Insasdwtance._FiasdwshMange.Remove(transform);
            if (gameObject.name == "Fish12FreeSign(Clone)" || gameObject.name == "Fish11FreeSign(Clone)")
            {
                FishManage.Insasdwtance._CaMasdwapManage.Remove(transform);
            }
            else
            {
                if (gameObject.name == "Fish7Follow(Clone)" || gameObject.name == "Fish7FollowBonus(Clone)" || gameObject.name == "Fish7FreeSign(Clone)" || gameObject.name == "Fish6Follow(Clone)" || gameObject.name == "Fish6FollowBonus(Clone)" || gameObject.name == "Fish6FreeSign(Clone)")
                {
                    FishManage.Insasdwtance._MucManasdwager.Remove(transform);
                }
            }
        }
    }

    void OnBecameInvsdisible()
    {
        if (gameObject.tag == "fish")
        {
            FishManage.Insasdwtance._FiasdwshMange.Remove(transform);
            if (gameObject.name == "Fish12FreeSign(Clone)" || gameObject.name == "Fish11FreeSign(Clone)")
            {
                FishManage.Insasdwtance._CaMasdwapManage.Remove(transform);
            }
            else
            {
                if (gameObject.name == "Fish7Follow(Clone)" || gameObject.name == "Fish7FollowBonus(Clone)" || gameObject.name == "Fish7FreeSign(Clone)" || gameObject.name == "Fish6Follow(Clone)" || gameObject.name == "Fish6FollowBonus(Clone)" || gameObject.name == "Fish6FreeSign(Clone)")
                {
                    FishManage.Insasdwtance._MucManasdwager.Remove(transform);
                }
            }
        }
        Destroy(gameObject);

    }

    [FormerlySerializedAs("AnimationName")] public string asdqwe;
    [FormerlySerializedAs("AnimationNameDie")] public string sdfe;
    Animator _sdfeani;

    [FormerlySerializedAs("Hp")] public int Hsdfep;
    [FormerlySerializedAs("RndHp")] public int sdfee;

    [FormerlySerializedAs("HpMax")] public int sdf33;
    [FormerlySerializedAs("RndHpMax")] public int sdf33r5;

    Swim asdf3;
    int _dfe4hp;
    GameObject sdf3;

    bool _checksdfe4Invisible;

    public delegate void Casdf3llDie();
    public Casdf3llDie _casdwallDie;

    [FormerlySerializedAs("_gold")] public int asdw_gold;

    void OnEnable()
    {
        _checksdfe4Invisible = false;
        _sdfeani = GetComponent<Animator>();
        _sdfeani.Play(asdqwe, 0, Random.Range(0f, 1f));

        asdf3 = GetComponent<Swim>();

        if (Random.Range(0, 2) == 1)
            _dfe4hp = Random.Range(sdf33 - sdf33r5, sdf33 + sdf33r5);
        else
            _dfe4hp = Random.Range(Hsdfep - sdfee, Hsdfep - sdfee);
    }

    public void hitasdwDame(int dame, GameObject obj)
    {
        if (sdf3 == null || (sdf3.GetInstanceID() != obj.GetInstanceID()))
        {
            _dfe4hp -= dame;
            sdf3 = obj;

            if (_dfe4hp <= 0)
            {
                if (_casdwallDie != null)
                {
                    _casdwallDie();
                }
                asdf3.enabled = false;
                _sdfeani.Play(sdfe, 0, 0);
                GetComponent<BoxCollider2D>().enabled = false;
                Instantiate(Resources.Load("coinEff"), transform.position + Vector3.up * 0.5f, Quaternion.identity);
                UiTextSpawmControl.asd.CallTextasd(transform.position + Vector3.up * 0.5f, asdw_gold);
                FishManage.Insasdwtance._FiasdwshMange.Remove(transform);
                Destroy(gameObject, 0.8f);
            }
        }
    }

    public void CollisiasdwonWithWave()
    {
        if (_casdwallDie != null)
        {
            _casdwallDie();
        }
        FishManage.Insasdwtance._FiasdwshMange.Remove(transform);
        Destroy(gameObject);


    }


    void OnBecameVisible()
    {
        if (gameObject.tag == "fish")
        {
            if (_checksdfe4Invisible) return;
            _checksdfe4Invisible = true;
            FishManage.Insasdwtance._FiasdwshMange.Add(transform);
            if (gameObject.name == "Fish12FreeSign(Clone)" || gameObject.name == "Fish11FreeSign(Clone)")
            {
                FishManage.Insasdwtance._CaMasdwapManage.Add(transform);
            }
            else
            {
                if (gameObject.name == "Fish7Follow(Clone)" || gameObject.name == "Fish7FollowBonus(Clone)" || gameObject.name == "Fish7FreeSign(Clone)" || gameObject.name == "Fish6Follow(Clone)" || gameObject.name == "Fish6FollowBonus(Clone)" || gameObject.name == "Fish6FreeSign(Clone)")
                {
                    FishManage.Insasdwtance._MucManasdwager.Add(transform);
                }
            }
        }
    }

    void OnDestroy()
    {
        if (gameObject.tag == "fish")
        {
            FishManage.Insasdwtance._FiasdwshMange.Remove(transform);
            if (gameObject.name == "Fish12FreeSign(Clone)" || gameObject.name == "Fish11FreeSign(Clone)")
            {
                FishManage.Insasdwtance._CaMasdwapManage.Remove(transform);
            }
            else
            {
                if (gameObject.name == "Fish7Follow(Clone)" || gameObject.name == "Fish7FollowBonus(Clone)" || gameObject.name == "Fish7FreeSign(Clone)" || gameObject.name == "Fish6Follow(Clone)" || gameObject.name == "Fish6FollowBonus(Clone)" || gameObject.name == "Fish6FreeSign(Clone)")
                {
                    FishManage.Insasdwtance._MucManasdwager.Remove(transform);
                }
            }
        }
    }

    void OnBecameInvisible()
    {
        if (gameObject.tag == "fish")
        {
            FishManage.Insasdwtance._FiasdwshMange.Remove(transform);
            if (gameObject.name == "Fish12FreeSign(Clone)" || gameObject.name == "Fish11FreeSign(Clone)")
            {
                FishManage.Insasdwtance._CaMasdwapManage.Remove(transform);
            }
            else
            {
                if (gameObject.name == "Fish7Follow(Clone)" || gameObject.name == "Fish7FollowBonus(Clone)" || gameObject.name == "Fish7FreeSign(Clone)" || gameObject.name == "Fish6Follow(Clone)" || gameObject.name == "Fish6FollowBonus(Clone)" || gameObject.name == "Fish6FreeSign(Clone)")
                {
                    FishManage.Insasdwtance._MucManasdwager.Remove(transform);
                }
            }
        }
        Destroy(gameObject);

    }
}
