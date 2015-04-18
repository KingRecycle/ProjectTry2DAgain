using UnityEngine;

public class GrenadeThrow : Ability
{
    public GameObject Grenade;

    // Use this for initialization
    public void Initialize()
    {
        //Name = "Grenade Toss";
        //Description = "You toss a grenade dealing AoE damage!";
        //Cooldown = 5f;
        //Damage = Random.Range(1, 3);
    }

    public void AbilityCast()
    {
        GameObject nade = (GameObject)Instantiate(Grenade, transform.position, Quaternion.identity);
        nade.GetComponent<Rigidbody2D>().AddForce(new Vector2(2f * (int)player.facingDirection, 4f), ForceMode2D.Impulse);
    }
}