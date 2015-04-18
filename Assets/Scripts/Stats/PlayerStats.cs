using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {

    public float health = 100;
    public float maxHealth = 100;
    public float healthRegen = 0.2f;

    public float armour = 2;

    public float damage = 2;
    public float critChance = 0.05f;
    public float critMultiplier = 1.25f;

    public float moveSpeed = 6;
    public float jumpHeight = 4;

    //----Health Methods
    public void TakeDamage( float amount ) {
        health = Mathf.Clamp( health - amount, 0, maxHealth );
    }

    public void GiveHealth( float amount ) {
        health = Mathf.Clamp( health + amount, 0, maxHealth );
    }

    public void IncreaseHealthRegen( float amount ) {
        healthRegen += amount;
    }

    public void DecreaseHealthRegen( float amount ) {
        healthRegen -= amount;
    }

    //----Armour Methods
    public void IncreaseArmour( float amount ) {
        armour += amount;
    }

    public void DecreaseArmour( float amount ) {
        armour -= amount;
    }

    //----Damage & Crit Methods
    public void IncreaseDamage( float amount ) {
        damage += amount;
    }

    public void DecreaseDamage( float amount ) {
        damage -= amount;
    }

    public void IncreaseCritChance( float amount ) {
        critChance += amount;
    }

    public void DecreaseCritChance( float amount ) {
        critChance -= amount;
    }
}
