using System.Collections.Generic;
using UnityEngine;

public class AbilityManager : MonoBehaviour
{
    //Manages the character's abilities into a single script.

    public int AbilityAmount = 0;

    public List<Ability> Abilities = new List<Ability>(4);
}