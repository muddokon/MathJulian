using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static bool created = false;
    private int targets;
    private bool ganar;
    private string nombre;

    [Header("El tiempo para jugar:")]
    public float tiempo;

    private float tiempoBackup;

    void Awake ()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            tiempoBackup = tiempo;
            created = true;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void resetTiempo(){
        tiempo = tiempoBackup;
    }

    public void restarTarget(){
        targets--;
    }

    public int getTargets(){
        return targets;
    }

    public void setTargets(int _targets){
        targets = _targets;
    }

    public void setGanar(bool _ganar){
        ganar = _ganar;
    }

    public bool getGanar(){
        return ganar;
    }

    public void setNombre(string _nombre){
        nombre = _nombre;
    }

    public string getNombre(){
        return nombre;
    }

    public float getTiempo(){
        return tiempo;
    }

    public void setTiempo(float _tiempo){
        tiempo = _tiempo;
    }
}
