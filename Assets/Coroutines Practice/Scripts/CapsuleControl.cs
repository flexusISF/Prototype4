using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleControl : MonoBehaviour
{
    //VARIABLES

    [Header("Movement")]
    public float moveSpeed;
    public float turnSpeed;
    public float jumpForce;
    public bool isOnGround = true;
    private float verticalInput;
    private float horizontalInput;
    private Rigidbody rb;

    [Header("Shooting")]
    public GameObject projectile;
    public float shootDelay;
    public bool canShoot = true;
    public GameObject spawnPoint;


    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //Forward and Backward Movement




        //Clockwise and counterclockwise Rotation



        
        //Jumping
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            isOnGround = false;
            rb.AddForce(Vector3.up * jumpForce);
        }


        
        //Shooting
        if (Input.GetMouseButtonDown(0) && canShoot)
        {
            StartCoroutine(Shoot());s
        }



    }

    IEnumerator Shoot()
    {
        canShoot = false;
        //Shoot a projectile 
        Instantiate(projectile, spawnPoint.transform.position, spawnPoint.transform.rotation);

        //Wait 
        yield return new WaitForSeconds(shootDelay);

        canShoot = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
