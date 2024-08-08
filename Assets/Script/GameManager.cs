using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public GameManager Instance;

    public GameObject wallPrefab;
    public GameObject capsulePrefab;
    public GameObject isometricPrefab;

    public float spawnTerm = 4;

    public TextMeshProUGUI scoreLabel;

    public float score;

    float spawnTimer;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = 0;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        score += Time.deltaTime;

        scoreLabel.text = ((int)score).ToString();
        if(spawnTimer > spawnTerm)
        {
            int wallType = Random.Range(1, 4);
            Debug.Log(wallType);
            switch(wallType)
            {
                case 1:
                 GameObject wallprefab = Instantiate(wallPrefab);
                 wallprefab.transform.position = new Vector2(10, Random.Range(-2.75f, 2.75f));
                    break;

                case 2:
                 GameObject capsuleprefab = Instantiate(capsulePrefab);
                 capsuleprefab.transform.position = new Vector2(10, Random.Range(-2.75f, 2.75f));
                    break;

                case 3:
                    GameObject isometricprefab = Instantiate(isometricPrefab);
                    isometricPrefab.transform.position = new Vector2(10, Random.Range(-2.75f, 2.75f));
                    break;
            }
            spawnTimer -= spawnTerm;
        }
    }
}
