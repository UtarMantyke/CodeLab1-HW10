using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetsCollide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start ()
    {
        InvokeRepeating("Spawn", 3, 5f); //Call Spawn after 3 seconds and then every half second
    }
	
    // Update is called once per frame
    void Update () {
		
    }

    void Spawn()
    {
        GameObject newFollower = Instantiate(Resources.Load<GameObject>("Prefabs/Follower"));
        newFollower.transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10,10));
    }
}
