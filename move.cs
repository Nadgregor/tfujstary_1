using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject sus;
    int x = 6;
    int y = 1;
    void Update()
    {
        float z = sus.transform.position.z;
        if (y == 1)
        {
            if (z > 100)
            {
                x += 2;
                y++;
            }
        }
        if(y == 2)
        {
            if(z > 500)
            {
                x += 2;
                y++;
            }
        }
        if (y == 3)
        {
            if (z > 1000)
            {
                x += 2;
                y++;
            }
        }
        transform.Translate(Vector3.forward * x * Time.deltaTime);
        
    }
}
