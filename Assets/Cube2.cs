using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cube2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SceneManager.LoadScene("Scene1");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("num:" + Cube1.instance.GetNum());
        }
    }
}
