

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField]
    private string _charName;
  
    public int PlayLevel = 1;
    
    public int CurrentExp = 0;
    public int NextLevelExp = 100;

    
    private int _maxHealth = 100;
    public int CurrentHP;

    private int _maxMagicPoint = 50;
    public int CurrentMP;

    [SerializeField]
    private int _strength = 15;
    [SerializeField]
    private int _defence = 12;

    public int WpPower;
    public int ArPower;

    public string EquipWp;
    public string EquipAr;

    [SerializeField]
    private Sprite CharImage;

    void Start()
    {
        CurrentHP = 100;
        CurrentMP = 50;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            CurrentExp += 10;
            LevelUp();
        }

    }



    public void LevelUp()
    {
        if (CurrentExp >= NextLevelExp)
        {
            
            PlayLevel++;
            CurrentExp = 0;
            NextLevelExp = NextLevelExp + 20;
            _maxHealth += 2;
            ArWpPowerup();
            Debug.Log(PlayLevel);


        }
    }

    public void ArWpPowerup()
    {
        if (PlayLevel % 2 == 0)
        {
            _strength += 5;
        }
        else
        {
            _defence += 5;
        }
    }

   

}