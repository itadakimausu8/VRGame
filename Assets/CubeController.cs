using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Material material1;
    public Material material2;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("衝突");
            this.gameObject.GetComponent<MeshRenderer>().material = material1;
        }
    }

    private void OnCollisionExit(Collision collision)
    {


        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("出たよ");
            this.gameObject.GetComponent<MeshRenderer>().material = material2;
        }
    }

}
