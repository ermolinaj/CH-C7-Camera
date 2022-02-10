using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] GameObject[] cameras;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F1) && !cameras[0].activeSelf)
            EnableCamera(0);
        if (Input.GetKey(KeyCode.F2) && !cameras[1].activeSelf)
            EnableCamera(1);
    }

    void EnableCamera(int cameraIndex)
    {
        for (int i = 0; i < cameras.Length; i ++)
        {
            if (cameraIndex == i)
                cameras[i].SetActive(true);
            else
                cameras[i].SetActive(false);
        }
    }
}
