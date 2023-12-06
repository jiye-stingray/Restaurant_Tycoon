using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class FoodLevelUpBtn : MonoBehaviour
{
    private bool _isBtnDown;
    [SerializeField] public Image _sprite;

    [SerializeField] private GameObject _particle;

    private async void LevelUp()
    {
        while(_isBtnDown)
        {

            _sprite.color = Color.black;
            Debug.Log("Level Up");
            CreateParticle();
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

    private void CreateParticle()
    {
        ParticleSystem p = Instantiate(_particle, transform.position, Quaternion.identity).GetComponent<ParticleSystem>();
        p.Play();

        Destroy(p.gameObject, p.duration);
    }
}
