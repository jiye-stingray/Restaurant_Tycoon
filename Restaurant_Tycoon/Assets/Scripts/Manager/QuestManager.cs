using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StageQuest
{
    public List<QuestData> _questDataList = new List<QuestData>();
}

public class QuestManager : MonoBehaviour
{
    [SerializeField] List<StageQuest> _stageQuestList = new List<StageQuest>();

    [SerializeField] GameObject _questPanelPrefab;
    [SerializeField] RectTransform _scrollviewContentRectTrans;

    private void Start()
    {
        SetQuestPanel(0);       // 임시 호출
    }

    private void SetQuestPanel(int stage)
    {
        StageQuest stageQuest = _stageQuestList[stage];

        for (int i = 0; i < stageQuest._questDataList.Count; i++)
        {
            QuestPanel questPanel = Instantiate(_questPanelPrefab, transform.position, Quaternion.identity).GetComponent<QuestPanel>();
            questPanel.SetPanel(stageQuest._questDataList[i]);
            questPanel.gameObject.transform.SetParent(_scrollviewContentRectTrans);
        }
    }

    
    

}
