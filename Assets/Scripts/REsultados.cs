using TMPro;
using UnityEngine;

public class REsultados : MonoBehaviour
{
    public TMP_Text nombre;
    public TMP_Text puntaje;

    // Start is called before the first frame update
    void Start()
    { 
        nombre.text = PlayerPrefs.GetString("playerName");
        //puntaje.text = _gameManager.GetScore().ToString();
        puntaje.text = PlayerPrefs.GetInt("score").ToString();
        Cursor.lockState = CursorLockMode.None;
    }
}
