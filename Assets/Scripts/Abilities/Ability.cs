using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class Ability : MonoBehaviour
{
    public string Key = "";

    public string Name;
    public string Description;

    public float Cooldown;
    public float CurrentCooldown;
    public bool isOnCooldown = false;

    public float Damage;

    public LayerMask HitLayers;

    public AbilityType[] abilityTypes;

    public enum AbilityType {
        Attack,
        Heal,
        Buff,
        Debuff,
        Special
    }

    [HideInInspector]
    public Player player;

    public UnityEvent OnInitialize;
    public UnityEvent OnCast;
    public UnityEvent OnCastFailed;
    public UnityEvent OnCooldownStart;
    public UnityEvent OnCooldownFinish;

    void Awake()
    {
        player = gameObject.transform.root.GetComponent<Player>();
    }

    void Start() {
        Init();
        OnInitialize.Invoke();
    }

    public virtual void Init() {

    }

    public void Cast()
    {
        if (CurrentCooldown == 0) //On Successful cast invoke events and setup cooldown timer.
        {
            OnCast.Invoke();
            isOnCooldown = true;
            CurrentCooldown = Cooldown;
            OnCooldownStart.Invoke();
            Debug.Log("Cast called!");
        }
        else //On unsucessfull cast invoke cast failed event -- TODO: Do checks to see if ability is available (stuns, locked, etc)
        {
            OnCastFailed.Invoke();
            Debug.Log("Cast failed!");
        }
    }

    public void CooldownTick() //Call this in update for controlling cooldown time.
    {
        if (isOnCooldown && CurrentCooldown > 0)
        {
            CurrentCooldown -= Time.deltaTime;
        }
        if (isOnCooldown && CurrentCooldown < 0)
        {
            OnCooldownFinish.Invoke();
            isOnCooldown = false;
            CurrentCooldown = 0;
            Debug.Log("Cooldown finished!");
        }
    }

    void Update()
    {
        CooldownTick();

        if (Input.GetButton(Key) && !isOnCooldown)
        {
            Cast();
        }
    }
}