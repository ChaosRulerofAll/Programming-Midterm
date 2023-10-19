using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnManager : MonoBehaviour
{

    // I know this is titled 'SpawnManager' but this is the candy's script

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
            this.enabled = true;

            transform.position = new Vector2(Random.Range(-6.0f, 6.0f), 6);

            count += 1;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
         if (collision.gameObject.tag == "Ground")
        {
            this.enabled = false;
        }

        if (collision.gameObject.name == "Player")
        {
            this.enabled = false;
        }
    }

}
