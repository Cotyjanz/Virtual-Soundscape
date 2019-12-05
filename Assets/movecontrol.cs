using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecontrol : MonoBehaviour
{
	public float movementSpeed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if (Input.touchCount > 0) {
    		transform.position += Camera.main.transform.forward * Time.deltaTime * movementSpeed;
    	}

    }
}
