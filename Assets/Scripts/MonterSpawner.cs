using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonterSpawner : MonoBehaviour
{
    public GameObject[] Monters;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate<GameObject>(Monters[0], transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
