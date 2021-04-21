using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogActivatior : MonoBehaviour
{
    private bool _isEnable=false;
    private bool _isEscapeEnable = false;
    [SerializeField]
    public string[] dialogs;
    public static DialogActivatior instance;
    private DialogManager DM;
    private BoxCollider2D box;

  

    void Start()
    {
        instance = this;
        DM = GameObject.Find("Canvas").GetComponent<DialogManager>();
        box = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
   

        if (Input.GetKeyDown(KeyCode.E) && _isEnable== true)
        {
            DM.setActivate(true);

            
            //DialogManager.instance.setActivate(true);
            //DialogManager.instance.SetDialog(dialogs);
            PlayerController.instance.setWalkState(false);
            _isEnable = false;
            _isEscapeEnable = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape) && _isEscapeEnable == true)
        {
            DM.setActivate(false);
            DM.Resetdialog();
            //DialogManager.instance.setActivate(false);
           
            //DialogManager.instance.Resetdialog();
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
            DM.SetDialog(dialogs);


        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            _isEnable = false;
            _isEnable = false;
           
            DialogManager.instance.Resetdialog();
        }
    }

    public void ReReadDialog()
    {
        _isEnable = true;
    }
}
