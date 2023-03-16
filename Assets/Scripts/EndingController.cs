using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingController : MonoBehaviour
{
    public GameObject fallEnding;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "StoreFallEnding")
        {
            fallEnding.SetActive(true);
        }
    }
}
