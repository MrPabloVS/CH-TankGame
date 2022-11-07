using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoobyTrap : MonoBehaviour
{
    public float maxDistance = 50f;
    public LayerMask layerToCollide;
    private bool Active = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Raycast();
    }

    private void Raycast()
    {

        RaycastHit hit;
        Ray ray;

        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance, layerToCollide))
        {
            Debug.Log(hit.distance);

        }

    }


}
