using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationScript : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(30f * Time.deltaTime, 30f * Time.deltaTime, 30f * Time.deltaTime);
    }
}
