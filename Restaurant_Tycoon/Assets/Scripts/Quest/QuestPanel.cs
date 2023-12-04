using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestPanel : MonoBehaviour
{
    public TMP_Text _conditionText;
    public TMP_Text _buyBtnText;

    private QuestData _questData;

    delegate void Quest();
    Quest QuestDel;

    public void SetPanel(QuestData questData)
    {
        _questData = questData;

        _conditionText.text = _questData._questName;
        _buyBtnText.text = GoldManager.TOStringMoney(_questData._questCostValue);       // ���߿� ��ġ�� �ݾ� ǥ�� �������� ���� �ʿ�  

        QuestDel = null;

        switch (_questData._questType)
        {
            case QuestType.Guest:
                QuestDel += () => GuestQuest(_questData._questApplicationValue);
                break;
            case QuestType.Clerk:
                break;
            case QuestType.Price:
                break;
            case QuestType.Time:
                break;
            default:
                break;
        }

        QuestDel += () => Destroy(gameObject);
    }

    /// <summary>
    /// ���� ��ư Ŭ��
    /// </summary>
    public void BuyBtnClick()
    {
        if (_questData == null) return;

        // �ݾ� ���� �߰�

        QuestDel?.Invoke();

    }

    private void GuestQuest(int value)
    {
        Debug.Log(value);       // Temp
    }

}
