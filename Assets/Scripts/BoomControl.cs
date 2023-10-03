using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class BoomControl : MonoBehaviour
{    void Updatsde()
    {
        asdw3 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(asdw3.x, asdw3.y, -6);

        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit2D[] fish = Physics2D.CircleCastAll(new Vector3(transform.position.x, transform.position.y, 0), 2, Vector3.zero);
            AudioControl.cvbdtfg.boomsdfe();
            for (int i = 0; i < fish.Length; i++)
            {
                if (fish[i].collider.tag == "fish")
                    fish[i].collider.gameObject.GetComponent<FishControl>().hitasdwDame(1000, gameObject);
            }
            GameObject boom = (GameObject)Instantiate(asdqwe, transform.position, Quaternion.identity);
            Destroy(boom, 1.5f);
            Destroy(gameObject);
        }
    }    void Upadate()
    {
        asdw3 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(asdw3.x, asdw3.y, -6);

        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit2D[] fish = Physics2D.CircleCastAll(new Vector3(transform.position.x, transform.position.y, 0), 2, Vector3.zero);
            AudioControl.cvbdtfg.boomsdfe();
            for (int i = 0; i < fish.Length; i++)
            {
                if (fish[i].collider.tag == "fish")
                    fish[i].collider.gameObject.GetComponent<FishControl>().hitasdwDame(1000, gameObject);
            }
            GameObject boom = (GameObject)Instantiate(asdqwe, transform.position, Quaternion.identity);
            Destroy(boom, 1.5f);
            Destroy(gameObject);
        }
    }
    [FormerlySerializedAs("eff")] public GameObject asdqwe;
    Vector3 asdw3;
    void Update()
    {
        asdw3 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(asdw3.x, asdw3.y, -6);

        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit2D[] fish = Physics2D.CircleCastAll(new Vector3(transform.position.x, transform.position.y, 0), 2, Vector3.zero);
            AudioControl.cvbdtfg.boomsdfe();
            for (int i = 0; i < fish.Length; i++)
            {
                if (fish[i].collider.tag == "fish")
                    fish[i].collider.gameObject.GetComponent<FishControl>().hitasdwDame(1000, gameObject);
            }
            GameObject boom = (GameObject)Instantiate(asdqwe, transform.position, Quaternion.identity);
            Destroy(boom, 1.5f);
            Destroy(gameObject);
        }
    }
}
