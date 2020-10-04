using UnityEngine;

public class KillZone : MonoBehaviour
{
    [Header("Objeto posicionador de inicio:")]
    [SerializeField] private GameObject resetPosition;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("KillZone"))
        {
            Debug.Log("Kill Zone reached!");
            other.transform.position = resetPosition.transform.position;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
