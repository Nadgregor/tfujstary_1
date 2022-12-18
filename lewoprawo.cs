using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lewoprawo : MonoBehaviour
{
    int x = 0;
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            x--;
            Debug.Log(x);
            if (x > -2)
            {
                transform.position += new Vector3(-1.2f , 0, 0);
            }else
            {
                x++;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            x++;
            Debug.Log(x);
            if (x < 2)
            {
                transform.position += new Vector3(1.2f, 0 ,0);
            }
            else
            {
                x--;
            }
        }
    }
}
