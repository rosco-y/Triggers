using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    Rigidbody playerRB;
    public float speed = 5;

    private void Awake()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveH, 0, moveV);

        playerRB.AddForce(move * Time.deltaTime * speed);

    }
}
