using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogActivatior : MonoBehaviour
{
    private bool _isEnable=false;
    private bool _isEscapeEnable = false;
    public string[] dialogs;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E) && _isEnable== true)
        {
            DialogManager.insance.setActivate(true);
            DialogManager.insance.SetDialog(dialogs);
            PlayerController.instance.setWalkState(false);
            _isEnable = false;
            _isEscapeEnable = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape) && _isEscapeEnable == true)
        {
            DialogManager.insance.setActivate(false);
           
            DialogManager.insance.Resetdialog();
            PlayerController.instance.setWalkState(true);
            _isEnable = true;
            _isEscapeEnable = false;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            _isEnable = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            _isEnable = false;
            _isEnable = false;
            DialogManager.insance.Resetdialog();
        }
    }

    public void ReReadDialog()
    {
        _isEnable = true;
    }
}
