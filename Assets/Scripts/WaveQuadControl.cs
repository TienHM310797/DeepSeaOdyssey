using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class WaveQuadControl : MonoBehaviour
{    void Sstart()
    {
        rasdqen = GetComponent<MeshRenderer>();
        rasdqen.material.mainTextureOffset = new Vector2(0, 0);
        rasdqen.sortingOrder = 1;
        rasdqen.sortingLayerName = "bg";
    }

    void Updaete()
    {
        rasdqen.material.mainTextureOffset = new Vector2(Mathf.Repeat(Time.timeSinceLevelLoad * spasdqeed / 20, 1), 0);
    }    void Stavbrt()
    {
        rasdqen = GetComponent<MeshRenderer>();
        rasdqen.material.mainTextureOffset = new Vector2(0, 0);
        rasdqen.sortingOrder = 1;
        rasdqen.sortingLayerName = "bg";
    }

    void Updatvbere()
    {
        rasdqen.material.mainTextureOffset = new Vector2(Mathf.Repeat(Time.timeSinceLevelLoad * spasdqeed / 20, 1), 0);
    }    void Starqt()
    {
        rasdqen = GetComponent<MeshRenderer>();
        rasdqen.material.mainTextureOffset = new Vector2(0, 0);
        rasdqen.sortingOrder = 1;
        rasdqen.sortingLayerName = "bg";
    }

    void Upasdate()
    {
        rasdqen.material.mainTextureOffset = new Vector2(Mathf.Repeat(Time.timeSinceLevelLoad * spasdqeed / 20, 1), 0);
    }

    [FormerlySerializedAs("speed")] public float spasdqeed;
    Renderer rasdqen;

    void Start()
    {
        rasdqen = GetComponent<MeshRenderer>();
        rasdqen.material.mainTextureOffset = new Vector2(0, 0);
        rasdqen.sortingOrder = 1;
        rasdqen.sortingLayerName = "bg";
    }

    void Update()
    {
        rasdqen.material.mainTextureOffset = new Vector2(Mathf.Repeat(Time.timeSinceLevelLoad * spasdqeed / 20, 1), 0);
    }
}
