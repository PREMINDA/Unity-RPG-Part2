using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public new Text name;
    [SerializeField]
    private Text dialog;
    [SerializeField]
    private GameObject diallogbox;
    [SerializeField]
    private GameObject namebox;

    public string[] dialogs;
    private int dnumber = 0;

    public static DialogManager insance;


    void Start()
    {
        insance = this;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setActivate(bool set)
    {
        diallogbox.SetActive(set);
    }
}
