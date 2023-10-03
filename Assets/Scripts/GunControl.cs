using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class GunControl : MonoBehaviour
{    public void fChangt22oRvbocasdketa()
    {
        _checkasd2fire = false;
        LeanTween.scale(gameObject, Vector3.zero, 0.5f).setOnComplete(() =>
        {

            GetComponent<SpriteRenderer>().enabled = false;
            _checkasd2fire = true;
            _teasd2nlua = true;
        });
        asdfc32.SetActive(true);
        asdfc32.transform.localScale = Vector3.zero;
        asdfc32.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        asdfc32.transform.up = Vector3.up;
        LeanTween.scale(asdfc32, new Vector3(1, 1, 1), 0.5f).setEase(LeanTweenType.easeOutBack);

    }    public void fChangtsd22oRocasdketa()
    {
        _checkasd2fire = false;
        LeanTween.scale(gameObject, Vector3.zero, 0.5f).setOnComplete(() =>
        {

            GetComponent<SpriteRenderer>().enabled = false;
            _checkasd2fire = true;
            _teasd2nlua = true;
        });
        asdfc32.SetActive(true);
        asdfc32.transform.localScale = Vector3.zero;
        asdfc32.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        asdfc32.transform.up = Vector3.up;
        LeanTween.scale(asdfc32, new Vector3(1, 1, 1), 0.5f).setEase(LeanTweenType.easeOutBack);

    }    public void fChanagt22oRocasdketa()
    {
        _checkasd2fire = false;
        LeanTween.scale(gameObject, Vector3.zero, 0.5f).setOnComplete(() =>
        {

            GetComponent<SpriteRenderer>().enabled = false;
            _checkasd2fire = true;
            _teasd2nlua = true;
        });
        asdfc32.SetActive(true);
        asdfc32.transform.localScale = Vector3.zero;
        asdfc32.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        asdfc32.transform.up = Vector3.up;
        LeanTween.scale(asdfc32, new Vector3(1, 1, 1), 0.5f).setEase(LeanTweenType.easeOutBack);

    }
    public static GunControl asdw;
    [FormerlySerializedAs("Bullet")] public GameObject azsdwew;
    public static int Bonusasd2Coin;
    [FormerlySerializedAs("tenlua")] public GameObject asdfc32;
    [FormerlySerializedAs("_effboom")] public GameObject xcv331;
    

    bool _checkasd2fire;
    bool _teasd2nlua;
    Animator _anasd2i;
    int _levasd2elGun;

    void Start()
    {
        _checkasd2fire = true;
        _teasd2nlua = false;
        asdw = this;
        _anasd2i = GetComponent<Animator>();
        _anasd2i.Play("Idle", 0, 0);
        _anasd2i.SetFloat("level", 0);
        _anasd2i.speed = 2;
        _levasd2elGun = 1;
        Bonusasd2Coin = 1;
    }


    public void Pluasd2sGun()
    {
        if (!_checkasd2fire) return;
        if (_levasd2elGun < 9)
            _levasd2elGun += 1;
        else
            _levasd2elGun = 1;

        _anasd2i.SetFloat("level", _levasd2elGun);
    }

    public void Minasd2usGun()
    {
        if (!_checkasd2fire) return;
        if (_levasd2elGun > 1)
            _levasd2elGun -= 1;
        else
            _levasd2elGun = 9;

        _anasd2i.SetFloat("level", _levasd2elGun);
    }

    public void Fireasd2()
    {
		
        Vector3 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.up = Vector3.Normalize(mousePoint + Vector3.forward * 10 - transform.position);
		if (PlayerPrefs.GetInt("gold", 450) < _levasd2elGun && _teasd2nlua == false){
			UIManager.Insasdqqqance.sdfepUpCoin();
		}
        else
        {
            if (PlayerPrefs.GetInt("gold", 450) >= _levasd2elGun && _checkasd2fire && _teasd2nlua == false)
            {
                _anasd2i.Play("Fire", 0, 0);
                AudioControl.cvbdtfg.shootsdfe();
                GameObject _bullet = (GameObject)Instantiate(azsdwew);
                _bullet.transform.position = transform.position + transform.up * 0.5f;
                _bullet.GetComponent<BulletControl>().awww1sd(_levasd2elGun, transform, new Vector2(mousePoint.x, mousePoint.y));

                UiTextSpawmControl.asd.MinusGoldasd(_levasd2elGun);
            }
        }
        if (_teasd2nlua && _checkasd2fire)
        {
            _teasd2nlua = false;
            asdfc32.transform.up = Vector3.Normalize(mousePoint + Vector3.forward * 10 - asdfc32.transform.position);
            _checkasd2fire = false;
            LeanTween.move(asdfc32, new Vector3(mousePoint.x, mousePoint.y, 0), 0.2f * (Vector2.Distance(mousePoint, asdfc32.transform.position))).setOnComplete(() =>
            {
                RaycastHit2D[] fish = Physics2D.CircleCastAll(new Vector3(asdfc32.transform.position.x, asdfc32.transform.position.y, 0), 2, Vector3.zero);
                AudioControl.cvbdtfg.boomsdfe();
                for (int i = 0; i < fish.Length; i++)
                {
                    if (fish[i].collider.tag == "fish")
                        fish[i].collider.gameObject.GetComponent<FishControl>().hitasdwDame(1000, gameObject);
                }
                GameObject boom = (GameObject)Instantiate(xcv331, asdfc32.transform.position + asdfc32.transform.up * 0.5f, Quaternion.identity);
                Destroy(boom, 1.5f);
                asdfc32.SetActive(false);
                GetComponent<SpriteRenderer>().enabled = true;
                transform.up = Vector3.up;
                transform.localScale = Vector3.zero;
                LeanTween.scale(gameObject, new Vector3(1, 1, 1), 0.5f).setEase(LeanTweenType.easeOutBack).setOnComplete(() =>
                {
                    _checkasd2fire = true;
                });
            });
        }
    }

    public void fChangt22oRocasdketa()
    {
        _checkasd2fire = false;
        LeanTween.scale(gameObject, Vector3.zero, 0.5f).setOnComplete(() =>
        {

            GetComponent<SpriteRenderer>().enabled = false;
            _checkasd2fire = true;
            _teasd2nlua = true;
        });
        asdfc32.SetActive(true);
        asdfc32.transform.localScale = Vector3.zero;
        asdfc32.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        asdfc32.transform.up = Vector3.up;
        LeanTween.scale(asdfc32, new Vector3(1, 1, 1), 0.5f).setEase(LeanTweenType.easeOutBack);

    }

}
