using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum QuestType
{
    Guest,          // 손님 추가
    Clerk,          // 점원 추가
    Price,          // 가격 추가
    Time,           // 제작시간 줄이기

}

[CreateAssetMenu(fileName = "Quest", menuName = "Data/Quest")]
public class QuestData : ScriptableObject
{
    public string _questName;
    public int _questCostValue;

    public QuestType _questType;
    public int _questApplicationValue;      // 적용 후 변경 값
}
