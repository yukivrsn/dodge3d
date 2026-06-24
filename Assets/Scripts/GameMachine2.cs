using TMPro;
using UnityEngine;

public class GameMachine2 : MonoBehaviour
{
    public GameObject Stone;
    public float minX, maxX;

    public Transform spawnPoint;

    int score = 0;

    public TextMeshProUGUI scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawObj()
    {
        Vector3 spawnStones = spawnPoint.transform.position;

    }
}
