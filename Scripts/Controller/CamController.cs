using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public Dictionary<string, GameObject> Cameras = new Dictionary<string, GameObject>();
    public GameObject[] cams;
    void Start()
    {
        for (int i = 0; i < cams.Length; i++)
        {
            Cameras.Add(cams[i].name, cams[i]);
        }
        
    }

    public void cameraActivate(string Camera)
    {
        
        for(int i = 0; i < cams.Length; i++)
        {
            cams[i].SetActive(false);
        }
        Cameras[Camera].SetActive(true);

    }
    
}
