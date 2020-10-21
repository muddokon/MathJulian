using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("El texto para nombre:")]
    public TMP_Text textoNombre;

    [Header("El texto para tiempo:")]
    public TMP_Text textoTiempo;

    [Header("El texto para feedback Bien:")]
    public TMP_Text textoBien;

    [Header("El texto para feedback Bien:")]
    public TMP_Text textoMal;

    private GameManager _gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameObject.FindWithTag("GameController").GetComponent (typeof(GameManager)) as GameManager;
        textoNombre.text = PlayerPrefs.GetString("playerName");
    }

    // Update is called once per frame
    void Update()
    {
        if(_gameManager.getTiempo() >= 0.0f)
            textoTiempo.text = _gameManager.getTiempo ().ToString("F1");
    }
}
