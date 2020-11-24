using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenBlock : MonoBehaviour
{
    public Object Wall;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(wall, new Vector3(5.0f * x, 5.0f, 5.0f * z), Quaternion.identity);
        Instantiate(Wall, new Vector3(0, 5.0f, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Jump"))
        {

            Instantiate(Wall, new Vector3(0, 5.0f, 0), Quaternion.identity);
        }    
    }
}
