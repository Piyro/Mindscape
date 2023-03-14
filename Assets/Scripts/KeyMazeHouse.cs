using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMazeHouse : MonoBehaviour
{
    bool doorKey = false;
    public Transform cam;
    public float playerActivateDist;
    bool active = false;

    void Update()
    {
        RaycastHit hit;
        active = Physics.Raycast(cam.position, cam.TransformDirection(Vector3.forward), out hit, playerActivateDist);

        if (Input.GetKeyDown(KeyCode.E) && active == true)
        {
            if (doorKey == true)
            {
                if (hit.transform.GetComponent<Animator>() != null)
                {
                    hit.transform.GetComponent<Animator>().SetTrigger("Activate");
                }
            }
            
        }
    }
}

