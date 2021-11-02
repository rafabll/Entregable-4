using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionGenerator : MonoBehaviour
{
    public Vector3 RandomPosition;
    private float x;
    private float y;
    private float z;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Random.Range(0, 8);
        y = Random.Range(0, 8);
        z = Random.Range(0, 8);

        RandomPosition = new Vector3(x, y, z);

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = RandomPosition;
        }
    }
}
