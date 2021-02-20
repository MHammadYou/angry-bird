using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFly : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            for (var i = 1; i <= 8; i++)
            {
                var pos = transform.position;
                i /= 5;
                transform.position = new Vector3(pos.x + 1, pos.y + i, pos.z);
            }
        }
    }
}
