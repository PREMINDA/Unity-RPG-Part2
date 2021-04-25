using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameManager instance;

    public string[] itemsCollected;
    public int[] numberOfItem;
    public Item[] referenceItem;
    void Start()
    {
        instance = this;        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Item GetIteminfor(string ItemToGrab)
    {
        for(int i = 0; i < referenceItem.Length; i++)
        {
            if(referenceItem[i].itemName == ItemToGrab)
            {
                return referenceItem[i];
            }
        }
        return null;
    }
}
