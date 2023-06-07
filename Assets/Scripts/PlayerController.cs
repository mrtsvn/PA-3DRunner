using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int runSpeed;
    void Start()
    {
        
    }


    void Update()
    {
        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + runSpeed * Time.deltaTime);
        transform.position = newPosition;
    }
}
