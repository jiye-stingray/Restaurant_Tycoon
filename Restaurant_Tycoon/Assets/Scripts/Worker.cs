using Cysharp.Threading.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


public class Worker : MonoBehaviour
{
    [SerializeField] Image _image;

    public float _requiredTime;

    private async void Start()
    {
        await MakeFood(_requiredTime);
    }

    float timer;
    public async UniTask MakeFood(float requiredTime)
    {
        
        
        _image.gameObject.SetActive(true);

        while(timer < _requiredTime)
        {
            timer += Time.deltaTime;
            _image.fillAmount =  (timer / requiredTime);

            await UniTask.Yield(PlayerLoopTiming.Update);
        }

        await UniTask.Delay(TimeSpan.FromSeconds(0.5f));

        _image.gameObject.SetActive(false);
    }
}
