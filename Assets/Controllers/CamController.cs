using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    float speed=0.5f;
    // Start is called before the first frame update
    void Start()
    {
        Transform transform=GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) transform.position= new Vector3(transform.position.x, transform.position.y+speed, -10);
        if(Input.GetKey(KeyCode.A)) transform.position= new Vector3(transform.position.x-speed, transform.position.y, -10);
        if(Input.GetKey(KeyCode.S)) transform.position= new Vector3(transform.position.x, transform.position.y-speed, -10);
        if(Input.GetKey(KeyCode.D)) transform.position= new Vector3(transform.position.x+speed, transform.position.y, -10);
    }
}
