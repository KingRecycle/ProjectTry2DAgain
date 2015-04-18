using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    /*public GameObject floatingText;

    public Character characterData;

    public Inventory inventory;

    int level, maxLevel, maxJumps;
    float health, maxHealth, healthRegen, healthPerLevel;
    float damage, critChance;
    float armour, moveSpeed;

    //[Flat bonuses added together] * [1 + Increased bonuses added together - Reduced Percentages added together] * more bonuses - less bonuses
    List<StatModifier> StatModifiers;

    StatModifier FlatTest;
    StatModifier IncreaseTest;
    StatModifier ReduceTest;
    StatModifier MoreTest;
    StatModifier LessTest;

    public float DebugHealth;
    public float DebugArmour;

    void Start()
    {
        level = characterData.Level;
        maxLevel = characterData.MaxLevel;

        health = characterData.Health;
        maxHealth = characterData.MaxHealth;
        healthRegen = characterData.HealthRegen;
        healthPerLevel = characterData.HealthPerLevel;

        armour = characterData.Armour;

        moveSpeed = characterData.MoveSpeed;
        maxJumps = characterData.MaxJumps;

        critChance = characterData.CritChance;

        inventory = transform.GetComponent<Inventory>();
    }

    void Update()
    {
        DebugHealth = maxHealth;
        DebugArmour = armour;
    }

    public void AddModifier(StatModifier mod)
    {
        StatModifiers.Add(mod);
    }

    public void RemoveModifier(string id)
    {
        foreach (StatModifier modifier in StatModifiers)
        {
            if (modifier.ID == id)
            {
                StatModifiers.Remove(modifier);
            }
        }
    }

    void RefreshStats()
    {
        for (int i = 0; i < inventory.Equiped.Count; i++)
        {
            for (int k = 0; k < StatModifiers.Count; k++)
            {
            }
        }
    }

    //BASE * [Flat bonuses added together] * [1 + Increased bonuses added together - Reduced Percentages added together] * more bonuses - less bonuses
    void CalculateStat(StatType stat, float baseStat, List<StatModifier> modifiers)
    {
        float flats = 0;
        float increased = 0;
        float reduced = 0;
        float more = 0;
        float less = 0;

        switch (stat)
        {
            case StatType.MaxHealth:
                for (int i = 0; i < StatModifiers.Count; i++)
                {
                    if (StatModifiers[i].ModType == ModifierType.Flat)
                    {
                        flats += StatModifiers[i].Amount;
                    }
                    if (StatModifiers[i].ModType == ModifierType.Increased)
                    {
                        increased += StatModifiers[i].Amount;
                    }
                    if (StatModifiers[i].ModType == ModifierType.Reduced)
                    {
                        reduced += StatModifiers[i].Amount;
                    }
                    if (StatModifiers[i].ModType == ModifierType.More)
                    {
                        more += StatModifiers[i].Amount;
                    }
                    if (StatModifiers[i].ModType == ModifierType.Less)
                    {
                        less += StatModifiers[i].Amount;
                    }
                }

                maxHealth = characterData.MaxHealth + flats * (1 + increased / 100 - reduced / 100) * (1 + more / 100 - less / 100); //Math that shit up
                break;

            case StatType.HealthRegen:
                break;

            case StatType.Armour:
                break;

            case StatType.Damage:
                break;

            case StatType.CritChance:
                break;

            case StatType.MoveSpeed:
                break;

            case StatType.MaxJumps:
                break;

            default:
                break;
        }
    }

    #region Health and Armour Functions

    public void TakeDamage(float amount)
    {
        if (health > 0)
        {
            health = health - amount;
            GameObject textClone = (GameObject)GameObject.Instantiate(floatingText, transform.position, Quaternion.identity);
            Debug.Log(textClone.gameObject.name);
            textClone.GetComponentInChildren<FloatingText>().SetText(amount.ToString());
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

    public void TakeArmour(float amount)
    {
        armour = armour - amount;
    }

    public void GiveArmour(float amount)
    {
        armour = armour + amount;
    }

    #endregion Health and Armour Functions
    */
}