using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonSelectLevel : MonoBehaviour
{
    private int mapSelect;
    private Button buttonSelectlevel;
    [SerializeField]private Image mapOpen;
    [SerializeField] private Image mapLock;
    [SerializeField] private Image mapHighest;
    [SerializeField] private TextMeshProUGUI textLevel;
    private void Awake()
    {
        buttonSelectlevel = transform.GetComponent<Button>();
    }


    void Start()
    {
        buttonSelectlevel.onClick.AddListener(OnClickMap);
    }

    public void SetUpButton(int map)
    {
        mapSelect = map;
        textLevel.text = map.ToString();
        int mapCurrent = ConfigData.GetCurrentLevelPlay();
        if (map == mapCurrent)
        {
            mapHighest.enabled = true;
            mapHighest.GetComponent<Image>().raycastTarget = false;
        }
        else if(map < mapCurrent)
        {
            mapOpen.enabled = true;


        }
        else if(map > mapCurrent)
        {
            mapLock.enabled = true;
            mapLock.GetComponent<Image>().raycastTarget = false;
        }
    }
    private void OnClickMap()
    {
        RxManager.LoadMap.OnNext(mapSelect);
    }


}
