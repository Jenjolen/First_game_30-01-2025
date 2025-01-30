using UnityEngine;

public class CubeScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody rigidbody;
    
    void Start()
    {
        // Vector3 position = new Vector3(50, 50, 50);
        rigidbody = GetComponent<Rigidbody>();
        // new Vector3(0, 1, 0); // x, y, z aksernes værdier.
       // rigidbody.AddForce(Vector3.up * 10000);
       
    //   gameObject //ref to self
      // transform // ref to self
       //GameObject // type
       //Transform // type
       
       
    //   transform.position = new Vector3(10, 20, 5);
      // GameObject go = new GameObject();
       //go.transform.parent = transform;
        Debug.Log("Hello World!");
    }

    // // Update is called once per frame
    // void Update()
    // {
    //  Debug.Log("Hello from update");   
    // }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("collided with" + col.gameObject.name);
        rigidbody.AddForce(Vector3.up * 1000); // når der kolliderer med noget, hopper den op med 1000 i y-aksen
    }
    
    
}
