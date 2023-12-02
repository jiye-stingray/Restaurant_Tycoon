using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum QuestType
{
    Guest,          // �մ� �߰�
    Clerk,          // ���� �߰�
    Price,          // ���� �߰�
    Time,           // ���۽ð� ���̱�

}

[CreateAssetMenu(fileName = "Quest", menuName = "Data/Quest")]
public class QuestData : ScriptableObject
{
    public string _questName;
    public int _questCostValue;

    public QuestType _questType;
    public int _questApplicationValue;      // ���� �� ���� ��
}
