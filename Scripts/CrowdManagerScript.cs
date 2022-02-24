using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdManagerScript : MonoBehaviour
{
    public GameObject capsulePrefab;
    public int crowdSize;
    private List<GameObject> crowdMembers;

    // Start is called before the first frame update
    void Start()
    {
        crowdMembers = new List<GameObject>();
        for (int i = 1; i < crowdSize; i++)
        {
            Vector3 pos = this.transform.position + new Vector3(Random.Range(-1, 1), 0, Random.Range(-1, 1));
            crowdMembers.Add((GameObject) Instantiate(capsulePrefab, pos, Quaternion.identity, this.transform));
        }
    }
}