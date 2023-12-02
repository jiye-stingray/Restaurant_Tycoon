using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    [SerializeField] bool _isDontDestroyOnLoad;

    private static T _instance;
    public static T Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<T>() as T;

                if(_instance == null)
                {
                    GameObject go = new GameObject(nameof(T));  
                    _instance = go.AddComponent<T>();
                }
            }
            return _instance;
        }
        
    }


    protected void Awake()
    {

        if(_instance != null)
        {
            Destroy(this);
        }
        else
        {
            _instance = this as T;

            if(_isDontDestroyOnLoad) DontDestroyOnLoad(this);
        }
    }
}
