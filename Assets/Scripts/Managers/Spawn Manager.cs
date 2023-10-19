using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnManager : MonoBehaviour
{
    private float timeRemaining = 2;
    static private int count = 0;

    [SerializeField] private GameObject objectToSpawn;


    private void Start()
    {

    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {

            ResetOject();
            timeRemaining = Random.Range(1, 4);
        }
    }

    void ResetOject()
    {

        if (count < 9)
        {

        transform.position = new Vector2(Random.Range(-6.0f, 6.0f), 6);

        count += 1;
        }
    }


}
