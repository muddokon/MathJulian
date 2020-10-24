using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [Header("El texto para nombre:")]
    public TMP_Text textoNombre;

    [Header("El texto para tiempo:")]
    public TMP_Text textoTiempo;

    [Header("El texto para feedback Bien:")]
    public GameObject textoBien;

    [Header("El texto para feedback Mal:")]
    public GameObject textoMal;

    private GameManager _gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        _gameManager = GameObject.FindWithTag("GameController").GetComponent (typeof(GameManager)) as GameManager;
    }

    // Update is called once per frame
    void Update()
    {
        if (!SceneManager.GetActiveScene().name.Equals("4-Login"))
        {
            textoNombre.text = PlayerPrefs.GetString("playerName");
            if (_gameManager.getTiempo() >= 0.0f)
                textoTiempo.text = _gameManager.getTiempo().ToString("F1");
        }
    }
    
    public IEnumerator FeedbackBien()
    {
        textoBien.SetActive(true);
        yield return new WaitForSeconds(1f);
        textoBien.SetActive(false);
    }
    
    public IEnumerator FeedbackMal()
    {
        textoMal.SetActive(true);
        yield return new WaitForSeconds(1f);
        textoMal.SetActive(false);
    }
}
