using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    private float rotationspeed = 1500.0f; //set rotationspeed to float 1500.0f

    // Start is called before the first frame update
    void Start()
    {
     

    }

    // Update is called once per frame
    void Update()
    {

        // use transform.Rotate to call Transfor and Rotation, use .forward to change Z Axis value, times Time.deltaTime to make it the same for everyone/rotate in Realtime times rotationspeed.
        transform.Rotate(Vector3.forward * Time.deltaTime * rotationspeed); 
       

    }
}
