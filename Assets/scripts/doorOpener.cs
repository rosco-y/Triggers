using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpener : MonoBehaviour
{
    public Transform door;
    bool open = false;
    public Vector3 openPosition;
    public Vector3 closePosition;
    public float doorSpeed;


    private void Update()
    {
        if (open)
        {
            door.position = Vector3.Lerp(door.position, openPosition, Time.deltaTime * doorSpeed); 
        }
        else
        {
            door.position = Vector3.Lerp(door.position, closePosition, Time.deltaTime * doorSpeed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        open = true;
    }

    private void OnTriggerExit(Collider other)
    {
        open = false;
    }
}
