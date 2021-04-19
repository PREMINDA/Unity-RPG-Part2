using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{
    public string areaToLoad;
    public string areaTransetionName;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            FadeUi.instance.FadeScreenBlack();
            StartCoroutine(wait());
            PlayerController.instance.setcanwalk(0f);
            FadeUi.instance.FadeScreenBlack();
        }
    }

    private IEnumerator wait()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(areaToLoad);
        PlayerController.instance.areaTransetionName = areaTransetionName;
        PlayerController.instance.setcanwalk(5f);

    }
}
