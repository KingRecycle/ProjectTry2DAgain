using UnityEngine;

public static class HitDetection
{
    public static HitReturn RayHit(Transform transform, int direction, float range, LayerMask hitLayers)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(direction, 0), range, hitLayers);

        if (hit.collider != null)
        {
            HitReturn _hitReturn = new HitReturn(hit.collider.gameObject, hit.collider.gameObject.tag, hit);
            return _hitReturn;
        }
        else
        {
            return null;
        }
    }

    public static HitReturn[] BoxHits(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, LayerMask hitLayers)
    {
        HitReturn[] _hitReturns;
        RaycastHit2D[] _hits = Physics2D.BoxCastAll(origin, size, angle, direction, distance, hitLayers); //Grab hits in area
        _hitReturns = new HitReturn[_hits.Length]; //Match array lengths with _hits

        for (int i = 0; i < _hits.Length; i++) //Loop through hits and add them to HitReturn array
        {
            if (_hits[i].collider != null)
            {
                HitReturn _hitReturn = new HitReturn(_hits[i].collider.gameObject, _hits[i].collider.gameObject.tag, _hits[i]);
                _hitReturns[i] = _hitReturn;
            }
            else
            {
                _hitReturns[i] = null;
            }
        }
        return _hitReturns;
    }

    public static HitReturn[] CircleHits(Vector2 origin, float radius, LayerMask hitLayers)
    {
        HitReturn[] _hitReturns;
        Collider2D[] _hits = Physics2D.OverlapCircleAll(origin, radius, hitLayers);
        _hitReturns = new HitReturn[_hits.Length];

        for (int i = 0; i < _hits.Length; i++) //Loop through hits and add them to HitReturn array
        {
            if (_hits[i] != null)
            {
                HitReturn _hitReturn = new HitReturn(_hits[i].gameObject, _hits[i].gameObject.tag);
                Debug.Log(_hitReturn.gameObject);
                _hitReturns[i] = _hitReturn;
            }
            else
            {
                _hitReturns[i] = null;
            }
        }
        return _hitReturns;
    }
}