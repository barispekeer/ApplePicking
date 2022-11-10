using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundControl : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("Apple"))
        {
            float random = Random.Range(-3.5f, 11.4f);
            collision.gameObject.transform.position = new Vector3(random, 8.3f, -7.2f);
        }
    }
}
