using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public float deathY = 0.05f;
    private Vector3    spawnPos;
    private Quaternion spawnRot;
    private Rigidbody  rb;

    void Start()
    {
        spawnPos = transform.position;
        spawnRot = transform.rotation;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (transform.position.y <= deathY) DoRespawn();
    }

    public void DoRespawn()
    {
        transform.position = spawnPos;
        transform.rotation = spawnRot;
        rb.velocity = Vector3.zero;
    }
}
