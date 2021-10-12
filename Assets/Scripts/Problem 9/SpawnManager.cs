using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] kotakobjek;
    public float minX, maxX, minY, maxY;
    // Start is called before the first frame update
    void Start()
    {
        int objectCount = 10;
        for (int i = 0; i < objectCount; i++)
        {
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            int randomObject = Random.Range(0, kotakobjek.Length);
            GameObject kotak = Instantiate(kotakobjek[randomObject], new Vector2(randomX, randomY), Quaternion.identity) as GameObject;
            kotak.transform.SetParent(GameObject.FindGameObjectWithTag("Spawn").transform, false);
        }
        StartCoroutine(SpawnKotak());
    }

    IEnumerator SpawnKotak()
    {
        if (transform.childCount < 10)
        {
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            int randomObject = Random.Range(0, kotakobjek.Length);
            GameObject kotak = Instantiate(kotakobjek[randomObject], new Vector2(randomX, randomY), Quaternion.identity) as GameObject;
            kotak.transform.SetParent(GameObject.FindGameObjectWithTag("Spawn").transform, false);
        }
        yield return new WaitForSeconds(1);
        StartCoroutine(SpawnKotak());
    }
}
