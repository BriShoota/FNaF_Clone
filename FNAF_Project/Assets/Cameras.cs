using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameras : MonoBehaviour
{
    public Camera office;
    public Camera cam01;

    // Start is called before the first frame update
    void Start()
    {
        office.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
