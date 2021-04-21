using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeUi : MonoBehaviour
{
    public Image img;

    public bool shouldBlack;
    public bool ShouldFade;

    private float fadespeed = 1f;

    public static FadeUi instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
        instance = this;
        img.color = new Color(img.color.r, img.color.g, img.color.b, 0f);
        DontDestroyOnLoad(gameObject);
        

    }

    
    void Update()
    {

        if (shouldBlack == true)
        {
            img.color = new Color(img.color.r, img.color.g, img.color.b, Mathf.MoveTowards(img.color.a, 1f, fadespeed * Time.deltaTime));
            if (img.color.a == 1f)
            {
                shouldBlack = false;
            }
        }
        if (ShouldFade)
        {

            img.color = new Color(img.color.r, img.color.g, img.color.b, Mathf.MoveTowards(img.color.a, 0, fadespeed * Time.deltaTime));
            if(img.color.a == 0)
            {
                ShouldFade = false;
            }
        }

    }

    public IEnumerator FadeScreen()
    {
        img.color = new Color(img.color.r, img.color.g, img.color.b, 1f);
        yield return new WaitForSeconds(0.5f);

        ShouldFade = true;
    }

    public void FadeScreenBlack()
    {
        shouldBlack = true;
    }
}
