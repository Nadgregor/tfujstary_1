using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using UnityEngine;




public class floor : MonoBehaviour
{
    public GameObject sus;
    public GameObject sus1;
    float x = 20;
    void Update()
    {
        float z = Mathf.Round(sus.transform.position.z);
        if (z == x)
        {
            if (z % 20 == 0)
            {
                
                GameObject go = GameObject.Instantiate(sus1);
                go.transform.position = new Vector3(0, -1, z + 30);
                x += 20;
            }
        }
    }

}