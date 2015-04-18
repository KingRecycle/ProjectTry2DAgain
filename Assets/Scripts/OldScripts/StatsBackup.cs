using UnityEngine;

public class StatsBackup : MonoBehaviour
{
    int level;
    int maxLevel;

    float health;
    float maxHealth;
    float healthRegen;
    float healthPerLevel;

    float armour;

    float moveSpeed;
    float jumpHeight;
    int maxJumps;

    float critChance;

    public int Level { get { return level; } set { level = value; } }

    public int MaxLevel { get { return maxLevel; } set { maxLevel = value; } }

    public float Health { get { return health; } set { health = value; } }

    public float MaxHealth { get { return maxHealth; } set { maxHealth = value; } }

    public float HealthRegen { get { return healthRegen; } set { healthRegen = value; } }

    public float HealthPerLevel { get { return healthPerLevel; } set { healthPerLevel = value; } }

    public float Armour { get { return armour; } set { armour = value; } }

    public float MoveSpeed { get { return moveSpeed; } set { moveSpeed = value; } }

    public float JumpHeight { get { return jumpHeight; } set { jumpHeight = value; } }

    public int MaxJumps { get { return maxJumps; } set { maxJumps = value; } }

    public float CritChance { get { return critChance; } set { critChance = value; } }

    public StatsBackup()
    {
        level = 0;
        maxLevel = 100;
        health = 100;
        maxHealth = 100;
        healthRegen = 0.10f;
        healthPerLevel = 15;
        armour = 0;
        moveSpeed = 5;
        jumpHeight = 5;
        maxJumps = 1;
        critChance = 0.1f;
    }

    public StatsBackup(int lvl, int maxLvl, float hp, float maxHP, float hpRegen, float hpPerLvl, float armor, float moveSpd, float jumpHgt, int maxJmps, float crit)
    {
        level = lvl;
        maxLevel = maxLvl;
        health = hp;
        maxHealth = maxHP;
        healthRegen = hpRegen;
        healthPerLevel = hpPerLvl;
        armour = armor;
        moveSpeed = moveSpd;
        jumpHeight = jumpHgt;
        maxJumps = maxJmps;
        critChance = crit;
    }

    public void TakeDamage(float amount)
    {
        if (health > 0)
        {
            health = health - amount;
        }
    }

    public void GiveHealth(float amount)
    {
        if (health < maxHealth)
        {
            health = health + amount;
        }
    }

    void RegenTick()
    {
        if (health > 0 && health < maxHealth)
        {
            health = health + healthRegen;
        }
    }
}