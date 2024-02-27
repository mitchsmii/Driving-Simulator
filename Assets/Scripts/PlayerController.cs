using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// The ':' means that this playercontroller inherits from a class called MonoBehavior
public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * 30);
    }
}
