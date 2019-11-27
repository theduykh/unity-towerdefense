using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monter : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.3f;
    private float previousTime;

    private Vector3 previousPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - previousTime > speed)
        {
            move();
            previousTime = Time.time;
        }
    }

    private void move()
    {
        previousPosition = transform.position;
        if (LevelManager.map[(int)transform.position.x+1, (int)transform.position.y] == 1)
        {
            if (transform.position + new Vector3(1, 0, 0) != previousPosition)
                transform.position += new Vector3(1, 0, 0);
            return;
        }
        if (LevelManager.map[(int)transform.position.x, (int)transform.position.y+1] == 1)
        {
            if (transform.position + new Vector3(0, -1, 0) != previousPosition)
                transform.position += new Vector3(0, -1, 0);
            return;
        }
        if (LevelManager.map[(int)transform.position.x-1, (int)transform.position.y] == 1)
        {
            if (transform.position + new Vector3(-1, 0, 0) != previousPosition)
                transform.position += new Vector3(-1, 0, 0);
            return;
        }
        if (LevelManager.map[(int)transform.position.x, (int)transform.position.y-1] == 1)
        {
            if (transform.position + new Vector3(0, 1, 0) != previousPosition)
                transform.position += new Vector3(0, 1, 0);
            return;
        }
    }
}
