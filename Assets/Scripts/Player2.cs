using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float inpX;
    public float moveSpeed;




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        inpX = Input.GetAxis("Horizontal");
        transform.Translate(inpX * moveSpeed * Time.deltaTime, 0 ,0 );

        if (gameObject.transform.position.y < -5f )
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "obsticles")
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
