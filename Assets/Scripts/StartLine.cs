using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLine : MonoBehaviour
{
    public float maxDistance = 50f;
    public LayerMask layerToCollide;
    public UnityEngine.Vector3 direction;
    public GameObject salida;
    private bool Active = true;
    public static float timer = 0f;
    bool startTimer = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Raycast();
        updateTimer();
    }

    private void Raycast()
    {

        RaycastHit hit;
        Ray ray;

        // if (Physics.Raycast(transform.position, direction, out hit, maxDistance, layerToCollide))
        // {
        //     Debug.Log(hit.distance);

        // }
        if (Physics.Raycast(salida.transform.position, direction, out hit, Mathf.Infinity, layerToCollide) && Active)
        {
            Debug.DrawRay(salida.transform.position, direction * hit.distance, Color.yellow);
            Debug.Log("Timer Start");
            Active = false;
            startTimer = true;

        }
        else
        {
            Debug.DrawRay(salida.transform.position, direction * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
    

    }

    void updateTimer()
    {
        if (startTimer)
        {
            timer += Time.deltaTime;
        }
    }
}
