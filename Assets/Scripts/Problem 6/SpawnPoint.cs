using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public float minX, maxX, minY, maxY; //minimal dan maximal batas layar dari spawn kotak
    public GameObject kotakPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        int objectCount = Random.Range(5,10); //memberikan nilai random munculnya kotak
        for (int i = 0; i < objectCount; i++)
        {
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            Instantiate(kotakPrefabs, new Vector2(randomX, randomY), Quaternion.identity);
        }
    }
}
