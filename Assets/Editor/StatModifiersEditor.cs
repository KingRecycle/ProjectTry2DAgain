using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Item))]
[Serializable]
public class StatModifiersEditor : Editor
{
    //StatModifiers stats;
    Item item;

    List<StatModifier> mods;

    SerializedProperty id;
    SerializedProperty affected;
    SerializedProperty amount;
    SerializedProperty duration;
    SerializedProperty modType;

    void OnEnable()
    {
        //stats = (StatModifiers)target;

        item = (Item)target;
    }

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        openSettingBox("Stat Modifiers");
        item.modifiers = drawStatModifierList(item.modifiers);
        //drawSelfOverTime();
        closeSettingBox();

        if (GUI.changed)
        {
            EditorUtility.SetDirty(item);
        }
    }

    List<StatModifier> drawStatModifierList(List<StatModifier> statMods)
    {
        if (statMods != null)
        {
            for (int i = 0; i < statMods.Count; i++)
            {
                EditorGUILayout.LabelField(new GUIContent("#" + (i + 1) + " ID=" + statMods[i].ID), EditorStyles.boldLabel);

                statMods[i].ID = EditorGUILayout.TextField(new GUIContent("ID:"), statMods[i].ID);
                statMods[i].AffectedStat = (StatType)EditorGUILayout.EnumPopup(new GUIContent("Stat:"), statMods[i].AffectedStat);
                statMods[i].Amount = EditorGUILayout.Slider(new GUIContent("Amount:"), statMods[i].Amount, -300, 300);
                statMods[i].Duration = EditorGUILayout.Slider(new GUIContent("Duration:"), statMods[i].Duration, 0, 120);
                statMods[i].ModType = (ModifierType)EditorGUILayout.EnumPopup(new GUIContent("Mod Type:"), statMods[i].ModType);
            }
        }
        EditorGUILayout.BeginHorizontal();
        if ((GUILayout.Button("-", EditorStyles.miniButton, GUILayout.Width(30))) && statMods.Count > 0)
        {
            statMods.RemoveAt(statMods.Count - 1);
            statMods.Capacity = statMods.Capacity - 1;
        }
        if (GUILayout.Button("+", EditorStyles.miniButton, GUILayout.Width(30)))
        {
            statMods.Capacity = statMods.Capacity + 1;
            statMods.Add(new StatModifier("NEW", StatType.Armour, 0f, 0f, ModifierType.Flat));
        }
        EditorGUILayout.EndHorizontal();

        return statMods;
    }

    void openSettingBox(string name = "")
    {
        if (name != "")
            EditorGUILayout.LabelField(new GUIContent(name), EditorStyles.boldLabel);
        //EditorGUI.indentLevel++;
        EditorGUILayout.BeginVertical("Box");
        GUILayout.Space(5);
    }

    void closeSettingBox()
    {
        //EditorGUI.indentLevel--;
        GUILayout.Space(5);
        EditorGUILayout.EndVertical();
    }
}