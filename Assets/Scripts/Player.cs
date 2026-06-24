using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float moveSpeed;
    float Xinp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Xinp = Input.GetAxis("Horizontal");
        transform.Translate(Xinp * moveSpeed * Time.deltaTime, 0, 0);

        if (transform.position.y < -5f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "stone")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
