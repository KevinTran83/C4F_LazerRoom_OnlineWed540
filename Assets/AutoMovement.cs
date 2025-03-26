using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovement : MonoBehaviour
{
    public float moveSpeed = 3;
    public bool  canLoop = true;

    private Vector3 fromPos, toPos;

    // Start is called before the first frame update
    void Start()
    {
        fromPos = transform.position;
        toPos   = transform.Find("Destination").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, toPos, moveSpeed*Time.deltaTime);

        if (canLoop)
        {
            if (Vector3.Distance(transform.position, toPos) <= 0.1f)
            {
                Vector3 temp = toPos;
                toPos        = fromPos;
                fromPos      = temp;
            }
        }
    }
}
