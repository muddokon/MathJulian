using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateResults : MonoBehaviour
{
    public RectTransform titulonombre;

    public RectTransform puntaje;

    public RectTransform boton1, boton2, boton3;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveY(titulonombre, -193, 1f).setDelay(0.5f).setEase(LeanTweenType.easeInBounce);
        LeanTween.scale( puntaje, new Vector2(1,1), 0.7f ).setDelay(1f).setEase(LeanTweenType.easeOutBounce);
        LeanTween.scale( boton1, new Vector2(1,1), 0.7f ).setDelay(4f).setEase(LeanTweenType.easeOutBounce);
        LeanTween.scale( boton2, new Vector2(1,1), 0.7f ).setDelay(5f).setEase(LeanTweenType.easeOutBounce);
        LeanTween.scale( boton3, new Vector2(3.909034f,4.77774f), 0.7f ).setDelay(3f).setEase(LeanTweenType.easeOutBounce);
    }
}
