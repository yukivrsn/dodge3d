using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Stone;
    public float minX, maxX;

    public Transform spawnPoint;

    int score = 0;

    public TextMeshProUGUI scoreText;
    void Start()
    {
        InvokeRepeating("SpawnStone", 0.5f, 1f);
        InvokeRepeating("UpdateScore", 3f, 2f);

           
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnStone()
    {
        Vector3 spawnnPos = spawnPoint.position;

        spawnnPos.x = Random.Range(minX, maxX);
        Instantiate(Stone, spawnnPos, Quaternion.identity);
    }

    void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }


}
