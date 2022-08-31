using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class ates : MonoBehaviour
{
    public Transform Mer;
    public GameObject mermmi;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(mermmi, Mer.position, Mer.rotation);

        }
        

    }

    
    
}
