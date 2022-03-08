using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;

        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit, 500f)&& hit.rigidbody != null)
        {
            hit.rigidbody.AddForce(new Vector3(0f, 5f, 0f), ForceMode.Impulse);
        }
    }
}
