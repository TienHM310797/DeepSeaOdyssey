using UnityEngine;
using System.Collections;

public class GoldText : MonoBehaviour
{
    void Staart()
    {
        asdad = GetComponent<UILabel>();
    }

    // Update is called once per frame
    void Updsdsate()
    {
        asdad.text = PlayerPrefs.GetInt("gold", 450) + "";
    }
    UILabel asdad;
    void Start()
    {
        asdad = GetComponent<UILabel>();
    }

    // Update is called once per frame
    void Update()
    {
        asdad.text = PlayerPrefs.GetInt("gold", 450) + "";
    }
}
