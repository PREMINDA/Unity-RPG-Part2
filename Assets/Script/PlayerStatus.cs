

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField]
    private string _charName;
    [SerializeField]
    private int _playLevel = 1;
    [SerializeField]
    private int _currentExp = 0;
    private int _nextLevelExp = 100;

    
    private int _maxHealth = 100;
    public int CurrentHP;

    private int _maxMagicPoint = 50;
    public int _currentHP;

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

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            _currentExp += 10;
            LevelUp();
        }

    }



    public void LevelUp()
    {
        if (_currentExp >= _nextLevelExp)
        {
            
            _playLevel++;
            _nextLevelExp = _currentExp + 50;
            _maxHealth += 2;
            ArWpPowerup();
            Debug.Log(_playLevel);


        }
    }

    public void ArWpPowerup()
    {
        if (_playLevel % 2 == 0)
        {
            _strength += 5;
        }
        else
        {
            _defence += 5;
        }
    }

    public int getHealt()
    {
        return 0;
    }
    public int getExp()
    {
        return _currentExp;
    }
    public int 

}