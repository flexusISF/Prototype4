using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonControl : MonoBehaviour
{
    public GameObject cannonBall;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)
        {


        }
       if(Input.GetKeyDown (KeyCode.E))
        {
            Shoot(Random.Range(10,100));  
        }
    }
    public void Shoot(int numberOfBalles)
    {
        for(int i = 0; i < numberOfBalles; i++)
        {
            Instantiate(cannonBall, transform.position, transform.rotation);
        }
    }
    IEnumerator SteadyShot(int numberOfBalles, float delay)
    {
        for (int i = 0; i)
    }
}
