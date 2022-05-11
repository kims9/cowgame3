using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Here, we declare variables.
    public GameObject objectToSpawn;
    //public means the var is exposed in the inspector, which is super helpful.
    public float timeLeft, originalTime;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(objectToSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        //tick down our timer:
        timeLeft -= Time.deltaTime;
        //timeLeft = timeLeft - Time.deltaTime;
        if(timeLeft<=0)
        {
            SpawnIt();

            //reset the time:
            timeLeft = originalTime;
        }

        //let's also spawn on button press:
        if(Input.GetButtonDown("Jump"))
        {
            SpawnIt();
        }
    }

    void SpawnIt()
    {
        //spawn our coin:
        Instantiate(objectToSpawn, transform.position, Quaternion.identity);
    }
}