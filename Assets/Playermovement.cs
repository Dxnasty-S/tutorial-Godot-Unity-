using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 8.0f;
    private Rigidbody Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody = GetComponent<Rigidbody>();
        PlayerMove();   
    }

    void PlayerMove()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
        Rigidbody.AddForce(direction * _speed);

        if(horizontalInput == 0 && verticalInput == 0)
        {
            Rigidbody.velocity = Vector3.zero;
        }
    }

    void Shoot()
    {

    }



}
