using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Triggerenter : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {

        SceneManager.LoadScene("start");
        Debug.Log("dupa");
    }
}
