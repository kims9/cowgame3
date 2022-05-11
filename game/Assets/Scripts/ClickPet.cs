using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPet : MonoBehaviour
{
    //Here, we declare variables.
    public GameObject heartcenter;
    public GameObject ball;
    public GameObject carrot;
    public GameObject brush;
    public GameObject heartspawninglocation;
    public GameObject ballspawninglocation;
    public GameObject carrotspawninglocation;
    public GameObject brushspawninglocation;
    //public means the var is exposed in the inspector, which is super helpful.
    public float timeLeft, originalTime;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(heart);
    }

    // Start is called before the first frame update
    //public void OnItemClicked()
    //{
        
    //}

    public void SpawnPetHeart()
    {
        //spawn our heart:
        Instantiate(heartcenter, heartspawninglocation.transform.position, Quaternion.identity);
    }

    public void SpawnPlayBall()
    {
        Instantiate(ball, ballspawninglocation.transform.position, Quaternion.identity);
    }

        public void SpawnFeedCarrot()
    {
        Instantiate(carrot, carrotspawninglocation.transform.position, Quaternion.identity);
    }

        public void SpawnGroomBrush()
    {
        Instantiate(brush, brushspawninglocation.transform.position, Quaternion.identity);
    }
}
