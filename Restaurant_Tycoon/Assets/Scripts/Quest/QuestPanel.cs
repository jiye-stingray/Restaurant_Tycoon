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
        _buyBtnText.text = GoldManager.TOStringMoney(_questData._questCostValue);       // 나중에 방치형 금액 표시 로직으로 수정 필요  

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
    /// 구매 버튼 클릭
    /// </summary>
    public void BuyBtnClick()
    {
        if (_questData == null) return;

        // 금액 조건 추가

        QuestDel?.Invoke();

    }

    private void GuestQuest(int value)
    {
        Debug.Log(value);       // Temp
    }

}
