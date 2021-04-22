using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject gameMenu;

    private PlayerStatus playerStatus;

    public Text hpText, mpText, levelText, expText;

    public Slider expSlider;

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
                gameMenu.SetActive(false);
                PlayerController.instance.setcanwalk(5f);
                PlayerController.instance.setWalkState(true);
            }
            else
            {
                gameMenu.SetActive(true);
                PlayerController.instance.setcanwalk(0f);
                PlayerController.instance.setWalkState(false);
                
            }
        }
        
    }
}
