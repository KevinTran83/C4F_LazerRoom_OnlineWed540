using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour
{
    public float maxLength = 10;
    private LineRenderer lr;

    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        lr.positionCount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        lr.SetPosition(0, transform.position);                                 // Point A
        lr.SetPosition(1, transform.position + transform.forward * maxLength); // Point B
    }
}
