/*

Este Script ha sido elaborado o modificado por Academia Applícate.

Autor(es): Sebastián Gómez Rosas
https://github.com/muddokon

Licencia Mozilla MPL v2
https://www.mozilla.org/en-US/MPL/2.0/

Este software se ha producido para ser utilizado
en proyectos de estudiantes de Academia Applícate.

Se prohibe su reproducción total o parcial sin el cumplimiento de los términos de licencia.
Copyright - Applícate Academia de Artes Digitales.

*/

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class GunFire : MonoBehaviour {

	[Header("Cantidad de daño por disparo")]
	public float damage = 10f;

	[Header("Rango del disparo:")]
	public float range = 100f;

	[Header("La cámara:")]
	public Camera FPSCamera;

	[Header("El efecto de disparo:")]
	public ParticleSystem shootEffect;

	[Header("El efecto de impacto:")]
	public GameObject hitEffect;

	[Header("Fuerza de impacto:")]
	public float fuerza = 50.0f;

	[Header("Sonido de disparo:")]
	public AudioClip sonido;

	private AudioSource parlante;
	private GameManager _gameMananger;
	private LevelLoader _levelLoader;
	private int targetAmount;

	void Start(){
		targetAmount = 20;
		parlante = GetComponent<AudioSource> ();
		_gameMananger = GameObject.FindWithTag("GameController").GetComponent (typeof(GameManager)) as GameManager;
		_levelLoader = GameObject.FindWithTag("Loader").GetComponent (typeof(LevelLoader)) as LevelLoader;
	}

	void Update () {
		
		if (Input.GetButtonDown("Fire1"))
		{
			GunShoot();
		}

		if (!SceneManager.GetActiveScene().name.Equals("4-Login"))
		{
			/* DESDE AQUI RESTAR TIEMPO */
			_gameMananger.tiempo -= Time.deltaTime;

			/* DESDE AQUI PERDER */ /* DESDE AQUI PERDER */
			if (_gameMananger.getTiempo() <= 0)
			{
				_gameMananger.setGanar(false);
				_levelLoader.ChageScene("Resultados");
			}
			/* HASTA AQUI PERDER */

			/* HASTA AQUI RESTAR TIEMPO */
		}
	}

	void GunShoot(){
		StartCoroutine (playMuzleEffect ());
		parlante.clip = sonido;
		parlante.Play ();
		RaycastHit hit;
		if (Physics.Raycast (FPSCamera.transform.position, FPSCamera.transform.forward, out hit)) {
			Debug.Log ("Le diste a " + hit.transform.name);
			dianaTarget target = hit.transform.GetComponent<dianaTarget> ();
			if (target != null)
			{
				if (target.correcto)
					targetAmount--;
				if (targetAmount < 1)
				{
					_gameMananger.setGanar(false);
					_levelLoader.ChageScene("Resultados");
				}
				Debug.Log("Daño realizado!");
				target.takeDamage (damage);
			}
			GameObject obj = Instantiate (hitEffect, hit.point, Quaternion.LookRotation (hit.normal));
			Destroy(obj, 0.5f);
		}
	}

	IEnumerator playMuzleEffect(){
		shootEffect.Play ();
		yield return new WaitForSeconds (0.1f);
		shootEffect.Stop ();
	}
}
