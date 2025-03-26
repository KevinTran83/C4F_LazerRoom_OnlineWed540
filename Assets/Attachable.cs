using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attachable : MonoBehaviour
{
    void OnCollisionStay(Collision collision)
    {
        if (collision.transform.parent != null) return;
        if (collision.transform.tag == "Player")
            collision.transform.SetParent(transform);
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Player")
            collision.transform.SetParent(null);
    }
}
