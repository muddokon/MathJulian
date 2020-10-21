using TMPro;
using UnityEngine;

public class LoginManager : MonoBehaviour
{
    public TMP_Text nameText;

    public void RegisterUser()
    {
        PlayerPrefs.DeleteAll();
        var daName = nameText.text.Length > 0 ? nameText.text : "Jugador";
        PlayerPrefs.SetString("playerName", daName);
    }
}
