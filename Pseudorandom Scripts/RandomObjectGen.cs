using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectGen : MonoBehaviour
{
    public GameObject sphere;
    public GameObject sphere2;
    int xPositive;
    int zPositive;
    int objectQuantity;
    int randomSeedS;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ObjectGenerator());
    }

    IEnumerator ObjectGenerator()
     {
        Random.InitState(42);
        while (objectQuantity < 10)
        {
            xPositive = Random.Range(-100, 100);
            zPositive = Random.Range(-100, 100);
            Instantiate(sphere2, new Vector3(xPositive, 1, zPositive), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            objectQuantity++;
        }
        objectQuantity = 0;
        while (objectQuantity < 10)
        {
            randomSeedS = (int)System.DateTime.Now.Ticks;
            Random.InitState(randomSeedS);
            xPositive = Random.Range(200, 400);
            zPositive = Random.Range(-100, 100);
            Instantiate(sphere, new Vector3(xPositive, 1, zPositive), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            objectQuantity++;
        }
    }
}
