using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpener : MonoBehaviour
{
    public Transform door;
    bool open = false;
    Vector3 openPosition;
    Vector3 closePosition;
    public float doorSpeed;

    private void Awake()
    {
        closePosition = door.position;
        openPosition = new Vector3(closePosition.x, closePosition.y + 1f, closePosition.z);
    }

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
        if (other.tag == "Player")
        {
            open = true;
            print("Opening Door.");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            open = false;
            print("Closing Door.");
        }
    }
}
