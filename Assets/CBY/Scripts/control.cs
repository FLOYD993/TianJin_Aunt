using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(horizontal, 0, vertical);
        if (dir != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(dir);
            transform.Translate(Vector3.forward * 2 * Time.deltaTime);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(1);
        if (collision != null)
        {
            Debug.Log(2);
            collision.transform.parent= transform;
        }
    }
}
