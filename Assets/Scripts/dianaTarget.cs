﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*

Este Script ha sido elaborado o modificado por Academia Applícate.

Licencia Mozilla MPL v2
https://www.apache.org/licenses/LICENSE-2.0

Se prohibe su reproducción total o parcial sin el cumplimiento de los términos de licencia.
Copyright 2017 - Applícate Academia de Artes Digitales.

*/

public class dianaTarget : MonoBehaviour {

	[Header("La energía de este target:")]
	public float health = 50f;

	[Header("La explosión cuando se destruye:")]
	public GameObject explosion;

	private GameManager _gameManager;

	void Start(){
		_gameManager = GameObject.FindWithTag("GameController").GetComponent (typeof(GameManager)) as GameManager;
	}

	public void takeDamage(float _amount){
		health -= _amount;

		if (health <= 0) {
			Score ();
		}
	}

	void Score(){
		GameObject obj = Instantiate (explosion, transform.position, transform.rotation);
		Destroy(obj, 2f);

		/*AQUI PONEMOS LA FUNCIÓN DE PUNTO*/
	
		restarPunto ();


		/*HASTA AQUÍ*/

		Destroy (gameObject);
	}

	/* AQUI RESTAMOS UN PUNTO CON UNA FUNCIÓN*/

	private void restarPunto(){
		_gameManager.restarTarget ();
        
/* DESDE AQUI GANAR */

		if (_gameManager.getTargets () < 1) {
			_gameManager.setGanar (true);
			SceneManager.LoadScene ("final");
		}

		/* HASTA AQUI GANAR */
	}


	/*HASTA AQUÍ*/
}