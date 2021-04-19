using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEnter : MonoBehaviour
{
    public string entrencelocation;
    void Start()
    {
        if(entrencelocation == PlayerController.instance.areaTransetionName)
        {
            PlayerController.instance.transform.position = transform.position;
            StartCoroutine(FadeUi.instance.FadeScreen());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
