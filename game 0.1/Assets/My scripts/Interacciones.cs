using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacciones : MonoBehaviour
{
    public Transform playercamera;
    public float distancia;
    public Transform manos;
    public LayerMask l;
    private void Update()
    {
        Debug.DrawRay(playercamera.position, playercamera.forward * 3F, Color.red);
        RaycastHit hit;
        if(Physics.Raycast(playercamera.position,playercamera.forward,out hit, distancia,l) && l == LayerMask.GetMask("interaccion"))
        {
           
            if(hit.transform.tag == "Box")
            {
                // Indicarle al jugador el objeto
                if (Input.GetButtonDown("Fire1"))
                {
                    hit.transform.parent = manos;
                    hit.transform.GetComponent<Rigidbody>().isKinematic = true;
                    hit.transform.position = manos.position;
                    l = LayerMask.GetMask("Default");
                }
               
            }
           
        }
        else if (manos.childCount != 0 && Input.GetButtonDown("Fire1"))
        {
            manos.GetComponentInChildren<Rigidbody>().isKinematic = false;
            manos.transform.DetachChildren();
            l = LayerMask.GetMask("interaccion");
        }
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Door")
        {
           
           other.GetComponentInParent<puerta>().OnOpenDoor();

        }
        if (other.tag == "Batery")
        {

            other.GetComponent<Baterias>().Baterys();
            
        }
       
        
    }
                    
           
            
               

               
                 
            
    

}
