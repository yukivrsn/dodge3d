using UnityEngine;

public class Stones : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    
}
