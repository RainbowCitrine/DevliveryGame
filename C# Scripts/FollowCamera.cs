using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // The Camera's Position should be the same as the car's position
    [SerializeField] GameObject thingToFollow;
    // Start is called before the first frame update

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0, 0 , -10); //Use vectors to get the correct spacing between the 2d platform 
    }
}
