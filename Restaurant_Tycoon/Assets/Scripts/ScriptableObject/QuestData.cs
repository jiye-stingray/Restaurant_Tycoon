using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Quest", menuName = "Data/Quest")]
public class QuestData : ScriptableObject
{
    public string _questName;
    public int _questValue;
}
