using System.Collections;
using UnityEngine;

public class DoubleTap : Ability
{
    bool isAttacking;

    // Use this for initialization
    public void Initialize()
    {
        //Name = "Double Tap";
        //Description = "You hit the trigger twice in succession. Deal 2x180%";
        //Cooldown = 0.2f;
        //Damage = Random.Range(1, 3);
    }

    IEnumerator DoubleShot(float time)
    {
        DubTap();
        yield return new WaitForSeconds(time);
        DubTap();
    }

    void DubTap()
    {
        if (!isAttacking)
        {
            isAttacking = true;

            HitReturn hit = HitDetection.RayHit(transform, (int)player.facingDirection, 5f, HitLayers);
            if (hit != null && hit.tag == "Enemy")
            {
                Debug.Log("Hit: " + hit.gameObject.name);
                hit.gameObject.GetComponent<PlayerStats>().TakeDamage( Random.Range( 1, 5 ) );
            }
            isAttacking = false;
        }
    }

    public void AbilityCast()
    {
        StartCoroutine(DoubleShot(0.2f));
    }
}