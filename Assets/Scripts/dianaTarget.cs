using UnityEngine;

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

	public bool correcto;

	public string nivel;
	
	private GameManager _gameManager;
	private UIManager _uiManager;
	private LevelLoader _levelLoader;

	void Start(){
		_gameManager = GameObject.FindWithTag("GameController").GetComponent (typeof(GameManager)) as GameManager;
		_uiManager = GameObject.FindWithTag("GameController").GetComponent (typeof(UIManager)) as UIManager;
		_levelLoader = GameObject.FindWithTag("Loader").GetComponent (typeof(LevelLoader)) as LevelLoader;
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

		if (nivel.Equals("Tabla 1"))
		{
			_levelLoader.ChageScene("Tabla 1");
		}
		else if (nivel.Equals("Tabla 2"))
		{
			_levelLoader.ChageScene("Tabla 2");
		}
		else if (nivel.Equals("Tabla 3"))
		{
			_levelLoader.ChageScene("Tabla 3");
		}
		else if (nivel.Equals("Tabla 4"))
		{
			_levelLoader.ChageScene("Tabla 4");
		}
		else if (nivel.Equals("Tabla 5"))
		{
			_levelLoader.ChageScene("Tabla 5");
		}
		else if (nivel.Equals("Tabla 6"))
		{
			_levelLoader.ChageScene("Tabla 6");
		}
		else if (nivel.Equals("Tabla 7"))
		{
			_levelLoader.ChageScene("Tabla 7");
		}
		else if (nivel.Equals("Tabla 8"))
		{
			_levelLoader.ChageScene("Tabla 8");
		}
		else if (nivel.Equals("Tabla 9"))
		{
			_levelLoader.ChageScene("Tabla 9");
		}
		else if (nivel.Equals("Tabla 10"))
		{
			_levelLoader.ChageScene("Tabla 10");
		}
		else if (correcto)
		{
			_gameManager.SumarScore();
			_uiManager.StartCoroutine(nameof(UIManager.FeedbackBien));
		}
		else if (!correcto)
		{
			_gameManager.RestarScore();
			_uiManager.StartCoroutine(nameof(UIManager.FeedbackMal));
			//mostrar feedback mal
		}
		Destroy (gameObject);
	}
}
