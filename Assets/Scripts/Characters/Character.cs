using UnityEngine;

public class Character : ScriptableObject
{
    public int ID;

    public Texture2D Symbol;

    public string Name;

    public int Level;
    public int MaxLevel;

    public float Health;
    public float MaxHealth;
    public float HealthRegen;
    public float HealthPerLevel;

    public float Armour;

    public float MoveSpeed;
    public float JumpHeight;
    public int MaxJumps;

    public float Damage;
    public float CritChance;
}