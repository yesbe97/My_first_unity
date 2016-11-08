using UnityEngine;

public class bulletController : MonoBehaviour
{
    private Rigidbody rb;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void fixedUpdate () {
        rb.transform.position += Vector3.forward * Time.deltaTime * 2;
    }
}
