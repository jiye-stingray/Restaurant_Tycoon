using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;


public class Worker : MonoBehaviour
{
    [SerializeField] Image _image;

    public float _requiredTime;

    private void Start()
    {
        MakeFood(_requiredTime);
    }

    float timer;
    public async UniTask MakeFood(float requiredTime)
    {
        while(timer <= requiredTime)
        {
            
        }
    }
}
