using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.02f; // Field, not Var
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        transform.Translate(0, 0, speed);
    }
}
