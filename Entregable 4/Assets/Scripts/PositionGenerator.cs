using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PositionGenerator : MonoBehaviour
{
    private Vector3 randomPos;
    private float randomX;
    private float randomY;
    private float randomZ;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = RandomPosition();
        }

    }
    public Vector3 RandomPosition()
    {
        randomX = Random.Range(0f, 8f);
        randomY = Random.Range(0f, 8f);
        randomZ = Random.Range(0f, 8f);
        randomPos = new Vector3(randomX, randomY, randomZ);
        return randomPos;

    }
}
