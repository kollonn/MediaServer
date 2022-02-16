using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera Camera_SecurityRoom;
    
    public Camera Camera_1A;
    public Camera Camera_1B;
    public Camera Camera_1C;
    public Camera Camera_2A;
    public Camera Camera_2B;
    public Camera Camera_3;
    public Camera Camera_4A;
    public Camera Camera_4B;
    public Camera Camera_5;
    public Camera Camera_6;
    public Camera Camera_7;

    protected Camera[] cameras;

    protected int currentCamera;

    void Awake()
    {
        cameras = new Camera[12];

        cameras[0] = Camera_SecurityRoom;
        cameras[1] = Camera_1A;
        cameras[2] = Camera_1B;
        cameras[3] = Camera_1C;
        cameras[4] = Camera_2A;
        cameras[5] = Camera_2B;
        cameras[6] = Camera_3;
        cameras[7] = Camera_4A;
        cameras[8] = Camera_4B;
        cameras[9] = Camera_5;
        cameras[10] = Camera_6;
        cameras[11] = Camera_7;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void incCamera()
    {
        cameras[currentCamera].enabled = false;

        currentCamera++;

        if (currentCamera > cameras.Length)
        {
            currentCamera = 0;
        }

        cameras[currentCamera].enabled = false;
    }

    void decCamera()
    {
        cameras[currentCamera].enabled = false;

        currentCamera--;

        if (currentCamera > cameras.Length)
        {
            currentCamera = cameras.Length-1;
        }

        cameras[currentCamera].enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            incCamera();

        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            decCamera();

        }

    }
}
