using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestPanel : MonoBehaviour
{
    public TMP_Text _conditionText;
    public TMP_Text _buyBtnText;

    [HideInInspector] public QuestData _questData;

    public void SetPanel(QuestData _questData)
    {
        _conditionText.text = _questData._questName;
        _buyBtnText.text = _questData._questValue.ToString();       // ���߿� ��ġ�� �ݾ� ǥ�� �������� ���� �ʿ�  
    }
    
}
