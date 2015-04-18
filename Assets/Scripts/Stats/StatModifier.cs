public enum StatType
{
    MaxHealth,
    HealthRegen,
    Armour,
    Damage,
    CritChance,
    MoveSpeed,
    MaxJumps
}

public enum ModifierType
{
    Flat,
    Increased,
    Reduced,
    More,
    Less
}

/*
public class StatModifiers : MonoBehaviour
{
    [SerializeField]
    public List<StatModifier> modifiers = new List<StatModifier>();

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}*/

[System.Serializable]
public class StatModifier
{
    public string ID;
    public StatType AffectedStat; //Stat that is affected
    public float Amount; //How much it is affected
    public float Duration; //How long it is affected
    public ModifierType ModType; //How the stat should be calculated

    public StatModifier(string id, StatType affectedStat, float amount, float duration, ModifierType modType)
    {
        ID = id;
        AffectedStat = affectedStat;
        Amount = amount;
        Duration = duration;
        ModType = modType;
    }
}