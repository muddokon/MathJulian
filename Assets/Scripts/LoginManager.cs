using TMPro;
using UnityEngine;

public class LoginManager : MonoBehaviour
{
    public TMP_Text nameText;
    public string nombreAlternativo = "Jugador";
    
    public void RegisterUser()
    {
        string daName = "";
        PlayerPrefs.DeleteAll();
        daName = nameText.text;
        /*if (daName.Length > 0 && daName.Length < 9)
            daName = nameText.text;
        else if (daName.Length > 9)
            daName = nameText.text.Substring(0,9);
        else
        {
            daName = nombreAlternativo;
        }*/
        PlayerPrefs.SetString("playerName", daName);
    }
}
