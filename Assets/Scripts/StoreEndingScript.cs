using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreEndingScript : MonoBehaviour
{
    public Transform cam;
    public float playerActivateDist;
    bool active = false;
    public GameObject storeEnding;

    void Update()
    {
        RaycastHit hit;
        active = Physics.Raycast(cam.position, cam.TransformDirection(Vector3.forward), out hit, playerActivateDist);

        if (Input.GetKeyDown(KeyCode.E) && active == true)
        {
            storeEnding.SetActive(true);
        }
    }
}
