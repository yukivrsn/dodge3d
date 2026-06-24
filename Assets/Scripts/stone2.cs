using UnityEngine;

public class stone2 : MonoBehaviour
{

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
