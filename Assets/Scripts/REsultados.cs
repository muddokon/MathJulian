using TMPro;
using UnityEngine;

public class REsultados : MonoBehaviour
{
    public TMP_Text nombre;
    public TMP_Text puntaje;

    private GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameObject.FindWithTag("GameController").GetComponent (typeof(GameManager)) as GameManager;
        nombre.text = PlayerPrefs.GetString("playerName");
        //puntaje.text = _gameManager.GetScore().ToString();
        puntaje.text = PlayerPrefs.GetInt("score").ToString();
    }
}
