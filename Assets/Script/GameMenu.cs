using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject gameMenu;

    [SerializeField]
    private GameObject[] gameWindows;

    private PlayerStatus playerStatus;

    public Text hpText, mpText, levelText, expText;

    public Slider expSlider;

    public Text Status_Hp, Status_Mp, Status_WeponPow, Status_ArmorPow;
    public string Status_WeponEquiped, Status_ArmorEqiped;


 

    void Start()
    {
        playerStatus = GameObject.Find("Player").GetComponent<PlayerStatus>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (gameMenu.activeInHierarchy)
            {
                //gameMenu.SetActive(false);
                closeMenu();
                PlayerController.instance.setcanwalk(5f);
                PlayerController.instance.setWalkState(true);
            }
            else
            {
                gameMenu.SetActive(true);
                updateUIStatus();
                PlayerController.instance.setcanwalk(0f);
                PlayerController.instance.setWalkState(false);
                
            }
        }
        
    }
    public void updateUIStatus()
    {
        hpText.text = "HP : " + playerStatus.CurrentHP;
        mpText.text = "MP : " + playerStatus.CurrentMP;
        levelText.text = "Level : " + playerStatus.PlayLevel;
        expText.text = playerStatus.CurrentExp+"/"+playerStatus.NextLevelExp;
        expSlider.maxValue = playerStatus.NextLevelExp;
        expSlider.value = playerStatus.CurrentExp;
    }
    public void toggleView(int val)
    {
        for(int i = 0;i<gameWindows.Length; i++)
        {
            if(val == i)
            {
                gameWindows[i].SetActive(!gameWindows[i].activeInHierarchy);
            }
            else
            {
                gameWindows[i].SetActive(false);
            }
        }

    }
    public void closeMenu()
    {
        for(int i = 0; i < gameWindows.Length; i++)
        {
            gameWindows[i].SetActive(false);
        }
        gameMenu.SetActive(false);
    }
    public void playerStatusUpdate()
    {
        Status_Hp.text = "HP : " + playerStatus.CurrentHP;
        Status_Mp.text = "MP : " + playerStatus.CurrentMP;
        
       

    }
}
