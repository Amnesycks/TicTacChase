using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour
{
    public int objectNumber;
    public GameObject obstaclePrefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i != objectNumber; i++)
        {
            Instantiate(obstaclePrefab,
                        new Vector3(Random.Range(-37, 2), 
                        Random.Range(-1, 2),
                        Random.Range(0, 39)),
                        Quaternion.identity,
                        this.transform);
        }
    }
}
