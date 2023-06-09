using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingController : MonoBehaviour
{
    public Transform cam;
    public float playerActivateDist;
    bool active = false;
    public bool key = false;

    public GameObject storeEnding;
    public GameObject fallEnding;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "StoreFallEnding")
        {
            fallEnding.SetActive(true);
        }
    }

    void Update()
    {
        RaycastHit hit;
        active = Physics.Raycast(cam.position, cam.TransformDirection(Vector3.forward), out hit, playerActivateDist);
        if(key == true)
        {
            //store entrance ending
        }

    }
}
