using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class FoodLevelUpBtn : MonoBehaviour
{
    [SerializeField] bool _isBtnDown;
    [SerializeField] Image _sprite;

    private async void LevelUp()
    {
        while(_isBtnDown)
        {

            _sprite.color = Color.black;
            Debug.Log("Level Up");
            await Task.Delay(200);
            _sprite.color = Color.white;
            await Task.Delay(300);

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
