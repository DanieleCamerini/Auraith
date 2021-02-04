using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Fade : MonoBehaviour
{

    public float fadeTime = 1f;


    public SpriteRenderer fadePanel;
    public UnityEvent OnFadeComplete;


    private Color opaque = Color.black;
    private Color transparent = new Color(0, 0, 0, 0);


    public void StartFade()
    {

        if (fadeTime > 0f)
        {
            StartCoroutine(FadeCoroutine());

        }
        else
        {
            OnFadeComplete.Invoke();
        }

    }


    private IEnumerator FadeCoroutine()
    {
        fadePanel.gameObject.SetActive(true);

        float myCounter = 0f;

        while (myCounter < fadeTime)
        {
            fadePanel.color = Color.Lerp(transparent, opaque, myCounter / fadeTime);

            myCounter = Time.deltaTime;

            yield return null;

        }
        fadePanel.color = opaque;

        OnFadeComplete.Invoke();


        myCounter = 0f;

        while (myCounter < fadeTime)
        {
            fadePanel.color = Color.Lerp(opaque, transparent, myCounter / fadeTime);

            myCounter = Time.deltaTime;

            yield return null;

        }
        fadePanel.gameObject.SetActive(false);

    }
}