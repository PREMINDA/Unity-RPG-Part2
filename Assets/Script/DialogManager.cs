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

   

    private string[] dialogs;
    private int dnumber = 0;

    public static DialogManager instance;


    void Start()
    {
        instance = this;
       
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && diallogbox.activeInHierarchy)
        {
            dnumber++;
            CheckIfName();

            if (dialogs.Length > dnumber && dialogs[dnumber].StartsWith("n-") == false)
            {
                dialog.text = dialogs[dnumber];
            }
            else
            {
                diallogbox.SetActive(false);
                Resetdialog();
                PlayerController.instance.setWalkState(true);
                DialogActivatior.instance.ReReadDialog();
            }
        }
        
    }

    public void setActivate(bool set)
    {
        diallogbox.SetActive(set);
    }

    public void SetDialog(string[] dilogsArr)
    {
        dialogs = dilogsArr;
        CheckIfName();
        dialog.text = dialogs[dnumber];
    }

    private void CheckIfName()
    {
        if(dialogs.Length>dnumber && dialogs[dnumber].StartsWith("n-"))
        {
            name.text = dialogs[dnumber].Replace("n-","");
            dnumber++;
        }
    }
    public void Resetdialog()
    {
        dnumber = 0;
       
    }
}
