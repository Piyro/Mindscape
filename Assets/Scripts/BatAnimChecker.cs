using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatAnimChecker : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        GetComponent<Animator>().SetTrigger("Passed");
        Destroy(gameObject, 2.0f);
    }
}
