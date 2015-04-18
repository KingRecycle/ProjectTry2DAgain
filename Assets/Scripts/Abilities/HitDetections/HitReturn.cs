using UnityEngine;

public class HitReturn
{
    public GameObject gameObject;
    public RaycastHit2D hit2D;
    public string tag;

    public HitReturn(GameObject GOHit, string HitTag, RaycastHit2D hit)
    {
        gameObject = GOHit;
        hit2D = hit;
        tag = HitTag;
    }

    public HitReturn(GameObject GOHit, string HitTag)
    {
        gameObject = GOHit;
        tag = HitTag;
    }
}