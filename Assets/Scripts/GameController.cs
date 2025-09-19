using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    // UI
    public TMP_Text pointsText;
    
    // Ball Spawn
    public Transform spawnPoint;
    public GameObject[] randomBall;
    public bool canSpawn = true;

    // Points
    public int points;
    public int positiveValue = 10;
    public int negativeValue = -10;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        if (canSpawn)
        {
            SpawnBall();
        }
    }

    private void FixedUpdate()
    {
        UpdateDisplay();
    }

    void UpdateDisplay()
    {
        pointsText.text = points.ToString();
    }

    private void Update()
    {
        if (canSpawn)
        {
            SpawnBall();
        }
        Debug.Log("Points: " + points);
    }

    void SpawnBall()
    {
        if (canSpawn)
        {
            // Pick random spawn points and random asteroid prefabs
            int randomBallIndex = Random.Range(0, randomBall.Length);
            GameObject randomBallPrefab = randomBall[randomBallIndex];

            // Spawn
            Instantiate(randomBallPrefab, spawnPoint.position, Quaternion.identity);

            canSpawn = false;
        }
    }
}
