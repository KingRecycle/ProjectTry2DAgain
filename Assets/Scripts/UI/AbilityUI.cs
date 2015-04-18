using UnityEngine;
using UnityEngine.UI;

public class AbilityUI : MonoBehaviour
{
    public Ability[] Skills;
    public Image[] SkillCooldownGraphic;
    public Text[] SkillCooldownNumber;

    void Start()
    {
    }

    void Update()
    {
        for (int i = 0; i < Skills.Length; i++)
        {
            if (Skills[i].CurrentCooldown > 0)
            {
                float roundedCD = Mathf.Round(Skills[i].CurrentCooldown);

                SkillCooldownGraphic[i].fillAmount = (Skills[i].CurrentCooldown / Skills[i].Cooldown);
                SkillCooldownNumber[i].text = roundedCD.ToString();
            }
            if (Skills[i].CurrentCooldown <= 0)
            {
                SkillCooldownNumber[i].text = "";
                SkillCooldownGraphic[i].fillAmount = 0;
            }
        }
    }
}