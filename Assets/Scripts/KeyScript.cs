using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public EndingController endingController;
    public Animation anim;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.Play("door");
            endingController.key = true;
            Destroy(gameObject);
        }
    }
}
