using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakroi : MonoBehaviour
{
    public GameObject sus;
    public GameObject es;
    float x = 4;
    int i = 0;
    int y = 0;
    int o = 0;
    void Update()
    {
        float z = Mathf.Round(sus.transform.position.z);
        if (z == x)
        {
            if (z % 4 == 0)
            {
                i = Random.Range(1, 5);
                if (i == 1)
                {
                    y = Random.Range(1, 5);
                    switch(y)
                    {
                        case 1:
                        o = Random.Range(2, 4);
                        GameObject goo = GameObject.Instantiate(es);
                        goo.transform.position = new Vector3(0, 0, z + 30 + o);
                        GameObject googfn = GameObject.Instantiate(es);
                        googfn.transform.position = new Vector3(-1.2f, 0, z + 30 + o);
                            break;

                        case 2:
                        o = Random.Range(2, 4);
                        GameObject gnoo = GameObject.Instantiate(es);
                        gnoo.transform.position = new Vector3(0, 0, z + 30 + o);
                        GameObject goorn = GameObject.Instantiate(es);
                        goorn.transform.position = new Vector3(1.2f, 0, z + 30 + o);
                            break;
                        case 3:
                        o = Random.Range(2, 4);
                        GameObject gono = GameObject.Instantiate(es);
                        gono.transform.position = new Vector3(-1.2f, 0, z + 30 + o);
                        GameObject goon = GameObject.Instantiate(es);
                        goon.transform.position = new Vector3(1.2f, 0, z + 30 + o);
                            break;
                        case 4:
                            o = Random.Range(2, 4);
                            GameObject gonwo = GameObject.Instantiate(es);
                            gonwo.transform.position = new Vector3(0, 0, z + 30 + o);
                            break;
                    }
                    
                }
                else
                {
                    y = Random.Range(1, 4);
                    switch (y)
                    {
                        case 1:
                            o = Random.Range(2, 4);
                            GameObject go = GameObject.Instantiate(es);
                            go.transform.position = new Vector3(-1.2f, 0, z + 30 + o);
                            break;
                        case 2:
                            o = Random.Range(2, 4);
                            GameObject goo = GameObject.Instantiate(es);
                            goo.transform.position = new Vector3(0, 0, z + 30 + o);
                            break;
                        case 3:
                            o = Random.Range(2, 4);
                            GameObject oo = GameObject.Instantiate(es);
                            oo.transform.position = new Vector3(1.2f, 0, z + 30 + o);
                            break;
                        

                    }
                }
                }
                x += 4;
            }
        }
    }
