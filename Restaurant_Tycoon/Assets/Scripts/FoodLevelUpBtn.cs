using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class FoodLevelUpBtn : MonoBehaviour
{
    [SerializeField] bool _isBtnDown;

    private async void LevelUp()
    {
        while(_isBtnDown)
        {
            Debug.Log("Level Up");
            await Task.Delay(500);

        }
    }

    public void BtnDown()
    {
        if (!_isBtnDown)
        {
            _isBtnDown = true;
            LevelUp();
        }
        _isBtnDown = true;
    }

    public void BtnUp()
    {
        _isBtnDown = false;
    }

}
