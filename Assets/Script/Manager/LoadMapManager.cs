using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UniRx;
public class LoadMapManager : MonoBehaviour
{
    private static LoadMapManager instance;
    public static LoadMapManager Instance => instance;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this);
        RxManager.LoadMap.Subscribe(map =>
        {
            LoadMap(map);
        }).AddTo(this);
    }

    private void LoadMap(int map)
    {
        if(map == ConfigData.GetCurrentLevelPlay())
        {
            RxManager.ClickMain.OnNext(delegate{ });
            return;
        }
        SceneManager.LoadScene(map);
    }
}
