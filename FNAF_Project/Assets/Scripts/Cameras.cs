using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{
    public Camera office;
    public Camera cam01;

    public GameObject camUp;
    public GameObject camDown;

    // Start is called before the first frame update
    void Start()
    {
        office.gameObject.SetActive(true);
        cam01.gameObject.SetActive(false);

        camUp.SetActive(true);
        camDown.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CamUp()
    {
        office.gameObject.SetActive(false);
        cam01.gameObject.SetActive(true);

        camUp.SetActive(false);
        camDown.SetActive(true);
    }

    public void CamDown()
    {
        office.gameObject.SetActive(true);
        cam01.gameObject.SetActive(false);

        camUp.SetActive(true);
        camDown.SetActive(false);
    }
}
