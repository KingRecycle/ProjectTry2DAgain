using UnityEngine;

public class Grenade : MonoBehaviour
{
    public float FuseTime = 5f;
    public LayerMask hitLayers;

    void Start()
    {
    }

    void Update()
    {
        if (FuseTime > 0)
        {
            FuseTime -= Time.deltaTime;
        }
        else if (FuseTime <= 0)
        {
            Explode();
        }
    }

    void Explode()
    {
        HitReturn[] _hits = HitDetection.CircleHits(transform.position, 2f, hitLayers);

        for (int i = 0; i < _hits.Length; i++)
        {
            if (_hits[i] != null)
            {
                _hits[i].gameObject.GetComponent<PlayerStats>().TakeDamage(5);
                Debug.Log(_hits[i].gameObject.name);
            }
        }

        Destroy(transform.gameObject);
    }
}