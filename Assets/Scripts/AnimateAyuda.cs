using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateAyuda : MonoBehaviour
{
    public GameObject go1, go2, go3, go4;
    public AudioClip ac1, ac2, ac3, ac4;
    public RectTransform target;
    private AudioSource _audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        StartCoroutine(PlayAudio());
        LeanTween.moveX(go1, target.GetComponent<RectTransform>().position.x, 1.5f).setDelay(1f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveX(go1, -2065, 1.5f).setDelay(5f).setEase(LeanTweenType.easeInCubic);
        LeanTween.moveX(go2, target.GetComponent<RectTransform>().position.x, 1.5f).setDelay(7f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveX(go2, -2065, 1.5f).setDelay(12f).setEase(LeanTweenType.easeInExpo);
        LeanTween.moveX(go3, target.GetComponent<RectTransform>().position.x, 1.5f).setDelay(14f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveX(go3, -2065, 1.5f).setDelay(21f).setEase(LeanTweenType.easeInExpo);
        LeanTween.moveX(go4, target.GetComponent<RectTransform>().position.x, 1.5f).setDelay(23f).setEase(LeanTweenType.easeOutElastic);
    }

    private IEnumerator PlayAudio()
    {
        yield return new WaitForSeconds(1f);
        _audioSource.clip = ac1;
        _audioSource.Play();
        yield return new WaitForSeconds(6f);
        _audioSource.clip = ac2;
        _audioSource.Play();
        yield return new WaitForSeconds(8f);
        _audioSource.clip = ac3;
        _audioSource.Play();
        yield return new WaitForSeconds(8f);
        _audioSource.clip = ac4;
        _audioSource.Play();
    }
}
