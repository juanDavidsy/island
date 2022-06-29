using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma : MonoBehaviour
{
    public GameObject plataform;
   
    public Transform minposition;
    public Transform maxposition;
    public float speedm;
   
    public void OnTriggerStay(Collider other)
    {
        if(other != null)
        {
           Moveplataform();
         
        }
 
    }
    
    private void Moveplataform()
    {
        if (plataform.transform.position.y >= maxposition.position.y && speedm> 0)
        {
            speedm = speedm * -1f;
        }

        if (plataform.transform.position.y <= minposition.position.y &&speedm < 0)
        {
            speedm = speedm * -1f;
        }

        plataform.transform.Translate(Vector3.up * Time.deltaTime * speedm);

    }





}
