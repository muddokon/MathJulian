using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latir : MonoBehaviour {

	[Header("Frecuencia:")]
	public float rate;

	[Header("Escala intermedia:")]
	public float midScale;

	[Header("Desviación:")]
	public float ratio;

	public RectTransform thisTransform;

	void Start(){
		if(thisTransform==null){
			thisTransform=GetComponent(typeof(RectTransform)) as RectTransform;
		}
	}

	private Vector3 scale;

	void Update ()
	{
		float scaleComponent = midScale * Mathf.Pow(ratio, Mathf.Sin(Time.time * rate));
		for (int i = 0; i < 3; i++) {
			scale = scaleComponent*Vector3.one;
			thisTransform.localScale = scale;
		}
	}
}
